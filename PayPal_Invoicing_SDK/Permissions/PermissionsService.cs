/** 
 * Auto generated code
 */

using PayPal.Authentication;

namespace PayPal.Permissions {

	using PayPal;
	using PayPal.Util;
	using PayPal.Manager;
	using PayPal.Permissions.Model;

	public partial class PermissionsService : BasePayPalService{

		private static string serviceName = "Permissions";
        private static string serviceVersion = "";

		 public PermissionsService() : base(serviceName, serviceVersion)
        {}
		/**
		 *
		 */
		public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest RequestPermissionsRequest, string apiUsername) 
		{	
			string resp = call("RequestPermissions", RequestPermissionsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return new RequestPermissionsResponse(util.parseNVPString(resp), "");
		}

		public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest RequestPermissionsRequest) 
		{
			return RequestPermissions(RequestPermissionsRequest, null);
		}
		/**
		 *
		 */
		public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest GetAccessTokenRequest, string apiUsername) 
		{
			string resp = call("GetAccessToken", GetAccessTokenRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return new GetAccessTokenResponse(util.parseNVPString(resp), "");
		}

		public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest GetAccessTokenRequest) 
		{
			return GetAccessToken(GetAccessTokenRequest, null);
		}
		/**
		 *
		 */
		public GetPermissionsResponse GetPermissions(GetPermissionsRequest GetPermissionsRequest, string apiUsername) 
		{
			string resp = call("GetPermissions", GetPermissionsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return new GetPermissionsResponse(util.parseNVPString(resp), "");
		}

		public GetPermissionsResponse GetPermissions(GetPermissionsRequest GetPermissionsRequest) 
		{
			return GetPermissions(GetPermissionsRequest, null);
		}
		/**
		 *
		 */
		public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest CancelPermissionsRequest, string apiUsername) 
		{
			string resp = call("CancelPermissions", CancelPermissionsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return new CancelPermissionsResponse(util.parseNVPString(resp), "");
		}

		public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest CancelPermissionsRequest) 
		{
			return CancelPermissions(CancelPermissionsRequest, null);
		}
	}
}

