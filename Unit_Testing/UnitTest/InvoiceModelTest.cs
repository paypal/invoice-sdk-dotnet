using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using PayPal.Invoice.Model;

namespace PayPal.UnitTest
{
    [TestFixture]
    class InvoiceModelTest
    {
        private Dictionary<string, string> errorResponse;
        private Dictionary<string, string> validCreateInvoiceResponse;
        private Dictionary<string, string> validSendInvoiceResponse;
        private BaseAddress addr;
        private BusinessInfoType bizInfo;
        private InvoiceType invoice;

        [SetUp]
        public void Init()
        {
            errorResponse = new Dictionary<string, string>();

            errorResponse.Add("responseEnvelope.timestamp", "2011-05-11T22%3A05%3A33.962-07%3A00");
            errorResponse.Add("responseEnvelope.ack", "Failure");
            errorResponse.Add("responseEnvelope.correlationId", "b1985a21862fe");
            errorResponse.Add("responseEnvelope.build", "1877082");
            errorResponse.Add("error(0).errorId", "580022");
            errorResponse.Add("error(0).domain", "PLATFORM");
            errorResponse.Add("error(0).subdomain", "Application");
            errorResponse.Add("error(0).severity", "Error");
            errorResponse.Add("error(0).category", "Application");
            errorResponse.Add("error(0).message", "Invalid+request+parameter%3A+shippingTaxName+cannot+be+null");
            errorResponse.Add("error(0).parameter(0).name", "shippingTaxName");
            errorResponse.Add("error(0).parameter(1).name", "null");
            errorResponse.Add("error(1).errorId", "580022");
            errorResponse.Add("error(1).domain", "PLATFORM");
            errorResponse.Add("error(1).subdomain", "Application");
            errorResponse.Add("error(1).severity", "Error");
            errorResponse.Add("error(1).category", "Application");
            errorResponse.Add("error(1).message", "Invalid+request+parameter%3A+taxName+cannot+be+null");
            errorResponse.Add("error(1).parameter(0).name", "taxName");
            errorResponse.Add("error(1).parameter(1).name", "null");

            validCreateInvoiceResponse = new Dictionary<string, string>();
            validCreateInvoiceResponse.Add("responseEnvelope.timestamp", "2011-05-30T03:31:18.988-07:00");
            validCreateInvoiceResponse.Add("responseEnvelope.ack", "Success");
            validCreateInvoiceResponse.Add("responseEnvelope.correlationId", "9b3bb0a44d852");
            validCreateInvoiceResponse.Add("responseEnvelope.build", "1917403");
            validCreateInvoiceResponse.Add("invoiceID", "INV2-PCWG-P78G-7EYV-94QY");
            validCreateInvoiceResponse.Add("invoiceNumber", "0056");
            validCreateInvoiceResponse.Add("invoiceURL", "https://www.stage2sc5376.qa.paypal.com/us/cgi-bin/?cmd=_inv-details&id=INV2-PCWG-P78G-7EYV-94QY");
            
            validSendInvoiceResponse = new Dictionary<string, string>();
            validSendInvoiceResponse.Add("responseEnvelope.timestamp", "2011-05-30T03:31:18.988-07:00");
            validSendInvoiceResponse.Add("responseEnvelope.ack", "Success");
            validSendInvoiceResponse.Add("responseEnvelope.correlationId", "9b3bb0a44d852");
            validSendInvoiceResponse.Add("responseEnvelope.build", "1917403");
            validSendInvoiceResponse.Add("invoiceID", "INV2-PCWG-P78G-7EYV-94QY");            
            validSendInvoiceResponse.Add("invoiceURL", "https://www.stage2sc5376.qa.paypal.com/us/cgi-bin/?cmd=_inv-details&id=INV2-PCWG-P78G-7EYV-94QY");


            this.addr = new BaseAddress();            
            addr.city = "Austin";
            addr.countryCode = "US";
            addr.line1 = "1968 Ape Way";
            addr.line2 = "Apt 123";
            addr.postalCode = "78750";
            addr.state = "TX";

            bizInfo = new BusinessInfoType();
            bizInfo.firstName = "Bonzop";
            bizInfo.lastName = "Zaius";
            bizInfo.businessName = "Bonzop Inc";
            bizInfo.fax = "5126914161";
            bizInfo.phone = "5126914160";
            bizInfo.website = "www.bonzop-inc.com";
            bizInfo.customValue = "Business mumbo jumbo ©";

            invoice = new InvoiceType();
            invoice.billingInfo = this.bizInfo;
            invoice.currencyCode = "USD";
            invoice.discountAmount = 10.0M;            
            invoice.discountPercent = 5;            
            invoice.dueDate = "2011-11-04T00:00:00";
            invoice.invoiceDate = "2011-10-04T00:00:00";
            invoice.merchantEmail = "jb-us-seller1@paypal.com";
            invoice.payerEmail = "jbui-us-personal1@paypal.com";
            invoice.merchantMemo = "memo";
            invoice.note = "Note about invoice";
            invoice.number = "FD-123-5421";
            invoice.paymentTerms = PaymentTermsType.NET4;
            invoice.shippingAmount = 2.1M;            
            invoice.shippingTaxName = "Bonzop Inc";
            invoice.shippingTaxRate = 1.2M;            
            invoice.terms = "Payment terms";
        }

