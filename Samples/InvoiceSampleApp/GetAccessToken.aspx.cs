using System;

namespace InvoicingSampleApp
{
    public partial class GetAccessToken : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            this.txtrequest_token.Value = Request.QueryString["request_token"].ToString();
            this.txtverification_code.Value = Request.QueryString["verification_code"].ToString();
            this.source.Value = Request.Params["source"];
        }

        protected void btnGetAccessToken_Click(object sender, EventArgs e)
        {

        }
    }
}
