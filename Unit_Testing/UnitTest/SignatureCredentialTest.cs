using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using PayPal.Authentication;

namespace PayPal.UnitTest
{
    [TestFixture]
    class SignatureCredentialTest
    {
        [Test]
        public void ObjectCreation()
        {
            SignatureCredential cred = new SignatureCredential();
            cred.APIUsername = "username_api1.paypal.com";
            cred.APIPassword = "QWERRTYUIOP";
            cred.ApplicationID = "APP-1234ASDFG";
            cred.APISignature = "Adsjsalkdsadsad.sdsadipoewirpoewr";            

            Assert.AreEqual("username_api1.paypal.com", cred.APIUsername);
            Assert.AreEqual("QWERRTYUIOP", cred.APIPassword);
            Assert.AreEqual("Adsjsalkdsadsad.sdsadipoewirpoewr", cred.APISignature);
            Assert.AreEqual("APP-1234ASDFG", cred.ApplicationID);     
        }
    }
}
