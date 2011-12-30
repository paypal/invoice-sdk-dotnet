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
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.Request.Params["token"] != null &&
                Context.Request.Params["tokensecret"] != null )
            {
                this.authentication.Checked = true;               
                this.accessToken.Text = Context.Request.Params["token"];
                this.tokenSecret.Text = Context.Request.Params["tokensecret"];
                this.permissions.Style.Add(HtmlTextWriterStyle.Display, "block");
            } 
            else
            {
                this.permissions.Style.Add(HtmlTextWriterStyle.Display, "none");
            }
            this.authentication.Attributes["onclick"] = "javascript: toggleDisplay('" + permissions.ClientID + "');";
        }
    }
}