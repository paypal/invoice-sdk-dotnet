using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InvoicingSampleApp
{
    public partial class CreateInvoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["token"]!=null)
            accessToken.Value=Request.QueryString["token"];
            if (Request.QueryString["tokensecret"] != null)
                tokenSecret.Value = Request.QueryString["tokensecret"];
        }
    }
}