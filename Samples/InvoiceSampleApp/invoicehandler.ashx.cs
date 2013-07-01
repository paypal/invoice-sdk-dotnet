using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using PayPal;
using PayPal.Authentication;
using PayPal.Exception;
using PayPal.Util;
using InvoiceAlias = PayPal.Invoice;
using InvoiceModelAlias = PayPal.Invoice.Model;
using PermissionsAlias = PayPal.Permissions;
using PermissionsModelAlias = PayPal.Permissions.Model;

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

            string strCall = context.Request.Params["InvoiceBtn"];

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
            else if (strCall.Equals("MarkInvoiceAsUnpaid"))
            {
                MarkInvoiceAsUnpaid(context);
            }
            else if (strCall.Equals("MarkInvoiceAsRefunded"))
            {
                MarkInvoiceAsRefunded(context);
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

        private InvoiceAlias.InvoiceService GetService(HttpContext context)
        {
            // Configuration map containing signature credentials and other required configuration.
            // For a full list of configuration parameters refer at 
            // [https://github.com/paypal/invoice-sdk-dotnet/wiki/SDK-Configuration-Parameters]
            Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

            // Creating service wrapper object to make an API call by loading configuration map.
            InvoiceAlias.InvoiceService service = new InvoiceAlias.InvoiceService(configurationMap);

            if (context.Request.Params["authentication"] != null)
            {
                service.setAccessToken(context.Request.Params["accessToken"]);
                service.setAccessTokenSecret(context.Request.Params["tokenSecret"]);
            }
            if (context.Request.Params["permission$authentication"] != null)
            {
                service.setAccessToken(context.Request.Params["permission$accessToken"]);
                service.setAccessTokenSecret(context.Request.Params["permission$tokenSecret"]);
            }
            return service;
        }

        private void CreateAndSendInvoice(HttpContext context)
        {
            // (Required) Merchant email address. 
            string merchantEmail = context.Request.Params["merchantEmail"];

            // (Required) Currency used for all invoice item amounts and totals. 
            string currencyCode = context.Request.Params["currencyCode"];

            // (Required) Payer email address. 
            string payerEmail = context.Request.Params["payerEmail"];

            // (Required) Terms by which the invoice payment is due. It is one of the following values:
            //  DueOnReceipt – Payment is due when the payer receives the invoice.
            //  DueOnDateSpecified – Payment is due on the date specified in the invoice.
            //  Net10 – Payment is due 10 days from the invoice date.
            //  Net15 – Payment is due 15 days from the invoice date.
            //  Net30 – Payment is due 30 days from the invoice date.
            //  Net45 – Payment is due 45 days from the invoice date.
            string paymentTerms = context.Request.Params["paymentTerms"];

            //(Required) SKU or name of the item. Character length and limitations: 30 characters maximum 
            string item_name1 = context.Request.Params["item_name1"];

            // (Required) Item count. Valid values are 0 to 10.000. 
            string item_quantity1 = context.Request.Params["item_quantity1"];

            // (Required) Price of the item, in the currency specified by the invoice. 
            string item_unitPrice1 = context.Request.Params["item_unitPrice1"];

            //(Required) SKU or name of the item. Character length and limitations: 30 characters maximum 
            string item_name2 = context.Request.Params["item_name2"];

            // (Required) Item count. Valid values are 0 to 10.000. 
            string item_quantity2 = context.Request.Params["item_quantity2"];

            // (Required) Price of the item, in the currency specified by the invoice. 
            string item_unitPrice2 = context.Request.Params["item_unitPrice2"];

            InvoiceModelAlias.CreateAndSendInvoiceRequest cr = new InvoiceModelAlias.CreateAndSendInvoiceRequest();
            cr.requestEnvelope = new InvoiceModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            cr.requestEnvelope.errorLanguage = ERROR_LANGUAGE;

            cr.invoice = new InvoiceModelAlias.InvoiceType();
            cr.invoice.currencyCode = currencyCode;
            cr.invoice.merchantEmail = merchantEmail;
            cr.invoice.payerEmail = payerEmail;
            cr.invoice.paymentTerms = InvoiceModelAlias.PaymentTermsType.DUEONRECEIPT;


            cr.invoice.itemList = new InvoiceModelAlias.InvoiceItemListType();
            cr.invoice.itemList.item = new List<InvoiceModelAlias.InvoiceItemType>();
            cr.invoice.itemList.item.Add(new InvoiceModelAlias.InvoiceItemType(
                        item_name1,
                        decimal.Parse(item_quantity1),
                        decimal.Parse(item_unitPrice1)));
            cr.invoice.itemList.item.Add(new InvoiceModelAlias.InvoiceItemType(
                        item_name2,
                        decimal.Parse(item_quantity2),
                        decimal.Parse(item_unitPrice2)));

            InvoiceAlias.InvoiceService service;
            InvoiceModelAlias.CreateAndSendInvoiceResponse cir = null;
            try
            {
                service = GetService(context);
                cir = service.CreateAndSendInvoice(cr);                
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", cir.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues. 
            keyResponseParams.Add("correlationId", cir.responseEnvelope.correlationId);

            // ID of the created invoice. 
            keyResponseParams.Add("invoiceId", cir.invoiceID);

            // Number of the created invoice. 
            keyResponseParams.Add("invoiceNumber", cir.invoiceNumber);

            // URL location where merchants view the invoice details. 
            keyResponseParams.Add("invoiceUrl", cir.invoiceURL);

            // The total amount of the invoice. 
            keyResponseParams.Add("totalAmount", cir.totalAmount.ToString());
            displayResponse(context, "CreateAndSendInvoice", keyResponseParams, service.getLastRequest(),
                service.getLastResponse(), cir.error, null);
        }

        private void SendInvoice(HttpContext context)
        {
            // (Required) ID of the invoice to send. 
            string invoiceId = context.Request.Params["invoiceId"];

            InvoiceModelAlias.SendInvoiceRequest sr = new InvoiceModelAlias.SendInvoiceRequest();
            sr.invoiceID = invoiceId;
            sr.requestEnvelope = new InvoiceModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            sr.requestEnvelope.errorLanguage = ERROR_LANGUAGE;

            InvoiceAlias.InvoiceService service;
            InvoiceModelAlias.SendInvoiceResponse sir = null;

            try
            {
                service = GetService(context);
                sir = service.SendInvoice(sr);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", sir.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues. 
            keyResponseParams.Add("correlationId", sir.responseEnvelope.correlationId);

            // ID of the created invoice. 
            keyResponseParams.Add("invoiceId", sir.invoiceID);

            // URL location where merchants view the invoice details. 
            keyResponseParams.Add("invoiceUrl", sir.invoiceURL);
            displayResponse(context, "SendInvoice", keyResponseParams, service.getLastRequest(),
                service.getLastResponse(), sir.error, null);
        }

        private void CreateInvoice(HttpContext context)
        {
            // (Required) Merchant email address. 
            string merchantEmail = context.Request.Params["merchantEmail"];

            // (Required) Currency used for all invoice item amounts and totals. 
            string currencyCode = context.Request.Params["currencyCode"];

            //  Required) Payer email address. 
            string payerEmail = context.Request.Params["payerEmail"];

            // (Required) Terms by which the invoice payment is due. It is one of the following values:
            //DueOnReceipt – Payment is due when the payer receives the invoice.
            //DueOnDateSpecified – Payment is due on the date specified in the invoice.
            //Net10 – Payment is due 10 days from the invoice date.
            //Net15 – Payment is due 15 days from the invoice date.
            //Net30 – Payment is due 30 days from the invoice date.
            //Net45 – Payment is due 45 days from the invoice date.
            string paymentTerms = context.Request.Params["paymentTerms"];

            // (Required) SKU or name of the item. Character length and limitations: 30 characters maximum 
            string item_name1 = context.Request.Params["item_name1"];

            // (Required) Item count. Valid values are 0 to 10.000. 
            string item_quantity1 = context.Request.Params["item_quantity1"];

            // (Required) Price of the item, in the currency specified by the invoice. 
            string item_unitPrice1 = context.Request.Params["item_unitPrice1"];

            // (Required) SKU or name of the item. Character length and limitations: 30 characters maximum 
            string item_name2 = context.Request.Params["item_name2"];

            // (Required) Item count. Valid values are 0 to 10.000. 
            string item_quantity2 = context.Request.Params["item_quantity2"];

            // (Required) Price of the item, in the currency specified by the invoice. 
            string item_unitPrice2 = context.Request.Params["item_unitPrice2"];

            InvoiceModelAlias.CreateInvoiceRequest cr = new InvoiceModelAlias.CreateInvoiceRequest();
            cr.requestEnvelope = new InvoiceModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            cr.requestEnvelope.errorLanguage = ERROR_LANGUAGE;


            cr.invoice = new InvoiceModelAlias.InvoiceType();
            cr.invoice.currencyCode = currencyCode;
            cr.invoice.merchantEmail = merchantEmail;
            cr.invoice.payerEmail = payerEmail;
            cr.invoice.paymentTerms = (InvoiceModelAlias.PaymentTermsType)
                Enum.Parse(typeof(InvoiceModelAlias.PaymentTermsType), paymentTerms);

            cr.invoice.itemList = new InvoiceModelAlias.InvoiceItemListType();
            cr.invoice.itemList.item = new List<InvoiceModelAlias.InvoiceItemType>();
            cr.invoice.itemList.item.Add(
                new InvoiceModelAlias.InvoiceItemType(item_name1, decimal.Parse(item_quantity1), decimal.Parse(item_unitPrice1)));
            cr.invoice.itemList.item.Add(
                new InvoiceModelAlias.InvoiceItemType(item_name2, decimal.Parse(item_quantity2), decimal.Parse(item_unitPrice2)));

            InvoiceAlias.InvoiceService service = null;
            InvoiceModelAlias.CreateInvoiceResponse cir = null;
            try
            {
                service = GetService(context);
                cir = service.CreateInvoice(cr);                
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", cir.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues. 
            keyResponseParams.Add("correlationId", cir.responseEnvelope.correlationId);

            // ID of the created invoice. 
            keyResponseParams.Add("invoiceId", cir.invoiceID);

            //Invoice number of the created invoice. 
            keyResponseParams.Add("invoiceNumber", cir.invoiceNumber);

            //URL location where merchants view the invoice details. 
            keyResponseParams.Add("invoiceUrl", cir.invoiceURL);

            // The total amount of the invoice. 
            keyResponseParams.Add("totalAmount", cir.totalAmount.ToString());
            displayResponse(context, "CreateInvoice", keyResponseParams, service.getLastRequest(),
                service.getLastResponse(), cir.error, null);
        }

        /// <summary>
        /// API call example for GetInvoiceDetails
        /// </summary>
        /// <param name="context"></param>
        private void GetInvoiceDetails(HttpContext context)
        {
            // Collect input params
            // (Required) ID of the invoice to retrieve. 
            string invoiceId = context.Request.Params["invoiceId"];
            InvoiceModelAlias.RequestEnvelope env = new InvoiceModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            env.errorLanguage = ERROR_LANGUAGE;
            InvoiceModelAlias.GetInvoiceDetailsRequest request =
                new InvoiceModelAlias.GetInvoiceDetailsRequest(env, invoiceId);

            // Create service object and make the API call
            InvoiceAlias.InvoiceService service;
            InvoiceModelAlias.GetInvoiceDetailsResponse response;
            try
            {
                service = GetService(context);
                response = service.GetInvoiceDetails(request);
            }
            catch (Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", response.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues. 
            keyResponseParams.Add("correlationId", response.responseEnvelope.correlationId);
            if (response.invoice != null)
            {
                // Date on which the invoice is enabled. 
                keyResponseParams.Add("invoice date", response.invoice.invoiceDate);

                //  Date on which the invoice payment is due. 
                keyResponseParams.Add("due date", response.invoice.dueDate);

                // Merchant email address. 
                keyResponseParams.Add("merchant email", response.invoice.merchantEmail);

                // Payer email address. 
                keyResponseParams.Add("payer email", response.invoice.payerEmail);
            }
            if (response.invoiceDetails != null)
            {
                keyResponseParams.Add("totalAmount", response.invoiceDetails.totalAmount.ToString());
            }
            displayResponse(context, "GetInvoiceDetails", keyResponseParams, service.getLastRequest(),
                service.getLastResponse(), response.error, null);
        }


        /// <summary>
        /// API call example for MarkInvoiceAsPaid
        /// </summary>
        /// <param name="context"></param>
        private void MarkInvoiceAsPaid(HttpContext context)
        {
            // Collect input params
            // (Required) ID of the invoice to mark as paid. 
            string invoiceId = context.Request.Params["invoiceId"];

            // (Optional) Optional note associated with the payment. 
            string note = context.Request.Params["note"];

            //  (Required) Date when the invoice was paid. 
            string paymentDate = context.Request.Params["paymentDate"];
            
            //(Optional) Method that can be used to mark an invoice as paid when the payer pays offline. 
            // It is one of the following values:
            //BankTransfer – Payment is made by a bank transfer.
            //Cash – Payment is made in cash.
            //Check – Payment is made by check.
            //CreditCard – Payment is made by a credit card.
            //DebitCard – Payment is made by a debit card.
            //Other – Payment is made by a method not specified in this list.
            //PayPal – Payment is made by PayPal.
            //WireTransfer – Payment is made by a wire transfer.
            string paymentMethod = context.Request.Params["paymentMethod"];

            InvoiceModelAlias.OtherPaymentDetailsType paymentDetails = new InvoiceModelAlias.OtherPaymentDetailsType();
            if (note != string.Empty)
            {
                paymentDetails.note = note;
            }
            if (paymentDate != string.Empty)
            {
                paymentDetails.date = paymentDate;
            }
            if(paymentMethod != string.Empty) 
            {
                paymentDetails.method =
                    (InvoiceModelAlias.PaymentMethodsType)Enum.Parse(typeof(InvoiceModelAlias.PaymentMethodsType), paymentMethod);
            }
            InvoiceModelAlias.RequestEnvelope env = new InvoiceModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            env.errorLanguage = ERROR_LANGUAGE;
            InvoiceModelAlias.MarkInvoiceAsPaidRequest request =
                new InvoiceModelAlias.MarkInvoiceAsPaidRequest(env, invoiceId, paymentDetails);

            // Create service object and make the API call

            InvoiceModelAlias.MarkInvoiceAsPaidResponse response;
            InvoiceAlias.InvoiceService service;
            try
            {
                service = GetService(context);
                response = service.MarkInvoiceAsPaid(request);
            }
            catch (Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", response.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues. 
            keyResponseParams.Add("correlationId", response.responseEnvelope.correlationId);

            //  ID of the invoice marked as paid. 
            keyResponseParams.Add("invoiceId", response.invoiceID);

            // Number of the invoice marked as paid. 
            keyResponseParams.Add("invoiceNumber", response.invoiceNumber);

            // URL location where merchants view the invoice details. 
            keyResponseParams.Add("invoiceUrl", response.invoiceURL);
            displayResponse(context, "MarkInvoiceAsPaid", keyResponseParams, service.getLastRequest(),
                service.getLastResponse(), response.error, null); 

        }


        /// <summary>
        /// API call example for CancelInvoice
        /// </summary>
        /// <param name="context"></param>
        private void CancelInvoice(HttpContext context)
        {
            // Collect input params
            // (Optional) ID of the invoice. 
            string invoiceId = context.Request.Params["invoiceId"];
            InvoiceModelAlias.CancelInvoiceRequest request = new InvoiceModelAlias.CancelInvoiceRequest();
            request.invoiceID = invoiceId;

            // Create service object and make the API call
            InvoiceAlias.InvoiceService service;
            InvoiceModelAlias.CancelInvoiceResponse response;

            try
            {
                service = GetService(context);
                response = service.CancelInvoice(request);
            }
            catch (Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", response.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues. 
            keyResponseParams.Add("correlationId", response.responseEnvelope.correlationId);

            // ID of the invoice. 
            keyResponseParams.Add("invoiceId", response.invoiceID);

            // Number of the canceled invoice. 
            keyResponseParams.Add("invoiceNumber", response.invoiceNumber);

            // URL location where merchants view the invoice details. 
            keyResponseParams.Add("invoiceUrl", response.invoiceURL);
            displayResponse(context, "CancelInvoice", keyResponseParams, service.getLastRequest(),
                service.getLastResponse(), response.error, null); 

        }


        /// <summary>
        /// API call example for UpdateInvoice
        /// </summary>
        /// <param name="context"></param>
        private void UpdateInvoice(HttpContext context)
        {
            // Collect input params

            // (Required) ID of the invoice to update. 
            string invoiceId = context.Request.Params["invoiceId"];

            // (Required) Merchant email address. 
            string merchantEmail = context.Request.Params["merchantEmail"];

            // (Required) Payer email address. 
            string payerEmail = context.Request.Params["payerEmail"];

            // (Required) Terms by which the invoice payment is due. It is one of the following values:
            // DueOnReceipt – Payment is due when the payer receives the invoice.
            // DueOnDateSpecified – Payment is due on the date specified in the invoice.
            // Net10 – Payment is due 10 days from the invoice date.
            // Net15 – Payment is due 15 days from the invoice date.
            // Net30 – Payment is due 30 days from the invoice date.
            // Net45 – Payment is due 45 days from the invoice date.
            InvoiceModelAlias.PaymentTermsType paymentTerms = (InvoiceModelAlias.PaymentTermsType)Enum.Parse(
                    typeof(InvoiceModelAlias.PaymentTermsType), context.Request.Params["paymentTerms"]);

            // (Required) SKU or name of the item. Character length and limitations: 30 characters maximum 
            string item_name1 = context.Request.Params["item_name1"];

            // (Required) Item count. Valid values are 0 to 10.000. 
            string item_quantity1 = context.Request.Params["item_quantity1"];

            // (Required) Price of the item, in the currency specified by the invoice. 
            string item_unitPrice1 = context.Request.Params["item_unitPrice1"];

            // (Required) SKU or name of the item. Character length and limitations: 30 characters maximum 
            string item_name2 = context.Request.Params["item_name2"];

            // (Required) Item count. Valid values are 0 to 10.000. 
            string item_quantity2 = context.Request.Params["item_quantity2"];

            // (Required) Price of the item, in the currency specified by the invoice.
            string item_unitPrice2 = context.Request.Params["item_unitPrice2"];

            // (Required) Currency used for all invoice item amounts and totals.
            string currencyCode = context.Request.Params["currencyCode"];

            InvoiceModelAlias.InvoiceItemListType itemList = new InvoiceModelAlias.InvoiceItemListType();
            itemList.item = new List<InvoiceModelAlias.InvoiceItemType>();
            itemList.item.Add(new InvoiceModelAlias.InvoiceItemType(
                        item_name1,
                        decimal.Parse(item_quantity1),
                        decimal.Parse(item_unitPrice1)));
            itemList.item.Add(new InvoiceModelAlias.InvoiceItemType(
                        item_name2,
                        decimal.Parse(item_quantity2),
                        decimal.Parse(item_unitPrice2)));
            InvoiceModelAlias.InvoiceType invoice = new InvoiceModelAlias.InvoiceType(merchantEmail, payerEmail, itemList, 
                currencyCode, paymentTerms);
            InvoiceModelAlias.RequestEnvelope env = new InvoiceModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            env.errorLanguage = ERROR_LANGUAGE;
            InvoiceModelAlias.UpdateInvoiceRequest request = new InvoiceModelAlias.UpdateInvoiceRequest(
               env, invoiceId, invoice);

            // Create service object and make the API call
            InvoiceAlias.InvoiceService service;
            InvoiceModelAlias.UpdateInvoiceResponse response;

            try
            {
                service = GetService(context);
                response = service.UpdateInvoice(request);
            }
            catch (Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", response.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues. 
            keyResponseParams.Add("correlationId", response.responseEnvelope.correlationId);

            // ID of the updated invoice. 
            keyResponseParams.Add("invoiceId", response.invoiceID);

            // Invoice number of the updated invoice. 
            keyResponseParams.Add("invoiceNumber", response.invoiceNumber);

            // URL location where merchants view the updated invoice details.
            keyResponseParams.Add("invoiceUrl", response.invoiceURL);

            // The total amount of the invoice. 
            keyResponseParams.Add("totalAmount", response.totalAmount.ToString());
            displayResponse(context, "UpdateInvoice", keyResponseParams, service.getLastRequest(),
                service.getLastResponse(), response.error, null); 
        }


        /// <summary>
        /// API call example for SearchInvoices
        /// </summary>
        /// <param name="context"></param>
        private void SearchInvoices(HttpContext context)
        {
            // Collect input params            

            // (Required) Email address of invoice creator. 
            string merchantEmail = context.Request.Params["merchantEmail"];

            // (Required) Page number of result set, starting with 1. 
            int page = Int32.Parse(context.Request.Params["page"]);

            // (Required) Number of results per page, between 1 and 100. 
            int pageSize = Int32.Parse(context.Request.Params["pageSize"]);

            InvoiceModelAlias.SearchParametersType searchParams = new InvoiceModelAlias.SearchParametersType();
            InvoiceModelAlias.RequestEnvelope env = new InvoiceModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            env.errorLanguage = ERROR_LANGUAGE;
            InvoiceModelAlias.SearchInvoicesRequest request = new InvoiceModelAlias.SearchInvoicesRequest(
                env, merchantEmail, searchParams, page, pageSize);

            // (Optional) Email search string. 
            if (context.Request.Params["email"] != string.Empty)
            {
                searchParams.email = context.Request.Params["email"];
            }

            // (Optional) Recipient search string. 
            if (context.Request.Params["recipientName"] != string.Empty)
            {
                searchParams.recipientName = context.Request.Params["recipientName"];
            }

            // (Optional) Company search string. 
            if (context.Request.Params["businessName"] != string.Empty)
            {
                searchParams.businessName = context.Request.Params["businessName"];
            }

            // (Optional) Invoice number search string. 
            if (context.Request.Params["invoiceNumber"] != string.Empty)
            {
                searchParams.invoiceNumber = context.Request.Params["invoiceNumber"];
            }

            // (Optional) Invoice status search. 
            if (context.Request.Params["status0"] != string.Empty)
            {
                // You can add upto 10 status to do a 'OR' search on multiple status types
                searchParams.status.Add(
                    (InvoiceModelAlias.StatusType)Enum.Parse(typeof(InvoiceModelAlias.StatusType), context.Request.Params["status0"]));
            }

            // (Optional) Invoice status search. 
            if (context.Request.Params["status1"] != string.Empty)
            {
                // You can add upto 10 status to do a 'OR' search on multiple status types
                searchParams.status.Add(
                    (InvoiceModelAlias.StatusType)Enum.Parse(typeof(InvoiceModelAlias.StatusType), context.Request.Params["status1"]));
            }

            // (Optional) Invoice status search. 
            if (context.Request.Params["status2"] != string.Empty)
            {
                // You can add upto 10 status to do a 'OR' search on multiple status types
                searchParams.status.Add(
                    (InvoiceModelAlias.StatusType)Enum.Parse(typeof(InvoiceModelAlias.StatusType), context.Request.Params["status2"]));
            }

            // (Optional) Invoice amount search. It specifies the smallest amount to be returned. 
            // If you pass a value for this field, you must also pass a currencyCode value. 
            if (context.Request.Params["lowerAmount"] != string.Empty)
            {
                searchParams.lowerAmount = decimal.Parse(context.Request.Params["lowerAmount"]);
            }

            // (Optional) Invoice amount search. It specifies the largest amount to be returned. 
            // If you pass a value for this field, you must also pass a currencyCode value. 
            if (context.Request.Params["upperAmount"] != string.Empty)
            {
                searchParams.upperAmount = decimal.Parse(context.Request.Params["upperAmount"]);
            }

            // (Optional) Invoice memo search string. 
            if (context.Request.Params["memo"] != string.Empty)
            {
                searchParams.memo = context.Request.Params["memo"];
            }

            // (Optional) Currency used for lower and upper amounts. 
            // It is required when you specify lowerAmount or upperAmount. 
            if (context.Request.Params["currencyCode"] != string.Empty)
            {
                searchParams.currencyCode = context.Request.Params["currencyCode"];
            }

            // (Optional) Indicates whether the invoice was created by the website or by an API call. 
            // It is one of the following values:
            //  Web – The invoice was created on paypal.com.
            //  API – The invoice was created by an Invoicing Service API call.
            if (context.Request.Params["origin"] != string.Empty)
            {
                searchParams.origin = (InvoiceModelAlias.OriginType)
                     Enum.Parse(typeof(InvoiceModelAlias.OriginType), context.Request.Params["origin"]);
            }

            // 
            if (context.Request.Params["invoiceDateStart"] != string.Empty || context.Request.Params["invoiceDateEnd"] != string.Empty)
            {
                InvoiceModelAlias.DateRangeType dateRange = new InvoiceModelAlias.DateRangeType();

                // (Optional) Start of the date range.
                dateRange.startDate = context.Request.Params["invoiceDateStart"];

                // Optional) End of the date range.
                dateRange.endDate = context.Request.Params["invoiceDateEnd"];
                searchParams.invoiceDate = dateRange;
            }


            if (context.Request.Params["dueDateStart"] != string.Empty || context.Request.Params["dueDateEnd"] != string.Empty)
            {
                InvoiceModelAlias.DateRangeType dateRange = new InvoiceModelAlias.DateRangeType();

                // (Optional) Start of the date range.
                dateRange.startDate = context.Request.Params["dueDateStart"];

                // Optional) End of the date range.
                dateRange.endDate = context.Request.Params["dueDateEnd"];
                searchParams.dueDate = dateRange;
            }
            if (context.Request.Params["paymentDateStart"] != string.Empty || context.Request.Params["paymentDateEnd"] != string.Empty)
            {
                InvoiceModelAlias.DateRangeType dateRange = new InvoiceModelAlias.DateRangeType();

                // (Optional) Start of the date range.
                dateRange.startDate = context.Request.Params["paymentDateStart"];

                // Optional) End of the date range.
                dateRange.endDate = context.Request.Params["paymentDateEnd"];
                searchParams.paymentDate = dateRange;
            }
            if (context.Request.Params["creationDateStart"] != string.Empty || context.Request.Params["creationDateEnd"] != string.Empty)
            {
                InvoiceModelAlias.DateRangeType dateRange = new InvoiceModelAlias.DateRangeType();

                // (Optional) Start of the date range.
                dateRange.startDate = context.Request.Params["creationDateStart"];

                // Optional) End of the date range.
                dateRange.endDate = context.Request.Params["creationDateEnd"];
                searchParams.creationDate = dateRange;
            }            

            // Create service object and make the API call
            InvoiceAlias.InvoiceService service;
            InvoiceModelAlias.SearchInvoicesResponse response;

            try
            {
                service = GetService(context);
                response = service.SearchInvoices(request);
            }
            catch (Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", response.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues.
            keyResponseParams.Add("correlationId", response.responseEnvelope.correlationId);

            // Number of invoices that matched the request. 
            keyResponseParams.Add("invoice count", response.count.ToString());

            // True if another page of invoice summary results exists.
            keyResponseParams.Add("hasNextPage", response.hasNextPage.ToString());

            // True if a previous page of the invoice summary results exists. 
            keyResponseParams.Add("hasPreviousPage", response.hasPreviousPage.ToString());

            if (response.invoiceList != null && response.invoiceList.invoice != null)
            {
                int idx = 0;
                foreach (InvoiceModelAlias.InvoiceSummaryType invoice in response.invoiceList.invoice)
                {
                    keyResponseParams.Add(idx + " invoice Id", invoice.invoiceID);
                    keyResponseParams.Add(idx + " invoice status", invoice.status.ToString());
                    idx++;
                }
            }
            displayResponse(context, "SearchInvoices", keyResponseParams, service.getLastRequest(),
                service.getLastResponse(), response.error, null);
        }

        /// <summary>
        /// API call example for MarkInvoiceAsRefunded
        /// </summary>
        /// <param name="context"></param>
        private void MarkInvoiceAsRefunded(HttpContext context)
        {
            // Collect input params

            // (Required) ID of the invoice to mark as refunded. 
            string invoiceId = context.Request.Params["invoiceId"];

            //  Optional note associated with the payment.
            string refundNote = context.Request.Params["refundNote"];

            //(Required) Date when the invoice was paid
            string refundDate = context.Request.Params["refundDate"];

            InvoiceModelAlias.OtherPaymentRefundDetailsType refundDetails = new InvoiceModelAlias.OtherPaymentRefundDetailsType();
            if (refundNote != string.Empty)
                refundDetails.note = refundNote;
            if (refundDate != string.Empty)
                refundDetails.date = refundDate;

            InvoiceModelAlias.RequestEnvelope env = new InvoiceModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            env.errorLanguage = ERROR_LANGUAGE;
            InvoiceModelAlias.MarkInvoiceAsRefundedRequest request =
                new InvoiceModelAlias.MarkInvoiceAsRefundedRequest(env, invoiceId, refundDetails);

            // Create service object and make the API call
            InvoiceAlias.InvoiceService service;
            InvoiceModelAlias.MarkInvoiceAsRefundedResponse response;

            try
            {
                service = GetService(context);
                response = service.MarkInvoiceAsRefunded(request);
            }
            catch (Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", response.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues.
            keyResponseParams.Add("correlationId", response.responseEnvelope.correlationId);

            // (Required) ID of the invoice to mark as refunded. 
            keyResponseParams.Add("invoiceId", response.invoiceID);

            //  Number of the invoice marked as refunded. 
            keyResponseParams.Add("invoiceNumber", response.invoiceNumber);

            // The URL of the details page of the invoice that was marked as refunded. 
            keyResponseParams.Add("invoiceUrl", response.invoiceURL);
            displayResponse(context, "MarkInvoiceAsRefunded", keyResponseParams, service.getLastRequest(),  
                service.getLastResponse(), response.error, null);            
        }

        /// <summary>
        /// API call example for MarkInvoiceAsUnpaid
        /// </summary>
        /// <param name="context"></param>
        private void MarkInvoiceAsUnpaid(HttpContext context)
        {
            // Collect input params
            // (Required) ID of the invoice to mark as unpaid. 
            string invoiceId = context.Request.Params["invoiceId"];
            InvoiceModelAlias.RequestEnvelope env = new InvoiceModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            env.errorLanguage = ERROR_LANGUAGE;
            InvoiceModelAlias.MarkInvoiceAsUnpaidRequest request =
                new InvoiceModelAlias.MarkInvoiceAsUnpaidRequest(env, invoiceId);

            // Create service object and make the API call
            InvoiceAlias.InvoiceService service;
            InvoiceModelAlias.MarkInvoiceAsUnpaidResponse response;

            try {
                service = GetService(context);
                response = service.MarkInvoiceAsUnpaid(request);
            }
            catch (Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();

            //Acknowledgement code. It is one of the following values:
            //Success – The operation completed successfully.
            //Failure – The operation failed.
            //SuccessWithWarning – The operation completed successfully; however, there is a warning message.
            //FailureWithWarning – The operation failed with a warning message.
            keyResponseParams.Add("API status", response.responseEnvelope.ack.ToString());

            // Correlation identifier. It is a 13-character, 
            // alphanumeric string (for example, db87c705a910e) that is used 
            // only by PayPal Merchant Technical Support.
            // Note: You must log and store this data for every response you receive. 
            // PayPal Technical Support uses the information to assist with reported issues.
            keyResponseParams.Add("correlationId", response.responseEnvelope.correlationId);

            // ID of the invoice marked as unpaid. 
            keyResponseParams.Add("invoiceId", response.invoiceID);

            // Number of the invoice marked as unpaid. 
            keyResponseParams.Add("invoiceNumber", response.invoiceNumber);

            // URL location where merchants view the invoice details. 
            keyResponseParams.Add("invoiceUrl", response.invoiceURL);
            displayResponse(context, "MarkInvoiceAsUnpaid", keyResponseParams, service.getLastRequest(),
                service.getLastResponse(), response.error, null);
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
            string requestperm = "INVOICING";
            PermissionsModelAlias.RequestPermissionsRequest rp = new PermissionsModelAlias.RequestPermissionsRequest();           
            rp.scope = new List<string>();
             //(Required) At least 1 of the following permission categories:
             //   EXPRESS_CHECKOUT - Express Checkout
             //   DIRECT_PAYMENT - Direct payment by debit or credit card
             //   SETTLEMENT_CONSOLIDATION - Settlement consolidation
             //   SETTLEMENT_REPORTING - Settlement reporting
             //   AUTH_CAPTURE - Payment authorization and capture
             //   MOBILE_CHECKOUT - Mobile checkout
             //   BILLING_AGREEMENT - Billing agreements
             //   REFERENCE_TRANSACTION - Reference transactions
             //   AIR_TRAVEL - Express Checkout for UTAP
             //   MASS_PAY - Mass pay
             //   TRANSACTION_DETAILS - Transaction details
             //   TRANSACTION_SEARCH - Transaction search
             //   RECURRING_PAYMENTS - Recurring payments
             //   ACCOUNT_BALANCE - Account balance
             //   ENCRYPTED_WEBSITE_PAYMENTS - Encrypted website payments
             //   REFUND - Refunds
             //   NON_REFERENCED_CREDIT - Non-referenced credit
             //   BUTTON_MANAGER - Button Manager
             //   MANAGE_PENDING_TRANSACTION_STATUS includes ManagePendingTransactionStatus
             //   RECURRING_PAYMENT_REPORT - Reporting for recurring payments
             //   EXTENDED_PRO_PROCESSING_REPORT - Extended Pro processing
             //   EXCEPTION_PROCESSING_REPORT - Exception processing
             //   ACCOUNT_MANAGEMENT_PERMISSION - Account Management Permission (MAM)
             //   ACCESS_BASIC_PERSONAL_DATA - User attributes
             //   ACCESS_ADVANCED_PERSONAL_DATA - User attributes
             //   INVOICING - Invoicing
            rp.scope.Add(requestperm);

            string url = context.Request.Url.Scheme + "://" + context.Request.Url.Host + ":" + context.Request.Url.Port;
            string returnURL = url + "/GetAccessToken.aspx?source=" + context.Request.UrlReferrer.LocalPath;

            //(Required) Your callback function that specifies actions to take after the account 
            // holder grants or denies the request. 
            rp.callback = returnURL;
            PermissionsModelAlias.RequestPermissionsResponse rpr = null;

            try
            {
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer at 
                // [https://github.com/paypal/invoice-sdk-dotnet/wiki/SDK-Configuration-Parameters]
                Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

                // Creating service wrapper object to make an API call by loading configuration map.
                PermissionsAlias.PermissionsService service = new PermissionsAlias.PermissionsService(configurationMap);                
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
                return;
            }
        }

        private void GetAccessToken(HttpContext context)
        {
            // (Required) The request token from the response to RequestPermissions. 
            string token = context.Request.Params["txtrequest_token"];

            // (Required) The verification code returned in the redirect from PayPal to the return URL. 
            string verifier = context.Request.Params["txtverification_code"];
            string source = context.Request.Params["source"];

            PermissionsModelAlias.GetAccessTokenRequest gat =
                new PermissionsModelAlias.GetAccessTokenRequest();
            gat.token = token;
            gat.verifier = verifier;
            gat.requestEnvelope = new PermissionsModelAlias.RequestEnvelope();

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            gat.requestEnvelope.errorLanguage = ERROR_LANGUAGE;
            PermissionsModelAlias.GetAccessTokenResponse gats = null;

            try
            {
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer at 
                // [https://github.com/paypal/invoice-sdk-dotnet/wiki/SDK-Configuration-Parameters]
                Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

                // Creating service wrapper object to make an API call by loading configuration map.
                PermissionsAlias.PermissionsService service = new PermissionsAlias.PermissionsService(configurationMap);
                gats = service.GetAccessToken(gat);
                context.Response.Redirect( source + "?token=" + gats.token + "&tokensecret="+gats.tokenSecret);       
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

        }

        /// <summary>
        /// Utility method for displaying API response
        /// </summary>
        /// <param name="context"></param>
        /// <param name="apiName"></param>
        /// <param name="responseValues"></param>
        /// <param name="requestPayload"></param>
        /// <param name="responsePayload"></param>
        /// <param name="errorMessages"></param>
        /// <param name="redirectUrl"></param>
        private void displayResponse(HttpContext context, string apiName, Dictionary<string, string> responseValues,
            string requestPayload, string responsePayload, List<InvoiceModelAlias.ErrorData> errorMessages, string redirectUrl)
        {

            context.Response.Write("<html><head><title>");
            context.Response.Write("PayPal Invoice - " + apiName);
            context.Response.Write("</title><link rel='stylesheet' href='sdk.css' type='text/css'/></head><body>");
            context.Response.Write("<h3>" + apiName + " response</h3>");
            if (errorMessages != null && errorMessages.Count > 0)
            {
                context.Response.Write("<div class='section_header'>Error messages</div>");
                context.Response.Write("<div class='note'>Investigate the response object for further error information</div><ul>");
                foreach ( InvoiceModelAlias.ErrorData error in errorMessages)
                {
                    context.Response.Write("<li>" + error.message + "</li>");
                }
                context.Response.Write("</ul>");
            }
            if (redirectUrl != null)
            {
                string red = "<div>This API involves a web flow. You must now redirect your user to " + redirectUrl;
                red = red + "<br />Please click <a href='" + redirectUrl + "' target='_blank'>here</a> to try the flow.</div><br/>";
                context.Response.Write(red);
            }
            context.Response.Write("<div class='section_header'>Key values from response</div>");
            context.Response.Write("<div class='note'>Consult response object and reference doc for complete list of response values.</div><table>");
            
            /*
            foreach (KeyValuePair<string, string> entry in responseValues)
            {
                context.Response.Write("<tr><td class='label'>");
                context.Response.Write(entry.Key);
                context.Response.Write(": </td><td>");
                context.Response.Write(entry.Value);
                context.Response.Write("</td></tr>");
            }
            */

            //Selenium Test Case            
            foreach (KeyValuePair<string, string> entry in responseValues)
            {

                context.Response.Write("<tr><td class='label'>");
                context.Response.Write(entry.Key);
                context.Response.Write(": </td><td>");

                if (entry.Key == "Redirect To PayPal")
                {
                    context.Response.Write("<a id='");
                    context.Response.Write(entry.Key);
                    context.Response.Write("' href=");
                    context.Response.Write(entry.Value);
                    context.Response.Write(">Redirect To PayPal</a>");
                }
                else
                {
                    context.Response.Write("<div id='");
                    context.Response.Write(entry.Key);
                    context.Response.Write("'>");
                    context.Response.Write(entry.Value);
                }

                context.Response.Write("</td></tr>");
            }

            context.Response.Write("</table><h4>Request:</h4><br/><textarea rows=15 cols=80 readonly>");
            context.Response.Write(requestPayload);
            context.Response.Write("</textarea><br/><h4>Response</h4><br/><textarea rows=15 cols=80 readonly>");
            context.Response.Write(responsePayload);
            context.Response.Write("</textarea>");
            context.Response.Write("<br/><br/><a href='Default.aspx'>Home<a><br/><br/></body></html>");
        }        
    }
}