        [Test]
        public void requestEnvelopeSerialization()
        {
            RequestEnvelope env = new RequestEnvelope("en_US");
            Assert.AreEqual("errorLanguage=en_US&", env.toNVPString(""));
            Assert.AreEqual("requestEnvelope.errorLanguage=en_US&", env.toNVPString("requestEnvelope."));

            env.detailLevel = DetailLevelCode.RETURNALL;
            Assert.AreEqual("requestEnvelope.detailLevel=ReturnAll&requestEnvelope.errorLanguage=en_US&", 
                                                                    env.toNVPString("requestEnvelope."));
        }

        [Test]
        public void responseEnvelopeConstruction()
        {
            Dictionary<string, string> response = new Dictionary<string, string>();
            response.Add("responseEnvelope.timestamp", "2011-05-11T22%3A05%3A33.962-07%3A00");            
            response.Add("responseEnvelope.correlationId", "b1985a21862fe");
            response.Add("responseEnvelope.build", "1877082");

            ResponseEnvelope env = ResponseEnvelope.createInstance(response, "responseEnvelope.", -1);
            Assert.AreEqual("2011-05-11T22%3A05%3A33.962-07%3A00", env.timestamp);
            Assert.AreEqual(null, env.ack);
            Assert.AreEqual("b1985a21862fe", env.correlationId);
            Assert.AreEqual("1877082", env.build);

            response.Add("responseEnvelope.ack", "Failure");
            env = ResponseEnvelope.createInstance(response, "responseEnvelope.", -1);
            Assert.AreEqual("2011-05-11T22%3A05%3A33.962-07%3A00", env.timestamp);
            Assert.AreEqual(AckCode.FAILURE, env.ack);
            Assert.AreEqual("b1985a21862fe", env.correlationId);
            Assert.AreEqual("1877082", env.build);
        }

        [Test]
        public void invoiceItemTypeSerialization()
        {
            InvoiceItemType invoiceItem = new InvoiceItemType();
            invoiceItem.name = "product1";
            invoiceItem.quantity = 10;
            invoiceItem.taxName = "product 1";
            invoiceItem.unitPrice = 12.0M;

            string expectedNVString = "name=product1&quantity=10&unitPrice=12.0&taxName=product+1&";
            Assert.AreEqual(expectedNVString, invoiceItem.toNVPString(""));
            
            expectedNVString = "name=product1&description=The+all+new+shiny+product+1&quantity=10&unitPrice=12.0&taxName=product+1&taxRate=1.4&";
            //invoiceItem.date = "";
            invoiceItem.description = "The all new shiny product 1";
            invoiceItem.taxRate = 1.4M;
            Assert.AreEqual(expectedNVString, invoiceItem.toNVPString(""));
        }

