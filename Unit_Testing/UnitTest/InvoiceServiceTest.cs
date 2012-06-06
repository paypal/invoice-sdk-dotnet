using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;
using log4net;
using log4net.Config;
using System.Configuration;
using PayPal.Util;
using PayPal;
using PayPal.Invoice;
using PayPal.Invoice.Model;
using PayPal.Authentication;
using PayPal.Exception;
using NUnit.Framework;


namespace PayPal.UnitTest
{
    [TestFixture]
    public class InvoiceServiceTest
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(InvoiceServiceTest));
        private CreateInvoiceRequest cr = null;

        #region Static Methods

        [SetUp]
        public void Init()
        {
            this.cr = new CreateInvoiceRequest();
            cr.requestEnvelope = new RequestEnvelope();
            cr.requestEnvelope.errorLanguage = "en_US";
            cr.requestEnvelope.detailLevel = DetailLevelCode.RETURNALL;


            cr.invoice = new InvoiceType();
            cr.invoice.currencyCode = "USD";
            cr.invoice.merchantEmail = "jb-us-seller@paypal.com";
            cr.invoice.payerEmail = "jbui-us-personal1@paypal.com";
            cr.invoice.paymentTerms = PaymentTermsType.DUEONRECEIPT;
            cr.invoice.itemList = new InvoiceItemListType();
            cr.invoice.itemList.item = new List<InvoiceItemType>();
            cr.invoice.itemList.item.Add(new InvoiceItemType());
            cr.invoice.itemList.item[0].name = "product1";
            cr.invoice.itemList.item[0].quantity = 10;
            cr.invoice.itemList.item[0].unitPrice = 2;
        }

        [Test]
        public void CreateInvoiceTest()
        {
            CreateInvoiceResponse cir = null;
            try
            {
                InvoiceService service = new InvoiceService();                
                cir = service.CreateInvoice(this.cr);
                Assert.AreEqual(AckCode.SUCCESS, cir.responseEnvelope.ack);
                Assert.IsNotNull(cir.invoiceID);
                Assert.IsNotNull(cir.invoiceNumber);                
            }
            catch (System.Exception e)
            {
                Console.Write(e.Message);
                Assert.Fail(e.Message);
            }
   
        }

        [Test]
        public void CreateInvoiceForThirdPartyTest()
        {
            CreateInvoiceResponse cir = null;
            try
            {
                InvoiceService service = new InvoiceService();
                service.setAccessToken("MflQEeAERGJPxdFYxkH29I53S5Ahcsimnv7fwa14n8x985-ugCgTSA");
                service.setAccessTokenSecret("kQE-WPNw2n6soaxftD-1I8Nm0Ss");

                this.cr.invoice.merchantEmail = "jb-us-thirdparty@paypal.com";
                cir = service.CreateInvoice(this.cr);
                Assert.AreEqual(AckCode.SUCCESS, cir.responseEnvelope.ack);
                Assert.IsNotNull(cir.invoiceID);
                Assert.IsNotNull(cir.invoiceNumber);
            }
            catch (System.Exception e)
            {
                Console.Write(e.Message);
                Assert.Fail(e.Message);
            }

        }

        [Test]
        public void CreateAndSendInvoiceTest()
        {

            CreateAndSendInvoiceRequest cr = new CreateAndSendInvoiceRequest();
            cr.requestEnvelope = new RequestEnvelope();
            cr.requestEnvelope.errorLanguage = "en_US";
            cr.requestEnvelope.detailLevel = DetailLevelCode.RETURNALL;
            
            cr.invoice = new InvoiceType();
            cr.invoice.currencyCode = "USD";
            cr.invoice.merchantEmail = "jb-us-seller@paypal.com";
            cr.invoice.payerEmail = "jbui-us-personal1@paypal.com";
            cr.invoice.paymentTerms = PaymentTermsType.DUEONRECEIPT;

            cr.invoice.itemList = new InvoiceItemListType();
            cr.invoice.itemList.item = new List<InvoiceItemType>();
            cr.invoice.itemList.item.Add(new InvoiceItemType());
            cr.invoice.itemList.item[0].name = "product1";
            cr.invoice.itemList.item[0].quantity = 10;
            cr.invoice.itemList.item[0].unitPrice = 2;       
            CreateAndSendInvoiceResponse cir = null;
    
            try 
            {
                InvoiceService service = new InvoiceService();
                cir = service.CreateAndSendInvoice(cr);            
            }
            catch (System.Exception e)
            {
                Console.Write(e.Message);
                Assert.Fail(e.Message);
            }

            Assert.AreEqual(AckCode.SUCCESS, cir.responseEnvelope.ack);            
            Assert.IsNotNull(cir.invoiceNumber);
            Assert.IsNotNull(cir.invoiceID);

        }

        [Test]
        public void SendInvoiceTest()
        {

            SendInvoiceRequest sr = new SendInvoiceRequest();            
            sr.requestEnvelope = new RequestEnvelope();
            sr.requestEnvelope.errorLanguage = "en_US";
            sr.requestEnvelope.detailLevel = DetailLevelCode.RETURNALL;            

            SendInvoiceResponse sir = null;
            CreateInvoiceResponse cir = null;

            try
            {
                InvoiceService service = new InvoiceService();

                cir = service.CreateInvoice(this.cr);
                Assert.AreEqual(AckCode.SUCCESS, cir.responseEnvelope.ack);

                sr.invoiceID = cir.invoiceID;
                sir = service.SendInvoice(sr);
            }
            catch (System.Exception e)
            {
                Console.Write(e.Message);
                Assert.Fail(e.Message);
            }

            Assert.AreEqual(AckCode.SUCCESS, sir.responseEnvelope.ack);
            Assert.AreEqual(cir.invoiceID, sir.invoiceID);            
        }

        #endregion


    }    
}
