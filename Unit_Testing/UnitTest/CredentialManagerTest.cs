using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using PayPal.Exception;
using PayPal.Manager;
using PayPal.Authentication;

namespace PayPal.UnitTest
{
    [TestFixture]
    class CredentialManagerTest
    {
        [Test]
        public void loadSignatureCredential()
        {
            string apiUsername = "jb-us-seller_api1.paypal.com";
            CredentialManager mgr = CredentialManager.Instance;
            ICredential cred = mgr.GetCredentials(apiUsername);
            Assert.NotNull(cred);
            Assert.IsInstanceOf(typeof(SignatureCredential), cred);

            SignatureCredential sig = (SignatureCredential) cred;
            Assert.AreEqual(apiUsername, sig.APIUsername);
            Assert.AreEqual("WX4WTU3S8MY44S7F", sig.APIPassword);
            Assert.AreEqual("AFcWxV21C7fd0v3bYYYRCpSSRl31A7yDhhsPUU2XhtMoZXsWHFxu-RWy", sig.APISignature);
            Assert.AreEqual("APP-80W284485P519543T", sig.ApplicationID);            
        }

        [Test]
        public void loadCertificateCredential()
        {
            string apiUsername = "jb-us-seller2_api1.paypal.com";
            CredentialManager mgr = CredentialManager.Instance;
            ICredential cred = mgr.GetCredentials(apiUsername);
            Assert.NotNull(cred);
            Assert.IsInstanceOf(typeof(CertificateCredential), cred);

            CertificateCredential cert = (CertificateCredential)cred;
            Assert.AreEqual(apiUsername, cert.APIUsername);
            Assert.AreEqual("Y382QH72D4MQYJT3", cert.APIPassword);
            Assert.AreEqual("C:/certs/paypal.p12", cert.CertificateFile);
            Assert.AreEqual("11111111", cert.PrivateKeyPassword);
            Assert.AreEqual("APP-5XV204960S3290106", cert.ApplicationID);
        }

        [Test]
        [ExpectedException( typeof(MissingCredentialException) )]
        public void loadCredentialForNonExistentAccount()
        {
            CredentialManager mgr = CredentialManager.Instance;
            ICredential cred = mgr.GetCredentials("i-do-not-exist_api1.paypal.com");
        }
    }
}