        [Test]
        public void baseAddressSerialization()
        {            
            string expectedNVString = "line1=1968+Ape+Way&line2=Apt+123&city=Austin&state=TX&postalCode=78750&countryCode=US&";
            Assert.AreEqual(expectedNVString, addr.toNVPString(""));

            expectedNVString = "prefix.line1=1968+Ape+Way&prefix.line2=Apt+123&prefix.city=Austin&prefix.state=TX&prefix.postalCode=78750&prefix.countryCode=US&";
            Assert.AreEqual(expectedNVString, addr.toNVPString("prefix."));

            addr = new BaseAddress("1968 Ape Way", "Austin", "US");
            expectedNVString = "line1=1968+Ape+Way&city=Austin&countryCode=US&";
            Assert.AreEqual(expectedNVString, addr.toNVPString(""));
            
        }

        [Test]
        public void errorParameterConstruction()
        {
            ErrorParameter errParam = ErrorParameter.createInstance(this.errorResponse, "error(0).parameter", 0);
            Assert.AreEqual("shippingTaxName", errParam.name);
        }

        [Test]
        public void errorDataConstruction()
        {        
            
            ErrorData err = ErrorData.createInstance(this.errorResponse, "error", 0);
            Assert.AreEqual(580022, err.errorId);
            Assert.AreEqual(ErrorSeverity.ERROR, err.severity);
            Assert.AreEqual(ErrorCategory.APPLICATION, err.category);
            Assert.AreEqual(2, err.parameter.Count);
            Assert.AreEqual("shippingTaxName", err.parameter[0].name);
            Console.WriteLine(err.severity);
            err = ErrorData.createInstance(this.errorResponse, "xyz", 0);
            Assert.AreEqual(null, err);            
        }

        [Test]
        public void businessInfoSerialization()
        {


            string expectedNVPString = "firstName=Bonzop&lastName=Zaius&businessName=Bonzop+Inc&phone=5126914160&fax=5126914161&website=www.bonzop-inc.com&customValue=Business+mumbo+jumbo+%c2%a9&";
            Assert.AreEqual(expectedNVPString, bizInfo.toNVPString(""));           
                 
            bizInfo.address = this.addr;
            expectedNVPString = "firstName=Bonzop&lastName=Zaius&businessName=Bonzop+Inc&phone=5126914160&fax=5126914161&website=www.bonzop-inc.com&customValue=Business+mumbo+jumbo+%c2%a9&"
                    + "address.line1=1968+Ape+Way&address.line2=Apt+123&address.city=Austin&address.state=TX&address.postalCode=78750&address.countryCode=US&";
            Assert.AreEqual(expectedNVPString, bizInfo.toNVPString(""));
        }

