using System.Xml;
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
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest requestPermissionsRequest, string apiUserName)
	 	{
			string response = Call("RequestPermissions", requestPermissionsRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return RequestPermissionsResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest requestPermissionsRequest)
	 	{
	 		return RequestPermissions(requestPermissionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest getAccessTokenRequest, string apiUserName)
	 	{
			string response = Call("GetAccessToken", getAccessTokenRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetAccessTokenResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest getAccessTokenRequest)
	 	{
	 		return GetAccessToken(getAccessTokenRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest getPermissionsRequest, string apiUserName)
	 	{
			string response = Call("GetPermissions", getPermissionsRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetPermissionsResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest getPermissionsRequest)
	 	{
	 		return GetPermissions(getPermissionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest cancelPermissionsRequest, string apiUserName)
	 	{
			string response = Call("CancelPermissions", cancelPermissionsRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return CancelPermissionsResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest cancelPermissionsRequest)
	 	{
	 		return CancelPermissions(cancelPermissionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest getBasicPersonalDataRequest, string apiUserName)
	 	{
			string response = Call("GetBasicPersonalData", getBasicPersonalDataRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetBasicPersonalDataResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest getBasicPersonalDataRequest)
	 	{
	 		return GetBasicPersonalData(getBasicPersonalDataRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest getAdvancedPersonalDataRequest, string apiUserName)
	 	{
			string response = Call("GetAdvancedPersonalData", getAdvancedPersonalDataRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetAdvancedPersonalDataResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest getAdvancedPersonalDataRequest)
	 	{
	 		return GetAdvancedPersonalData(getAdvancedPersonalDataRequest, null);
	 	}
	}
}
