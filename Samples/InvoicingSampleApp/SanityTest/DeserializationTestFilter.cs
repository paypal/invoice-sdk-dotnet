using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using PayPal.Util;

namespace InvoicingSampleApp.SanityTest
{
    public class DeserializationTestFilter : IHttpModule
    {
        private HttpApplication httpApp;

        public void Init(HttpApplication httpApp)
        {
            this.httpApp = httpApp;
            httpApp.PostRequestHandlerExecute +=
                        (new EventHandler(this.Application_PreSendRequestContent));
        }

        private void Application_PreSendRequestContent(Object source,
          EventArgs e)
        {
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;

            if (context.Items.Contains("responseObject")) {
                Object responseObj = context.Items["responseObject"];       
                String originalResponse = (String) context.Items["responsePayload"];
                Dictionary<string, string> constructedMap = ReflectionUtil.decodeResponseObject(responseObj, "");
                NVPUtil nvpUtil = new NVPUtil();
                Dictionary<string, string> originalMap = nvpUtil.ParseNVPString(originalResponse);

                if (!originalMap.Equals(constructedMap)) {			        
			        foreach (String key in originalMap.Keys) {
				        if (!originalMap[key].Equals(constructedMap[key])) {
					        context.Response.Write(
                                "Original: " + key + " => " + originalMap[key]
									+ " : " + "Constructed: " + key + " => "
							        + constructedMap[key] + "<br/>");
				        }
			        }
		        }
            }            
        }

        public void Dispose()
        { }
    }
}
