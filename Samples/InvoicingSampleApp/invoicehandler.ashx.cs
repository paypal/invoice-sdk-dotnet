using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;

using PayPal;
using PayPal.Authentication;
using PayPal.Exception;
using PayPal.Invoice;
using PayPal.Invoice.Model;
using PayPal.Util;

namespace InvoicingSampleApp
{
    /// <summary>
    /// Summary description for InvoiceHandler
    /// </summary>
    public class InvoiceHandler : IHttpHandler
    {

        private static string ERROR_LANGUAGE = "en_US";

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            String strCall = context.Request.Params["InvoiceBtn"];

            if(strCall.Equals("CreateInvoice")) 
            {
                CreateInvoice(context);
            }
            else if(strCall.Equals("CreateAndSendInvoice")) 
            {
                CreateAndSendInvoice(context);
            }
            else if(strCall.Equals("SendInvoice")) 
            {
                SendInvoice(context);
            }
            else if (strCall.Equals("GetInvoiceDetails")) 
            {
                GetInvoiceDetails(context);
            }
            else if (strCall.Equals("MarkInvoiceAsPaid"))
            {
                MarkInvoiceAsPaid(context);
            }
            else if (strCall.Equals("CancelInvoice"))
            {
                CancelInvoice(context);
            }
            else if (strCall.Equals("UpdateInvoice"))
            {
                UpdateInvoice(context);
            }
            else if (strCall.Equals("SearchInvoices"))
            {
                SearchInvoices(context);
            }
            else if (strCall.Equals("RequestPermission"))
            {
                RequestPermissions(context);
            } 
            else if(strCall.Equals("GetAccessToken")) 
            {
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

        private InvoiceService getService(HttpContext context)
        {
            InvoiceService service = new InvoiceService();
            if (context.Request.Params["authentication"] != null)
            {
                service.setAccessToken(context.Request.Params["accessToken"]);
                service.setAccessTokenSecret(context.Request.Params["tokenSecret"]);
            }
            return service;
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
            cr.requestEnvelope = new RequestEnvelope(ERROR_LANGUAGE);

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
            CreateAndSendInvoiceResponse cir = null;

            try
            {
                InvoiceService service = getService(context);
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
            sr.requestEnvelope = new RequestEnvelope(ERROR_LANGUAGE);
            
            SendInvoiceResponse sir = null;

            try
            {
                InvoiceService service = getService(context);
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
            cr.requestEnvelope = new RequestEnvelope(ERROR_LANGUAGE);


            cr.invoice = new InvoiceType();
            cr.invoice.currencyCode = currencyCode;
            cr.invoice.merchantEmail = merchantEmail;
            cr.invoice.payerEmail = payerEmail;
            cr.invoice.paymentTerms = (PaymentTermsType) 
                Enum.Parse( typeof(PaymentTermsType), paymentTerms);

            cr.invoice.itemList = new InvoiceItemListType();
            cr.invoice.itemList.item = new List<InvoiceItemType>();
            cr.invoice.itemList.item.Add(
                new InvoiceItemType(item_name1, decimal.Parse(item_quantity1), decimal.Parse(item_unitPrice1)));
            cr.invoice.itemList.item.Add(
                new InvoiceItemType(item_name2, decimal.Parse(item_quantity2), decimal.Parse(item_unitPrice2)));
            CreateInvoiceResponse cir = null;

            try
            {
                InvoiceService service = getService(context);
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

        /// <summary>
        /// API call example for GetInvoiceDetails
        /// </summary>
        /// <param name="context"></param>
        private void GetInvoiceDetails(HttpContext context)
        {
            // Collect input params
            String invoiceId = context.Request.Params["invoiceId"];
            GetInvoiceDetailsRequest request =
                new GetInvoiceDetailsRequest(new RequestEnvelope(ERROR_LANGUAGE), invoiceId);

            // Create service object and make the API call
            InvoiceService service = getService(context);
            GetInvoiceDetailsResponse response = service.GetInvoiceDetails(request);

            // Process response
            context.Response.Write("<html><body><textarea rows=30 cols=80>");
            ObjectDumper.Write(response, 5, context.Response.Output);
            context.Response.Write("</textarea></body></html>");
        }


        /// <summary>
        /// API call example for MarkInvoiceAsPaid
        /// </summary>
        /// <param name="context"></param>
        private void MarkInvoiceAsPaid(HttpContext context)
        {
            // Collect input params
            String invoiceId = context.Request.Params["invoiceId"];
            String note = context.Request.Params["note"];
            String paymentDate = context.Request.Params["paymentDate"];
            String paymentMethod = context.Request.Params["paymentMethod"];
            
            OtherPaymentDetailsType paymentDetails = new OtherPaymentDetailsType();
            if (note != "")
            {
                paymentDetails.note = note;
            }
            if (paymentDate != "")
            {
                paymentDetails.date = paymentDate;
            }
            if(paymentMethod != "") 
            {
                paymentDetails.method = 
                    (PaymentMethodsType) Enum.Parse(typeof(PaymentMethodsType), paymentMethod);
            }
            MarkInvoiceAsPaidRequest request =
                new MarkInvoiceAsPaidRequest(new RequestEnvelope(ERROR_LANGUAGE), invoiceId, paymentDetails);

            // Create service object and make the API call
            InvoiceService service = getService(context);
            MarkInvoiceAsPaidResponse response = service.MarkInvoiceAsPaid(request);
            
            // Process response
            context.Response.Write("<html><body><textarea rows=30 cols=80>");
            ObjectDumper.Write(response, 5, context.Response.Output);
            context.Response.Write("</textarea></body></html>");

        }


        /// <summary>
        /// API call example for CancelInvoice
        /// </summary>
        /// <param name="context"></param>
        private void CancelInvoice(HttpContext context)
        {
            // Collect input params
            String invoiceId = context.Request.Params["invoiceId"];
            CancelInvoiceRequest request = new CancelInvoiceRequest();
            request.invoiceID = invoiceId;

            // Create service object and make the API call
            InvoiceService service = getService(context);
            CancelInvoiceResponse response = service.CancelInvoice(request);

            // Process response
            context.Response.Write("<html><body><textarea rows=30 cols=80>");
            ObjectDumper.Write(response, 5, context.Response.Output);
            context.Response.Write("</textarea></body></html>");
        }


        /// <summary>
        /// API call example for UpdateInvoice
        /// </summary>
        /// <param name="context"></param>
        private void UpdateInvoice(HttpContext context)
        {
            // Collect input params
            String invoiceId = context.Request.Params["invoiceId"];
            String merchantEmail = context.Request.Params["merchantEmail"];
            String payerEmail = context.Request.Params["payerEmail"];
            PaymentTermsType paymentTerms = (PaymentTermsType) Enum.Parse( 
                    typeof(PaymentTermsType), context.Request.Params["paymentTerms"]);
            String item_name1 = context.Request.Params["item_name1"];
            String item_quantity1 = context.Request.Params["item_quantity1"];
            String item_unitPrice1 = context.Request.Params["item_unitPrice1"];
            String item_name2 = context.Request.Params["item_name2"];
            String item_quantity2 = context.Request.Params["item_quantity2"];
            String item_unitPrice2 = context.Request.Params["item_unitPrice2"];
            String currencyCode = context.Request.Params["currencyCode"];

            InvoiceItemListType itemList = new InvoiceItemListType();
            itemList.item = new List<InvoiceItemType>();
            itemList.item.Add(new InvoiceItemType(
                        item_name1,
                        decimal.Parse(item_quantity1),
                        decimal.Parse(item_unitPrice1)));
            itemList.item.Add(new InvoiceItemType(
                        item_name2,
                        decimal.Parse(item_quantity2),
                        decimal.Parse(item_unitPrice2)));            
            InvoiceType invoice = new InvoiceType(merchantEmail, payerEmail, itemList, 
                currencyCode, paymentTerms);
            UpdateInvoiceRequest request = new UpdateInvoiceRequest(
                new RequestEnvelope(ERROR_LANGUAGE), invoiceId, invoice);

            // Create service object and make the API call
            InvoiceService service = getService(context);
            UpdateInvoiceResponse response = service.UpdateInvoice(request);

            // Process response
            context.Response.Write("<html><body><textarea rows=30 cols=80>");
            ObjectDumper.Write(response, 5, context.Response.Output);
            context.Response.Write("</textarea></body></html>");
        }


        /// <summary>
        /// API call example for SearchInvoices
        /// </summary>
        /// <param name="context"></param>
        private void SearchInvoices(HttpContext context)
        {
            // Collect input params            
            String merchantEmail = context.Request.Params["merchantEmail"];
            int page = Int32.Parse(context.Request.Params["page"]);
            int pageSize = Int32.Parse(context.Request.Params["pageSize"]);
            SearchParametersType searchParams = new SearchParametersType();
            SearchInvoicesRequest request = new SearchInvoicesRequest(
                new RequestEnvelope(ERROR_LANGUAGE), merchantEmail, searchParams, page, pageSize);
            if (context.Request.Params["email"] != "")
            {
                searchParams.email = context.Request.Params["email"];
            }
            if (context.Request.Params["recipientName"] != "")
            {
                searchParams.recipientName = context.Request.Params["recipientName"];
            }
            if (context.Request.Params["businessName"] != "")
            {
                searchParams.businessName = context.Request.Params["businessName"];
            }
            if (context.Request.Params["invoiceNumber"] != "")
            {
                searchParams.invoiceNumber = context.Request.Params["invoiceNumber"];
            }
            if (context.Request.Params["status0"] != "")
            {
                // You can add upto 10 status to do a 'OR' search on multiple status types
                searchParams.status.Add(
                    (StatusType)Enum.Parse(typeof(StatusType), context.Request.Params["status0"]));
            }
            if (context.Request.Params["status1"] != "")
            {
                // You can add upto 10 status to do a 'OR' search on multiple status types
                searchParams.status.Add(
                    (StatusType)Enum.Parse(typeof(StatusType), context.Request.Params["status1"]));
            }
            if (context.Request.Params["status2"] != "")
            {
                // You can add upto 10 status to do a 'OR' search on multiple status types
                searchParams.status.Add(
                    (StatusType)Enum.Parse(typeof(StatusType), context.Request.Params["status2"]));
            }
            if (context.Request.Params["lowerAmount"] != "")
            {
                searchParams.lowerAmount = decimal.Parse(context.Request.Params["lowerAmount"]);
            }
            if (context.Request.Params["upperAmount"] != "")
            {
                searchParams.upperAmount = decimal.Parse(context.Request.Params["upperAmount"]);
            }
            if (context.Request.Params["memo"] != "")
            {
                searchParams.memo = context.Request.Params["memo"];
            }
            if (context.Request.Params["currencyCode"] != "")
            {
                searchParams.currencyCode = context.Request.Params["currencyCode"];
            }
            if (context.Request.Params["origin"] != "")
            {
                searchParams.origin = (OriginType)
                     Enum.Parse( typeof(OriginType),  context.Request.Params["origin"]);
            }
            if (context.Request.Params["invoiceDateStart"] != "" || context.Request.Params["invoiceDateEnd"] != "")
            {
                DateRangeType dateRange = new DateRangeType();
                dateRange.startDate = context.Request.Params["invoiceDateStart"];
                dateRange.endDate = context.Request.Params["invoiceDateEnd"];
                searchParams.invoiceDate = dateRange;
            }
            if (context.Request.Params["dueDateStart"] != "" || context.Request.Params["dueDateEnd"] != "")
            {
                DateRangeType dateRange = new DateRangeType();
                dateRange.startDate = context.Request.Params["dueDateStart"];
                dateRange.endDate = context.Request.Params["dueDateEnd"];
                searchParams.dueDate = dateRange;
            }
            if (context.Request.Params["paymentDateStart"] != "" || context.Request.Params["paymentDateEnd"] != "")
            {
                DateRangeType dateRange = new DateRangeType();
                dateRange.startDate = context.Request.Params["paymentDateStart"];
                dateRange.endDate = context.Request.Params["paymentDateEnd"];
                searchParams.paymentDate = dateRange;
            }
            if (context.Request.Params["creationDateStart"] != "" || context.Request.Params["creationDateEnd"] != "")
            {
                DateRangeType dateRange = new DateRangeType();
                dateRange.startDate = context.Request.Params["creationDateStart"];
                dateRange.endDate = context.Request.Params["creationDateEnd"];
                searchParams.creationDate = dateRange;
            }            

            // Create service object and make the API call
            InvoiceService service = getService(context);
            SearchInvoicesResponse response = service.SearchInvoices(request);

            // Process response
            context.Response.Write("<html><body><textarea rows=30 cols=80>");
            ObjectDumper.Write(response, 5, context.Response.Output);
            context.Response.Write("</textarea></body></html>");
        }

        /// <summary>
        /// Invokes the GetAccessToken API that requests third party permissions
        /// from another PayPal user for the API caller
        /// </summary>
        /// <param name="context"></param>
        private void RequestPermissions(HttpContext context)
        {
            // Restrict permissioning scope to "INVOICING"
            // This will allow the API caller to invoke any invoicing related API
            // on behalf of the permission granter
            String requestperm = "INVOICING";
            PayPal.Permissions.Model.RequestPermissionsRequest rp = new PayPal.Permissions.Model.RequestPermissionsRequest();           
            rp.scope = new List<string>();            
            rp.scope.Add(requestperm);

            string url = context.Request.Url.Scheme + "://" + context.Request.Url.Host + ":" + context.Request.Url.Port;
            string returnURL = url + "/GetAccessToken.aspx?source=" 
                + context.Request.UrlReferrer.LocalPath;
            rp.callback = returnURL;            
            PayPal.Permissions.Model.RequestPermissionsResponse rpr = null;

            try
            {
                PayPal.Permissions.PermissionsService service = new PayPal.Permissions.PermissionsService();                
                rpr = service.RequestPermissions(rp);


                string ret = "<div class='overview'>Step 1) Invoke the RequestPermissions API and redirect third party to "
                + "PayPal so that the user may login and grant permissions to the API caller<br/></div>";
                ret = ret + "<a href=";
                ret = ret + ConfigurationManager.AppSettings["PAYPAL_REDIRECT_URL"] + "_grant-permission&request_token=" + rpr.token;
                ret = ret + "> Redirect URL (Click to redirect) </a><br/><br/>";
                context.Response.Write(ret);

                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(rpr, 5, context.Response.Output);               
                context.Response.Write("</textarea></body></html>");                
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }

        }

        private void GetAccessToken(HttpContext context)
        {
            String token = context.Request.Params["txtrequest_token"];
            String verifier = context.Request.Params["txtverification_code"];
            String source = context.Request.Params["source"];

            PayPal.Permissions.Model.GetAccessTokenRequest gat = 
                new PayPal.Permissions.Model.GetAccessTokenRequest();
            gat.token = token;
            gat.verifier = verifier;
            gat.requestEnvelope = new PayPal.Permissions.Model.RequestEnvelope(ERROR_LANGUAGE);
            PayPal.Permissions.Model.GetAccessTokenResponse gats = null;

            try
            {
                PayPal.Permissions.PermissionsService service = new PayPal.Permissions.PermissionsService();
                gats = service.GetAccessToken(gat);
                context.Response.Redirect( source + "?token=" + gats.token + "&tokensecret="+gats.tokenSecret);       
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }

        }



        
    }
}