        [Test]
        public void invoiceTypeSerialization()
        {
            

            string expectedNVPString = "merchantEmail=jb-us-seller1%40paypal.com&payerEmail=jbui-us-personal1%40paypal.com&number=FD-123-5421&"
                + "currencyCode=USD&invoiceDate=2011-10-04T00%3a00%3a00&dueDate=2011-11-04T00%3a00%3a00&paymentTerms=Net45&discountPercent=5&"
                + "discountAmount=10.0&terms=Payment+terms&note=Note+about+invoice&merchantMemo=memo&"
                + "billingInfo.firstName=Bonzop&billingInfo.lastName=Zaius&billingInfo.businessName=Bonzop+Inc&billingInfo.phone=5126914160&billingInfo.fax=5126914161&billingInfo.website=www.bonzop-inc.com&billingInfo.customValue=Business+mumbo+jumbo+%c2%a9&"
                + "shippingAmount=2.1&shippingTaxName=Bonzop+Inc&shippingTaxRate=1.2&";
            Console.WriteLine(invoice.toNVPString(""));
            Assert.AreEqual(expectedNVPString, invoice.toNVPString(""));

            invoice.shippingInfo = this.bizInfo;
            expectedNVPString = "merchantEmail=jb-us-seller1%40paypal.com&payerEmail=jbui-us-personal1%40paypal.com&number=FD-123-5421&"
                + "currencyCode=USD&invoiceDate=2011-10-04T00%3a00%3a00&dueDate=2011-11-04T00%3a00%3a00&paymentTerms=Net45&discountPercent=5&"
                + "discountAmount=10.0&terms=Payment+terms&note=Note+about+invoice&merchantMemo=memo&"
                + "billingInfo.firstName=Bonzop&billingInfo.lastName=Zaius&billingInfo.businessName=Bonzop+Inc&billingInfo.phone=5126914160&billingInfo.fax=5126914161&billingInfo.website=www.bonzop-inc.com&billingInfo.customValue=Business+mumbo+jumbo+%c2%a9&"
                + "shippingInfo.firstName=Bonzop&shippingInfo.lastName=Zaius&shippingInfo.businessName=Bonzop+Inc&shippingInfo.phone=5126914160&shippingInfo.fax=5126914161&shippingInfo.website=www.bonzop-inc.com&shippingInfo.customValue=Business+mumbo+jumbo+%c2%a9&"
                + "shippingAmount=2.1&shippingTaxName=Bonzop+Inc&shippingTaxRate=1.2&";
            Assert.AreEqual(expectedNVPString, invoice.toNVPString(""));            
        }

        [Test]
        public void createInvoiceRequestSerialization()
        {
            CreateInvoiceRequest cir = new CreateInvoiceRequest();
            cir.invoice = this.invoice;
            cir.requestEnvelope = new RequestEnvelope("en_US");

            string expectedNVPString = "requestEnvelope.errorLanguage=en_US&invoice.merchantEmail=jb-us-seller1%40paypal.com&invoice.payerEmail=jbui-us-personal1%40paypal.com&invoice.number=FD-123-5421&"
                + "invoice.currencyCode=USD&invoice.invoiceDate=2011-10-04T00%3a00%3a00&invoice.dueDate=2011-11-04T00%3a00%3a00&invoice.paymentTerms=Net45&invoice.discountPercent=5&"
                + "invoice.discountAmount=10.0&invoice.terms=Payment+terms&invoice.note=Note+about+invoice&invoice.merchantMemo=memo&"
                + "invoice.billingInfo.firstName=Bonzop&invoice.billingInfo.lastName=Zaius&invoice.billingInfo.businessName=Bonzop+Inc&invoice.billingInfo.phone=5126914160&invoice.billingInfo.fax=5126914161&invoice.billingInfo.website=www.bonzop-inc.com&invoice.billingInfo.customValue=Business+mumbo+jumbo+%c2%a9&"
                + "invoice.shippingAmount=2.1&invoice.shippingTaxName=Bonzop+Inc&invoice.shippingTaxRate=1.2&";
            Assert.AreEqual(expectedNVPString, cir.toNVPString(""));

            cir = new CreateInvoiceRequest(new RequestEnvelope("en_US"), invoice);            
            Assert.AreEqual(expectedNVPString, cir.toNVPString(""));
        }

