using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;
using PayPal.Util;
using NUnit.Framework;

namespace PayPal.UnitTest
{
    [TestFixture]
    public class NVPUtilTest
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(NVPUtilTest));

        #region Static Methods
        [Test]
        public static void SplitResponseStringTest()
        {            
            NVPUtil util = new NVPUtil();            
            Dictionary<string, string> ret = util.ParseNVPString("responseEnvelope.timestamp=2011-05-11T22%3A05%3A33.962-07%3A00&responseEnvelope.ack=Failure&responseEnvelope.correlationId=b1985a21862fe&responseEnvelope.build=1877082&error(0).errorId=580022&error(0).domain=PLATFORM&error(0).subdomain=Application&error(0).severity=Error&error(0).category=Application&error(0).message=Invalid+request+parameter%3A+shippingTaxName+cannot+be+null&error(0).parameter(0)=shippingTaxName&error(0).parameter(1)=null&error(1).errorId=580022&error(1).domain=PLATFORM&error(1).subdomain=Application&error(1).severity=Error&error(1).category=Application&error(1).message=Invalid+request+parameter%3A+taxName+cannot+be+null&error(1).parameter(0)=taxName&error(1).parameter(1)=null");            
            Assert.AreEqual(ret.Count, 20);                        
            Assert.IsTrue(ret.ContainsKey("responseEnvelope.timestamp"));
            Assert.AreEqual(ret["responseEnvelope.timestamp"], "2011-05-11T22:05:33.962-07:00");

            Assert.IsTrue(ret.ContainsKey("responseEnvelope.ack"));
            Assert.AreEqual(ret["responseEnvelope.ack"], "Failure");

            Assert.IsTrue(ret.ContainsKey("responseEnvelope.correlationId"));
            Assert.AreEqual(ret["responseEnvelope.correlationId"], "b1985a21862fe");

            Assert.IsTrue(ret.ContainsKey("responseEnvelope.build"));
            Assert.AreEqual(ret["responseEnvelope.build"], "1877082");

            Assert.IsTrue(ret.ContainsKey("error(0).errorId"));
            Assert.AreEqual(ret["error(0).errorId"], "580022");

            Assert.IsTrue(ret.ContainsKey("error(0).domain"));
            Assert.AreEqual(ret["error(0).domain"], "PLATFORM");

            Assert.IsTrue(ret.ContainsKey("error(0).subdomain"));
            Assert.AreEqual(ret["error(0).subdomain"], "Application");

            Assert.IsTrue(ret.ContainsKey("error(0).severity"));
            Assert.AreEqual(ret["error(0).severity"], "Error");

            Assert.IsTrue(ret.ContainsKey("error(0).category"));
            Assert.AreEqual(ret["error(0).category"], "Application");

            Assert.IsTrue(ret.ContainsKey("error(0).message"));
            Assert.AreEqual(ret["error(0).message"], "Invalid request parameter: shippingTaxName cannot be null");

            Assert.IsTrue(ret.ContainsKey("error(0).parameter(0)"));
            Assert.AreEqual(ret["error(0).parameter(0)"], "shippingTaxName");

            Assert.IsTrue(ret.ContainsKey("error(0).parameter(1)"));
            Assert.AreEqual(ret["error(0).parameter(1)"], "null");

            Assert.IsTrue(ret.ContainsKey("error(1).errorId"));
            Assert.AreEqual(ret["error(1).errorId"], "580022");

            Assert.IsTrue(ret.ContainsKey("error(1).domain"));
            Assert.AreEqual(ret["error(1).domain"], "PLATFORM");

            Assert.IsTrue(ret.ContainsKey("error(1).subdomain"));
            Assert.AreEqual(ret["error(1).subdomain"], "Application");

            Assert.IsTrue(ret.ContainsKey("error(1).severity"));
            Assert.AreEqual(ret["error(1).severity"], "Error");

            Assert.IsTrue(ret.ContainsKey("error(1).category"));
            Assert.AreEqual(ret["error(1).category"], "Application");

            Assert.IsTrue(ret.ContainsKey("error(1).message"));
            Assert.AreEqual(ret["error(1).message"], "Invalid request parameter: taxName cannot be null");

            Assert.IsTrue(ret.ContainsKey("error(1).parameter(0)"));
            Assert.AreEqual(ret["error(1).parameter(0)"], "taxName");

            Assert.IsTrue(ret.ContainsKey("error(1).parameter(1)"));
            Assert.AreEqual(ret["error(1).parameter(1)"], "null");

        }
        #endregion

    }
}
