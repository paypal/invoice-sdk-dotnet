using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.Permissions.Model;

namespace PayPal.Permissions {
	public partial class PermissionsService : BasePayPalService {

		// Service Version
		private static string ServiceVersion = "";

		// Service Name
		private static string ServiceName = "Permissions";

		public PermissionsService() : base(ServiceName, ServiceVersion)
		{
		}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest RequestPermissionsRequest, string apiUsername)
	 	{
			string resp = call("RequestPermissions", RequestPermissionsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return RequestPermissionsResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest RequestPermissionsRequest)
	 	{
	 		return RequestPermissions(RequestPermissionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest GetAccessTokenRequest, string apiUsername)
	 	{
			string resp = call("GetAccessToken", GetAccessTokenRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetAccessTokenResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest GetAccessTokenRequest)
	 	{
	 		return GetAccessToken(GetAccessTokenRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest GetPermissionsRequest, string apiUsername)
	 	{
			string resp = call("GetPermissions", GetPermissionsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetPermissionsResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest GetPermissionsRequest)
	 	{
	 		return GetPermissions(GetPermissionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest CancelPermissionsRequest, string apiUsername)
	 	{
			string resp = call("CancelPermissions", CancelPermissionsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return CancelPermissionsResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest CancelPermissionsRequest)
	 	{
	 		return CancelPermissions(CancelPermissionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest GetBasicPersonalDataRequest, string apiUsername)
	 	{
			string resp = call("GetBasicPersonalData", GetBasicPersonalDataRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetBasicPersonalDataResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest GetBasicPersonalDataRequest)
	 	{
	 		return GetBasicPersonalData(GetBasicPersonalDataRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest GetAdvancedPersonalDataRequest, string apiUsername)
	 	{
			string resp = call("GetAdvancedPersonalData", GetAdvancedPersonalDataRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetAdvancedPersonalDataResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest GetAdvancedPersonalDataRequest)
	 	{
	 		return GetAdvancedPersonalData(GetAdvancedPersonalDataRequest, null);
	 	}
	}
}
