using System;
using System.Collections.Generic;
using System.Text;
using PayPal.Authentication;

namespace PayPal
{
    public class BasePayPalService
    {       
        private string ServiceName;
        private string AccessToken;
        private string AccessTokenSecret;

        public BasePayPalService(string serviceName)
        {
            this.ServiceName = serviceName;
        }

        public void setAccessToken(string accessToken)
        {
            this.AccessToken = accessToken;
        }

        public void setAccessTokenSecret(string accessTokenSecret)
        {
            this.AccessTokenSecret = accessTokenSecret;
        }

        /// <summary>
        /// Call method exposed to user
        /// </summary>
        /// <param name="method"></param>
        /// <param name="requestPayload"></param>
        /// <returns></returns>
        public string call(String method, string requestPayload, string apiUsername)
        {            
            APIService apiService = new APIService(ServiceName);
            return apiService.makeRequest(method, requestPayload, apiUsername, 
                                    this.AccessToken, this.AccessTokenSecret);            
        }
    }
}
