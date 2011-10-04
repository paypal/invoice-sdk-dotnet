using System;
using System.Collections.Generic;
using System.Web;

using PayPal.Util;
using PayPal;
using PayPal.Invoice;
using PayPal.Invoice.Model;

using PayPal.Authentication;
using PayPal.Exception;
using System.Configuration;
namespace InvoicingSampleApp
{
    /// <summary>
    /// Summary description for InvoiceHandler
    /// </summary>
    public class InvoiceHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            String strCall = context.Request.Params["InvoiceBtn"];

            if(strCall.Equals("CreateInvoice")){
                CreateInvoice(context);
            }else if(strCall.Equals("CreateAndSendInvoice")){
                CreateAndSendInvoice(context);
            }else if(strCall.Equals("SendInvoice")){
                SendInvoice(context);
            }else if(strCall.Equals("RequestPermission")){
                RequestPermissions(context);
            }else if(strCall.Equals("GetAccessToken")){
                GetAccessToken(context);
            
                                
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


        private void CreateAndSendInvoice(HttpContext context)
        {

            String merchantEmail = context.Request.Params["merchantEmail"];
            String currencyCode = context.Request.Params["currencyCode"];
            String payerEmail = context.Request.Params["payerEmail"];
            String paymentTerms = context.Request.Params["paymentTerms"];
            String item_name1 = context.Request.Params["item_name1"];
            String item_quantity1 = context.Request.Params["item_quantity1"];
            String item_unitPrice1 = context.Request.Params["item_unitPrice1"];
            String item_name2 = context.Request.Params["item_name2"];
            String item_quantity2 = context.Request.Params["item_quantity2"];
            String item_unitPrice2 = context.Request.Params["item_unitPrice2"];

            CreateAndSendInvoiceRequest cr = new CreateAndSendInvoiceRequest();
            cr.requestEnvelope = new RequestEnvelope("en_US");

            cr.invoice = new InvoiceType();
            cr.invoice.currencyCode = currencyCode;
            cr.invoice.merchantEmail = merchantEmail;
            cr.invoice.payerEmail = payerEmail;
            cr.invoice.paymentTerms = PaymentTermsType.DUEONRECEIPT;            

           
           cr.invoice.itemList= new InvoiceItemListType();
           cr.invoice.itemList.item = new List<InvoiceItemType>();
            cr.invoice.itemList.item.Add(new InvoiceItemType(
                        item_name1,
                        decimal.Parse(item_quantity1),
                        decimal.Parse(item_unitPrice1)));
            cr.invoice.itemList.item.Add(new InvoiceItemType(
                        item_name2,
                        decimal.Parse(item_quantity2),
                        decimal.Parse(item_unitPrice2)));
            CreateAndSendInvoiceResponse cir = null;

            try
            {
                InvoiceService service = new InvoiceService();

                if (context.Request.Params["authentication"] != null)
                {
                    service.setAccessToken(context.Request.Params["accessToken"]);
                    service.setAccessTokenSecret(context.Request.Params["tokenSecret"]);

                }
                cir = service.CreateAndSendInvoice(cr);
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(cir, 5, context.Response.Output);
                context.Response.Write("</textarea></body></html>");
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }
        }

        private void SendInvoice(HttpContext context)
        {

            String invoiceId = context.Request.Params["invoiceId"];
            
            SendInvoiceRequest sr = new SendInvoiceRequest();
            sr.invoiceID = invoiceId;
            sr.requestEnvelope = new RequestEnvelope("en_US");
            
            SendInvoiceResponse sir = null;

            try
            {
                InvoiceService service = new InvoiceService();

                if (context.Request.Params["authentication"] != null)
                {
                    service.setAccessToken(context.Request.Params["accessToken"]);
                    service.setAccessTokenSecret(context.Request.Params["tokenSecret"]);

                }
                sir = service.SendInvoice(sr);
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(sir, 5, context.Response.Output);
                context.Response.Write("</textarea></body></html>");
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }

        }

        private void CreateInvoice(HttpContext context)
        {

            String merchantEmail = context.Request.Params["merchantEmail"];
            String currencyCode = context.Request.Params["currencyCode"];
            String payerEmail = context.Request.Params["payerEmail"];
            String paymentTerms = context.Request.Params["paymentTerms"];
            String item_name1 = context.Request.Params["item_name1"];
            String item_quantity1 = context.Request.Params["item_quantity1"];
            String item_unitPrice1 = context.Request.Params["item_unitPrice1"];
            String item_name2 = context.Request.Params["item_name2"];
            String item_quantity2 = context.Request.Params["item_quantity2"];
            String item_unitPrice2 = context.Request.Params["item_unitPrice2"];

            CreateInvoiceRequest cr = new CreateInvoiceRequest();
            cr.requestEnvelope = new RequestEnvelope("en_US");


            cr.invoice = new InvoiceType();
            cr.invoice.currencyCode = currencyCode;
            cr.invoice.merchantEmail = merchantEmail;
            cr.invoice.payerEmail = payerEmail;
            cr.invoice.paymentTerms = PaymentTermsType.DUEONRECEIPT;

            cr.invoice.itemList = new InvoiceItemListType();
            cr.invoice.itemList.item = new List<InvoiceItemType>();
            cr.invoice.itemList.item.Add(new InvoiceItemType(
                        item_name1,
                        decimal.Parse(item_quantity1),
                        decimal.Parse(item_unitPrice1)));
            cr.invoice.itemList.item.Add(new InvoiceItemType(
                        item_name2,
                        decimal.Parse(item_quantity2),
                        decimal.Parse(item_unitPrice2)));
            CreateInvoiceResponse cir = null;

            try
            {
                InvoiceService service = new InvoiceService();
                
                if(context.Request.Params["authentication"]!=null)
                {
                    service.setAccessToken(context.Request.Params["accessToken"]);
                    service.setAccessTokenSecret(context.Request.Params["tokenSecret"]);
                    
                }
                cir = service.CreateInvoice(cr);
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(cir, 5, context.Response.Output);
                context.Response.Write("</textarea></body></html>");

            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }
        }



        private void RequestPermissions(HttpContext context)
        {

            String requestperm = "INVOICING";
            PayPal.Permissions.Model.RequestPermissionsRequest rp = new PayPal.Permissions.Model.RequestPermissionsRequest();           
            rp.scope = new List<string>();            
            rp.scope.Add(requestperm);

            string url = context.Request.Url.Scheme + "://" + context.Request.Url.Host + ":" + context.Request.Url.Port;
            string returnURL = url + "/RequestPermissions.aspx";
            //string returnURL = "http://localhost:2657/RequestPermissions.aspx";
            rp.callback = returnURL;
            rp.requestEnvelope = new PayPal.Permissions.Model.RequestEnvelope("en_US");
            PayPal.Permissions.Model.RequestPermissionsResponse rpr = null;

            try
            {
                PayPal.Permissions.PermissionsService service = new PayPal.Permissions.PermissionsService();                
                rpr = service.RequestPermissions(rp);
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(rpr, 5, context.Response.Output);               
                context.Response.Write("</textarea></body></html>");                

                string red = "<br>";
                red = red + "<a href=";
                red = red + ConfigurationManager.AppSettings["PAYPAL_REDIRECT_URL"] + "_grant-permission&request_token=" + rpr.token;
                red = red + ">Redirect URL (Click to redirect)</a><br>";
                context.Response.Write(red);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }

        }

        private void GetAccessToken(HttpContext context)
        {
            
            PayPal.Permissions.Model.GetAccessTokenRequest gat = new PayPal.Permissions.Model.GetAccessTokenRequest();

            String token = context.Request.Params["txtrequest_token"];
            String verifier = context.Request.Params["txtverification_code"];

            gat.token = token;
            gat.verifier = verifier;


            gat.requestEnvelope = new PayPal.Permissions.Model.RequestEnvelope("en_US");
            PayPal.Permissions.Model.GetAccessTokenResponse gats = null;

            try
            {
                PayPal.Permissions.PermissionsService service = new PayPal.Permissions.PermissionsService();
                gats = service.GetAccessToken(gat);                
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(gats, 5, context.Response.Output);
                context.Response.Write("</textarea></body></html>");

                context.Response.Redirect("createinvoice.aspx?token=" + gats.token + "&tokensecret="+gats.tokenSecret);
       
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }

        }



        
    }
}