using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using PayPal.Authentication;

namespace PayPal.UnitTest
{
    [TestFixture]
    class CertificateCredentialTest
    {

        [Test]
        public void ObjectCreation()
        {
            CertificateCredential cred = new CertificateCredential();
            cred.APIUsername = "username_api1.paypal.com";
            cred.APIPassword = "QWERRTYUIOP";
            cred.ApplicationID = "APP-1234ASDFG";
            cred.CertificateFile = "/certs/sdk.p12";
            cred.PrivateKeyPassword = "password";

            Assert.AreEqual("username_api1.paypal.com", cred.APIUsername);
            Assert.AreEqual("QWERRTYUIOP", cred.APIPassword);
            Assert.AreEqual("APP-1234ASDFG", cred.ApplicationID);
            Assert.AreEqual("/certs/sdk.p12", cred.CertificateFile);
            Assert.AreEqual("password", cred.PrivateKeyPassword);
        }
    }
}