        [Test]
        public void createAndSendInvoiceRequestSerialization()
        {
            CreateAndSendInvoiceRequest cir = new CreateAndSendInvoiceRequest();
            cir.invoice = this.invoice;
            cir.requestEnvelope = new RequestEnvelope("en_US");

            string expectedNVPString = "requestEnvelope.errorLanguage=en_US&invoice.merchantEmail=jb-us-seller1%40paypal.com&invoice.payerEmail=jbui-us-personal1%40paypal.com&invoice.number=FD-123-5421&"
                + "invoice.currencyCode=USD&invoice.invoiceDate=2011-10-04T00%3a00%3a00&invoice.dueDate=2011-11-04T00%3a00%3a00&invoice.paymentTerms=Net45&invoice.discountPercent=5&"
                + "invoice.discountAmount=10.0&invoice.terms=Payment+terms&invoice.note=Note+about+invoice&invoice.merchantMemo=memo&"
                + "invoice.billingInfo.firstName=Bonzop&invoice.billingInfo.lastName=Zaius&invoice.billingInfo.businessName=Bonzop+Inc&invoice.billingInfo.phone=5126914160&invoice.billingInfo.fax=5126914161&invoice.billingInfo.website=www.bonzop-inc.com&invoice.billingInfo.customValue=Business+mumbo+jumbo+%c2%a9&"
                + "invoice.shippingAmount=2.1&invoice.shippingTaxName=Bonzop+Inc&invoice.shippingTaxRate=1.2&";
            Assert.AreEqual(expectedNVPString, cir.toNVPString(""));

            cir = new CreateAndSendInvoiceRequest(new RequestEnvelope("en_US"), invoice);
            Assert.AreEqual(expectedNVPString, cir.toNVPString(""));
        }

        [Test]
        public void sendInvoiceRequestSerialization()
        {
            SendInvoiceRequest sir = new SendInvoiceRequest();
            sir.invoiceID = "INV-123456";
            sir.requestEnvelope = new RequestEnvelope("en_US");

            string expectedNVPString = "requestEnvelope.errorLanguage=en_US&invoiceID=INV-123456&";
            Assert.AreEqual(expectedNVPString, sir.toNVPString(""));

            sir = new SendInvoiceRequest(new RequestEnvelope("en_US"), "INV-123456");
            Assert.AreEqual(expectedNVPString, sir.toNVPString(""));
        }

        [Test]
        public void createInvoiceResponseConstruction()
        {
            CreateInvoiceResponse cir = CreateInvoiceResponse.createInstance(validCreateInvoiceResponse, "", -1);
            Assert.AreEqual("INV2-PCWG-P78G-7EYV-94QY", cir.invoiceID);
            Assert.AreEqual("0056", cir.invoiceNumber);
            Assert.AreEqual(AckCode.SUCCESS, cir.responseEnvelope.ack);
            Assert.AreEqual("1917403", cir.responseEnvelope.build);
            Assert.AreEqual("9b3bb0a44d852", cir.responseEnvelope.correlationId);
            Assert.AreEqual("2011-05-30T03:31:18.988-07:00", cir.responseEnvelope.timestamp);            
        }

        [Test]
        public void createAndSendInvoiceResponseConstruction()
        {
            CreateAndSendInvoiceResponse cir = CreateAndSendInvoiceResponse.createInstance(validCreateInvoiceResponse, "", -1);
            Assert.AreEqual("INV2-PCWG-P78G-7EYV-94QY", cir.invoiceID);
            Assert.AreEqual("0056", cir.invoiceNumber);
            Assert.AreEqual(AckCode.SUCCESS, cir.responseEnvelope.ack);
            Assert.AreEqual("1917403", cir.responseEnvelope.build);
            Assert.AreEqual("9b3bb0a44d852", cir.responseEnvelope.correlationId);
            Assert.AreEqual("2011-05-30T03:31:18.988-07:00", cir.responseEnvelope.timestamp);
        }

        [Test]
        public void sendInvoiceResponseConstruction()
        {
            SendInvoiceResponse cir = SendInvoiceResponse.createInstance(validSendInvoiceResponse, "", -1);
            Assert.AreEqual("INV2-PCWG-P78G-7EYV-94QY", cir.invoiceID);            
            Assert.AreEqual(AckCode.SUCCESS, cir.responseEnvelope.ack);
            Assert.AreEqual("1917403", cir.responseEnvelope.build);
            Assert.AreEqual("9b3bb0a44d852", cir.responseEnvelope.correlationId);
            Assert.AreEqual("2011-05-30T03:31:18.988-07:00", cir.responseEnvelope.timestamp);
        }

    }
}
