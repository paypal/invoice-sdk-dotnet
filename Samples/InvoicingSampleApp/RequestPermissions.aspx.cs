using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace InvoicingSampleApp
{
    public partial class RequestPermissions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < Request.QueryString.Count; i++)
            //{
            //    Response.Write(Request.QueryString.Keys[i] + " = " +Request.QueryString[i] + "<br>");
            //}
            this.txtrequest_token.Value = Request.QueryString["request_token"].ToString();
            this.txtverification_code.Value = Request.QueryString["verification_code"].ToString();
        }

        protected void btnGetAccessToken_Click(object sender, EventArgs e)
        {

        }
    }
}
