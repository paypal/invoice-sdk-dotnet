using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace PayPal.UnitTest
{
    [TestFixture]
    class BasePayPalServiceTest
    {
        [Test]
        public void callService()
        {
            BasePayPalService service = new BasePayPalService("Invoice", "1.0.0");
            string response = service.call("SendInvoice", "requestEnvelope.detailLevel=ReturnAll&requestEnvelope.errorLanguage=en_US&invoiceID=INV2-PCWG-P78G-7EYV-94QY", null);
            Assert.IsNotNull(response);
            StringAssert.Contains("responseEnvelope.ack", response);
        }
    }
}
