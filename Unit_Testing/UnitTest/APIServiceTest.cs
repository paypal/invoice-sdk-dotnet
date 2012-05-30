using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using PayPal.Exception;

namespace PayPal.UnitTest
{
    [TestFixture]
    class APIServiceTest
    {
        [Test]
        public void makeRequestWithDefaultAccount()
        {
            APIService service = new APIService("Invoice", "1.0.0");
            string request = "requestEnvelope.detailLevel=ReturnAll&requestEnvelope.errorLanguage=en_US&invoiceID=INV2-PCWG-P78G-7EYV-94QY";
            string response = service.makeRequest("SendInvoice", request, null, null, null);
            StringAssert.Contains("responseEnvelope.ack", response);
        }

        [Test]
        public void makeRequestWithSpecificAccount()
        {
            APIService service = new APIService("Invoice", "1.0.0");
            string request = "requestEnvelope.detailLevel=ReturnAll&requestEnvelope.errorLanguage=en_US&invoiceID=INV2-PCWG-P78G-7EYV-94QY";
            string response = service.makeRequest("SendInvoice", request, "jb-us-seller_api1.paypal.com", null, null);
            StringAssert.Contains("responseEnvelope.ack", response);
        }

        [Test]
        public void makeRequestWithClientAuthentication()
        {
            //TODO
        }

        


    }
}
