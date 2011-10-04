using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using PayPal.Manager;

namespace PayPal.UnitTest
{
    [TestFixture]
    class ConfigManagerTest
    {
        [Test]
        public void retrieveAccountConfigByIndex()
        {
            ConfigManager mgr = ConfigManager.Instance;
            Account acc = mgr.GetAccount(0);
            Assert.IsNotNull(acc);
            Assert.AreEqual("jb-us-seller_api1.paypal.com", acc.APIUsername);
        }

        [Test]
        public void retrieveAccountConfigByUsername()
        {
            ConfigManager mgr = ConfigManager.Instance;
            Account acc = mgr.GetAccount("jb-us-seller_api1.paypal.com");
            Assert.IsNotNull(acc);
            Assert.AreEqual("jb-us-seller_api1.paypal.com", acc.APIUsername);
            Assert.AreEqual("WX4WTU3S8MY44S7F", acc.APIPassword);
            Assert.AreEqual("AFcWxV21C7fd0v3bYYYRCpSSRl31A7yDhhsPUU2XhtMoZXsWHFxu-RWy", acc.APISignature);
            Assert.AreEqual("APP-80W284485P519543T", acc.ApplicationId);
        }

        [Test]
        public void retrieveNonExistentAccount()
        {
            ConfigManager mgr = ConfigManager.Instance;
            Account acc = mgr.GetAccount("i-do-not-exist_api1.paypal.com");
            Assert.IsNull(acc, "Invalid account name returns null account config");
        }

        [Test]
        public void retrieveValidProperty()
        {
            ConfigManager mgr = ConfigManager.Instance;
            string endpoint = mgr.GetProperty("endpoint");
            Assert.IsNotNull(endpoint);
            Assert.AreEqual(endpoint, "https://svcs.sandbox.paypal.com/");

            string connectionTimeout = mgr.GetProperty("connectionTimeout");
            Assert.IsNotNull(connectionTimeout);
            Assert.AreEqual(connectionTimeout, "360000");
        }

        [Test]
        public void retrieveNonExistentProperty()
        {
            ConfigManager mgr = ConfigManager.Instance;
            string endpoint = mgr.GetProperty("endpointMisspelt");
            Assert.IsNull(endpoint);
        }

    }
}
