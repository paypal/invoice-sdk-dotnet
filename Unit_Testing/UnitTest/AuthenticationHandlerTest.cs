using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

using NUnit.Framework;

using PayPal.Authentication;
using PayPal.Manager;
using PayPal.Exception;

namespace PayPal.UnitTest
{
    [TestFixture]
    class AuthenticationHandlerTest
    {
        [Test]
        [ExpectedException(typeof(InvalidCredentialException))]
        public void setAuthenticationParamsForInvalidAccount()
        {
            ConnectionManager connMgr = ConnectionManager.Instance;
            AuthenticationHandler authHandler = new AuthenticationHandler("incomplete-credentials_api1.paypal.com");
            HttpWebRequest httpRequest = connMgr.GetConnection("http://paypal.com");

            authHandler.SetAuthenticationParams(httpRequest, "");            
        }

        [Test]
        public void setAuthenticationParamsForSignatureAccount()
        {
            ConnectionManager connMgr = ConnectionManager.Instance;
            AuthenticationHandler authHandler = new AuthenticationHandler("jb-us-seller_api1.paypal.com");
            HttpWebRequest httpRequest = connMgr.GetConnection("http://paypal.com");
            
            authHandler.SetAuthenticationParams(httpRequest, "");

            Assert.AreEqual(4, httpRequest.Headers.Count);
            List<string> expectedHeaders = new List<string>(new string[]  
            {
                BaseConstants.XPAYPALSECURITYUSERID, BaseConstants.XPAYPALSECURITYPASSWORD,
                BaseConstants.XPAYPALAPPLICATIONID, BaseConstants.XPAYPALSECURITYSIGNATURE                
            });
            foreach (string headerName in expectedHeaders)
                Assert.Contains(headerName, httpRequest.Headers);            
        }

       /* [Test]
        public void setAuthenticationParamsForCertificateAccount()
        {
            ConnectionManager connMgr = ConnectionManager.Instance;
            AuthenticationHandler authHandler = new AuthenticationHandler("jb-us-seller2_api1.paypal.com");
            HttpWebRequest httpRequest = connMgr.getConnection("http://paypal.com");

            authHandler.SetAuthenticationParams(httpRequest, "");
            foreach (string headerName in httpRequest.Headers)
            {
                Console.Write(headerName);
            }
            Assert.AreEqual(3, httpRequest.Headers.Count);
            List<string> expectedHeaders = new List<string>(new string[]  
            {
                BaseConstants.XPAYPALSECURITYUSERID, BaseConstants.XPAYPALSECURITYPASSWORD,
                BaseConstants.XPAYPALAPPLICATIONID

            });
            foreach (string headerName in expectedHeaders)
                Assert.Contains(headerName, httpRequest.Headers);
        }*/

        [Test]
        public void testOAuthSignature()
        {            
            ConnectionManager connMgr = ConnectionManager.Instance;            
            HttpWebRequest httpRequest = connMgr.GetConnection("http://paypal.com");

            AuthenticationHandler authHandler = new AuthenticationHandler("jb-us-seller_api1.paypal.com");            
            authHandler.SetOAuthToken("token", "tokenSecret");            
            authHandler.SetAuthenticationParams(httpRequest, "http://svcs.sandbox.paypal.com/Service");
            Assert.Contains(BaseConstants.XPAYPALSECURITYOAUTHSIGN, httpRequest.Headers);   
        }
    }
}
