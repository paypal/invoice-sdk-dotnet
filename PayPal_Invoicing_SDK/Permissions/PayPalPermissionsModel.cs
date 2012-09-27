/**
  * Stub objects for Permissions 
  * AUTO_GENERATED_CODE 
  */
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using PayPal.Util;

namespace PayPal.Permissions.Model
{

	public static class EnumUtils
	{
		public static string GetDescription(Enum value)
		{
			string description = "";
			DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
			{
				description= attributes[0].Description;
			}
			return description;
		}
		
		public static object GetValue(string value,Type enumType)
		{
			string[] names = Enum.GetNames(enumType);
			foreach(string name in names)
            {
            	if (GetDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
            	{
					return Enum.Parse(enumType, name);
				}
			}
			return null;
		}
	}


	/**
      *
      */
	public partial class ErrorData	{

		/**
          *
		  */
		private int? errorIdField;
		public int? errorId
		{
			get
			{
				return this.errorIdField;
			}
			set
			{
				this.errorIdField = value;
			}
		}
		

		/**
          *
		  */
		private string domainField;
		public string domain
		{
			get
			{
				return this.domainField;
			}
			set
			{
				this.domainField = value;
			}
		}
		

		/**
          *
		  */
		private string subdomainField;
		public string subdomain
		{
			get
			{
				return this.subdomainField;
			}
			set
			{
				this.subdomainField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorSeverity? severityField;
		public ErrorSeverity? severity
		{
			get
			{
				return this.severityField;
			}
			set
			{
				this.severityField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorCategory? categoryField;
		public ErrorCategory? category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}
		

		/**
          *
		  */
		private string messageField;
		public string message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
			}
		}
		

		/**
          *
		  */
		private string exceptionIdField;
		public string exceptionId
		{
			get
			{
				return this.exceptionIdField;
			}
			set
			{
				this.exceptionIdField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorParameter> parameterField = new List<ErrorParameter>();
		public List<ErrorParameter> parameter
		{
			get
			{
				return this.parameterField;
			}
			set
			{
				this.parameterField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ErrorData(){
		}



		public static ErrorData CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ErrorData errorData = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "errorId";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.errorId = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "domain";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.domain = map[key];
			}
			key = prefix + "subdomain";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.subdomain = map[key];
			}
			key = prefix + "severity";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.severity = (ErrorSeverity)EnumUtils.GetValue(map[key],typeof(ErrorSeverity));
			}
			key = prefix + "category";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.category = (ErrorCategory)EnumUtils.GetValue(map[key],typeof(ErrorCategory));
			}
			key = prefix + "message";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.message = map[key];
			}
			key = prefix + "exceptionId";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.exceptionId = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorParameter parameter =  ErrorParameter.CreateInstance(map, prefix + "parameter", i);
				if (parameter != null)
				{
					errorData = (errorData == null) ? new ErrorData() : errorData;
					errorData.parameter.Add(parameter);
					i++;
				} 
				else
				{
					break;
				}
			}
			return errorData;
		}
	}




	/**
      *
      */
	public partial class ErrorParameter	{

		/**
          *
		  */
		private string nameField;
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/**
          *
		  */
		private string valueField;
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ErrorParameter(){
		}



		public static ErrorParameter CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ErrorParameter errorParameter = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "name";
			if (map.ContainsKey(key))
			{
				errorParameter = (errorParameter == null) ? new ErrorParameter() : errorParameter;
				errorParameter.name = map[key];
			}
			key = prefix.Substring(0, prefix.Length - 1);
			if (map.ContainsKey(key))
			{
				errorParameter = (errorParameter == null) ? new ErrorParameter() : errorParameter;
				errorParameter.value = map[key];
			}
			return errorParameter;
		}
	}




	/**
      *This is the sample message 
      */
	public partial class ResponseEnvelope	{

		/**
          *
		  */
		private string timestampField;
		public string timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
			}
		}
		

		/**
          *
		  */
		private AckCode? ackField;
		public AckCode? ack
		{
			get
			{
				return this.ackField;
			}
			set
			{
				this.ackField = value;
			}
		}
		

		/**
          *
		  */
		private string correlationIdField;
		public string correlationId
		{
			get
			{
				return this.correlationIdField;
			}
			set
			{
				this.correlationIdField = value;
			}
		}
		

		/**
          *
		  */
		private string buildField;
		public string build
		{
			get
			{
				return this.buildField;
			}
			set
			{
				this.buildField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ResponseEnvelope(){
		}



		public static ResponseEnvelope CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ResponseEnvelope responseEnvelope = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "timestamp";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.timestamp = map[key];
			}
			key = prefix + "ack";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.ack = (AckCode)EnumUtils.GetValue(map[key],typeof(AckCode));
			}
			key = prefix + "correlationId";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.correlationId = map[key];
			}
			key = prefix + "build";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.build = map[key];
			}
			return responseEnvelope;
		}
	}




	/**
      *This specifies the list of parameters with every request to
      *the service. 
      */
	public partial class RequestEnvelope	{

		/**
          *
		  */
		private string errorLanguageField;
		public string errorLanguage
		{
			get
			{
				return this.errorLanguageField;
			}
			set
			{
				this.errorLanguageField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public RequestEnvelope(string errorLanguage){
			this.errorLanguage = errorLanguage;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public RequestEnvelope(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.errorLanguage != null)
			{
					sb.Append(prefix).Append("errorLanguage").Append("=").Append(HttpUtility.UrlEncode(this.errorLanguage, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *
      */
	public partial class FaultMessage	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FaultMessage(){
		}



		public static FaultMessage CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FaultMessage faultMessage = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				faultMessage = (faultMessage == null) ? new FaultMessage() : faultMessage;
				faultMessage.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					faultMessage = (faultMessage == null) ? new FaultMessage() : faultMessage;
					faultMessage.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return faultMessage;
		}
	}




	/**
      *
      */
    [Serializable]
	public enum ErrorSeverity {
		[Description("Error")]ERROR,	
		[Description("Warning")]WARNING	
	}




	/**
      *
      */
    [Serializable]
	public enum ErrorCategory {
		[Description("System")]SYSTEM,	
		[Description("Application")]APPLICATION,	
		[Description("Request")]REQUEST	
	}




	/**
      * AckCodeType This code identifies the
      * acknowledgment code types that could be used to
      * communicate the status of processing a (request)
      * message to an application. This code would be
      * used as part of a response message that contains
      * an application level acknowledgment element.
      * 
      */
    [Serializable]
	public enum AckCode {
		[Description("Success")]SUCCESS,	
		[Description("Failure")]FAILURE,	
		[Description("Warning")]WARNING,	
		[Description("SuccessWithWarning")]SUCCESSWITHWARNING,	
		[Description("FailureWithWarning")]FAILUREWITHWARNING,	
		[Description("CustomCode")]CUSTOMCODE	
	}




	/**
      * Enumeration for Personal Attributes of a user.
      * 
      */
    [Serializable]
	public enum PersonalAttribute {
		[Description("http://axschema.org/namePerson/first")]HTTPAXSCHEMAORGNAMEPERSONFIRST,	
		[Description("http://axschema.org/namePerson/last")]HTTPAXSCHEMAORGNAMEPERSONLAST,	
		[Description("http://axschema.org/contact/email")]HTTPAXSCHEMAORGCONTACTEMAIL,	
		[Description("http://schema.openid.net/contact/fullname")]HTTPSCHEMAOPENIDNETCONTACTFULLNAME,	
		[Description("http://axschema.org/company/name")]HTTPAXSCHEMAORGCOMPANYNAME,	
		[Description("http://axschema.org/contact/country/home")]HTTPAXSCHEMAORGCONTACTCOUNTRYHOME,	
		[Description("http://axschema.org/birthDate")]HTTPAXSCHEMAORGBIRTHDATE,	
		[Description("http://axschema.org/contact/postalCode/home")]HTTPAXSCHEMAORGCONTACTPOSTALCODEHOME,	
		[Description("http://schema.openid.net/contact/street1")]HTTPSCHEMAOPENIDNETCONTACTSTREET1,	
		[Description("http://schema.openid.net/contact/street2")]HTTPSCHEMAOPENIDNETCONTACTSTREET,	
		[Description("http://axschema.org/contact/city/home")]HTTPAXSCHEMAORGCONTACTCITYHOME,	
		[Description("http://axschema.org/contact/state/home")]HTTPAXSCHEMAORGCONTACTSTATEHOME,	
		[Description("http://axschema.org/contact/phone/default")]HTTPAXSCHEMAORGCONTACTPHONEDEFAULT,	
		[Description("https://www.paypal.com/webapps/auth/schema/payerID")]HTTPSWWWPAYPALCOMWEBAPPSAUTHSCHEMAPAYERID2	
	}




	/**
      *Describes the request for permissions over an account.
      *Primary element is "scope", which lists the permissions
      *needed. 
      */
	public partial class RequestPermissionsRequest	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> scopeField = new List<string>();
		public List<string> scope
		{
			get
			{
				return this.scopeField;
			}
			set
			{
				this.scopeField = value;
			}
		}
		

		/**
          *
		  */
		private string callbackField;
		public string callback
		{
			get
			{
				return this.callbackField;
			}
			set
			{
				this.callbackField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public RequestPermissionsRequest(List<string> scope, string callback){
			this.scope = scope;
			this.callback = callback;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public RequestPermissionsRequest(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			for (int i = 0; i < this.scope.Count; i++)
			{
				if (this.scope[i] != null)
				{
					sb.Append(prefix).Append("scope").Append("(").Append(i).Append(")").Append("=").Append(HttpUtility.UrlEncode(this.scope[i], BaseConstants.ENCODING_FORMAT)).Append("&");
				}
			}
			if (this.callback != null)
			{
					sb.Append(prefix).Append("callback").Append("=").Append(HttpUtility.UrlEncode(this.callback, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *Returns the temporary request token 
      */
	public partial class RequestPermissionsResponse	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string tokenField;
		public string token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RequestPermissionsResponse(){
		}



		public static RequestPermissionsResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			RequestPermissionsResponse requestPermissionsResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				requestPermissionsResponse = (requestPermissionsResponse == null) ? new RequestPermissionsResponse() : requestPermissionsResponse;
				requestPermissionsResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "token";
			if (map.ContainsKey(key))
			{
				requestPermissionsResponse = (requestPermissionsResponse == null) ? new RequestPermissionsResponse() : requestPermissionsResponse;
				requestPermissionsResponse.token = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					requestPermissionsResponse = (requestPermissionsResponse == null) ? new RequestPermissionsResponse() : requestPermissionsResponse;
					requestPermissionsResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return requestPermissionsResponse;
		}
	}




	/**
      *The request use to retrieve a permanent access token. The
      *client can either send the token and verifier, or a subject.
      *
      */
	public partial class GetAccessTokenRequest	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string tokenField;
		public string token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private string verifierField;
		public string verifier
		{
			get
			{
				return this.verifierField;
			}
			set
			{
				this.verifierField = value;
			}
		}
		

		/**
          *
		  */
		private string subjectAliasField;
		public string subjectAlias
		{
			get
			{
				return this.subjectAliasField;
			}
			set
			{
				this.subjectAliasField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAccessTokenRequest(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.token != null)
			{
					sb.Append(prefix).Append("token").Append("=").Append(HttpUtility.UrlEncode(this.token, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.verifier != null)
			{
					sb.Append(prefix).Append("verifier").Append("=").Append(HttpUtility.UrlEncode(this.verifier, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.subjectAlias != null)
			{
					sb.Append(prefix).Append("subjectAlias").Append("=").Append(HttpUtility.UrlEncode(this.subjectAlias, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *Permanent access token and token secret that can be used to
      *make requests for protected resources owned by another
      *account. 
      */
	public partial class GetAccessTokenResponse	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> scopeField = new List<string>();
		public List<string> scope
		{
			get
			{
				return this.scopeField;
			}
			set
			{
				this.scopeField = value;
			}
		}
		

		/**
          *
		  */
		private string tokenField;
		public string token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
          *
		  */
		private string tokenSecretField;
		public string tokenSecret
		{
			get
			{
				return this.tokenSecretField;
			}
			set
			{
				this.tokenSecretField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAccessTokenResponse(){
		}



		public static GetAccessTokenResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetAccessTokenResponse getAccessTokenResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getAccessTokenResponse = (getAccessTokenResponse == null) ? new GetAccessTokenResponse() : getAccessTokenResponse;
				getAccessTokenResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				key = prefix + "scope" + "(" + i + ")";
				if (map.ContainsKey(key))
				{
					getAccessTokenResponse = (getAccessTokenResponse == null) ? new GetAccessTokenResponse() : getAccessTokenResponse;
					getAccessTokenResponse.scope.Add(map[key]);
					i++;
				}
				else
				{
					break;
				}
			}
			key = prefix + "token";
			if (map.ContainsKey(key))
			{
				getAccessTokenResponse = (getAccessTokenResponse == null) ? new GetAccessTokenResponse() : getAccessTokenResponse;
				getAccessTokenResponse.token = map[key];
			}
			key = prefix + "tokenSecret";
			if (map.ContainsKey(key))
			{
				getAccessTokenResponse = (getAccessTokenResponse == null) ? new GetAccessTokenResponse() : getAccessTokenResponse;
				getAccessTokenResponse.tokenSecret = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getAccessTokenResponse = (getAccessTokenResponse == null) ? new GetAccessTokenResponse() : getAccessTokenResponse;
					getAccessTokenResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getAccessTokenResponse;
		}
	}




	/**
      *Request to retrieve the approved list of permissions
      *associated with a token. 
      */
	public partial class GetPermissionsRequest	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string tokenField;
		public string token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetPermissionsRequest(string token){
			this.token = token;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetPermissionsRequest(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.token != null)
			{
					sb.Append(prefix).Append("token").Append("=").Append(HttpUtility.UrlEncode(this.token, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The list of permissions associated with the token. 
      */
	public partial class GetPermissionsResponse	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> scopeField = new List<string>();
		public List<string> scope
		{
			get
			{
				return this.scopeField;
			}
			set
			{
				this.scopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetPermissionsResponse(){
		}



		public static GetPermissionsResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetPermissionsResponse getPermissionsResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getPermissionsResponse = (getPermissionsResponse == null) ? new GetPermissionsResponse() : getPermissionsResponse;
				getPermissionsResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				key = prefix + "scope" + "(" + i + ")";
				if (map.ContainsKey(key))
				{
					getPermissionsResponse = (getPermissionsResponse == null) ? new GetPermissionsResponse() : getPermissionsResponse;
					getPermissionsResponse.scope.Add(map[key]);
					i++;
				}
				else
				{
					break;
				}
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getPermissionsResponse = (getPermissionsResponse == null) ? new GetPermissionsResponse() : getPermissionsResponse;
					getPermissionsResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getPermissionsResponse;
		}
	}




	/**
      *Request to invalidate an access token and revoke the
      *permissions associated with it. 
      */
	public partial class CancelPermissionsRequest	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string tokenField;
		public string token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CancelPermissionsRequest(string token){
			this.token = token;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CancelPermissionsRequest(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.token != null)
			{
					sb.Append(prefix).Append("token").Append("=").Append(HttpUtility.UrlEncode(this.token, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *
      */
	public partial class CancelPermissionsResponse	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CancelPermissionsResponse(){
		}



		public static CancelPermissionsResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CancelPermissionsResponse cancelPermissionsResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				cancelPermissionsResponse = (cancelPermissionsResponse == null) ? new CancelPermissionsResponse() : cancelPermissionsResponse;
				cancelPermissionsResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					cancelPermissionsResponse = (cancelPermissionsResponse == null) ? new CancelPermissionsResponse() : cancelPermissionsResponse;
					cancelPermissionsResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return cancelPermissionsResponse;
		}
	}




	/**
      *List of Personal Attributes to be sent as a request. 
      */
	public partial class PersonalAttributeList	{

		/**
          *
		  */
		private List<PersonalAttribute?> attributeField = new List<PersonalAttribute?>();
		public List<PersonalAttribute?> attribute
		{
			get
			{
				return this.attributeField;
			}
			set
			{
				this.attributeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PersonalAttributeList(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.attribute.Count; i++)
			{
				if (this.attribute[i] != null)
				{
					sb.Append(prefix).Append("attribute(").Append(i).Append(")=").Append(EnumUtils.GetDescription(attribute[i]));
					sb.Append("&");
				}
			}
			return sb.ToString();
		}
	}




	/**
      *A property of User Identity data , represented as a
      *Name-value pair with Name being the PersonalAttribute
      *requested and value being the data. 
      */
	public partial class PersonalData	{

		/**
          *
		  */
		private PersonalAttribute? personalDataKeyField;
		public PersonalAttribute? personalDataKey
		{
			get
			{
				return this.personalDataKeyField;
			}
			set
			{
				this.personalDataKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string personalDataValueField;
		public string personalDataValue
		{
			get
			{
				return this.personalDataValueField;
			}
			set
			{
				this.personalDataValueField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PersonalData(){
		}



		public static PersonalData CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PersonalData personalData = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "personalDataKey";
			if (map.ContainsKey(key))
			{
				personalData = (personalData == null) ? new PersonalData() : personalData;
				personalData.personalDataKey = (PersonalAttribute)EnumUtils.GetValue(map[key],typeof(PersonalAttribute));
			}
			key = prefix + "personalDataValue";
			if (map.ContainsKey(key))
			{
				personalData = (personalData == null) ? new PersonalData() : personalData;
				personalData.personalDataValue = map[key];
			}
			return personalData;
		}
	}




	/**
      *Set of personal data which forms the response of
      *GetPersonalData call. 
      */
	public partial class PersonalDataList	{

		/**
          *
		  */
		private List<PersonalData> personalDataField = new List<PersonalData>();
		public List<PersonalData> personalData
		{
			get
			{
				return this.personalDataField;
			}
			set
			{
				this.personalDataField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PersonalDataList(){
		}



		public static PersonalDataList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PersonalDataList personalDataList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				PersonalData personalData =  PersonalData.CreateInstance(map, prefix + "personalData", i);
				if (personalData != null)
				{
					personalDataList = (personalDataList == null) ? new PersonalDataList() : personalDataList;
					personalDataList.personalData.Add(personalData);
					i++;
				} 
				else
				{
					break;
				}
			}
			return personalDataList;
		}
	}




	/**
      *Request to retrieve basic personal data.Accepts
      *PersonalAttributeList as request and responds with
      *PersonalDataList. This call will accept only 'Basic'
      *attributes and ignore others. 
      */
	public partial class GetBasicPersonalDataRequest	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private PersonalAttributeList attributeListField;
		public PersonalAttributeList attributeList
		{
			get
			{
				return this.attributeListField;
			}
			set
			{
				this.attributeListField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetBasicPersonalDataRequest(PersonalAttributeList attributeList){
			this.attributeList = attributeList;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBasicPersonalDataRequest(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.attributeList != null)
			{
					string newPrefix = prefix + "attributeList" + ".";
					sb.Append(this.attributeListField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *Request to retrieve personal data.Accepts
      *PersonalAttributeList as request and responds with
      *PersonalDataList. This call will accept both 'Basic' and
      *Advanced attributes. 
      */
	public partial class GetAdvancedPersonalDataRequest	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private PersonalAttributeList attributeListField;
		public PersonalAttributeList attributeList
		{
			get
			{
				return this.attributeListField;
			}
			set
			{
				this.attributeListField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetAdvancedPersonalDataRequest(PersonalAttributeList attributeList){
			this.attributeList = attributeList;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAdvancedPersonalDataRequest(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.attributeList != null)
			{
					string newPrefix = prefix + "attributeList" + ".";
					sb.Append(this.attributeListField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *
      */
	public partial class GetBasicPersonalDataResponse	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private PersonalDataList responseField;
		public PersonalDataList response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.responseField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetBasicPersonalDataResponse(){
		}



		public static GetBasicPersonalDataResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetBasicPersonalDataResponse getBasicPersonalDataResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getBasicPersonalDataResponse = (getBasicPersonalDataResponse == null) ? new GetBasicPersonalDataResponse() : getBasicPersonalDataResponse;
				getBasicPersonalDataResponse.responseEnvelope = responseEnvelope;
			}
			PersonalDataList response =  PersonalDataList.CreateInstance(map, prefix + "response", -1);
			if (response != null)
			{
				getBasicPersonalDataResponse = (getBasicPersonalDataResponse == null) ? new GetBasicPersonalDataResponse() : getBasicPersonalDataResponse;
				getBasicPersonalDataResponse.response = response;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getBasicPersonalDataResponse = (getBasicPersonalDataResponse == null) ? new GetBasicPersonalDataResponse() : getBasicPersonalDataResponse;
					getBasicPersonalDataResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getBasicPersonalDataResponse;
		}
	}




	/**
      *
      */
	public partial class GetAdvancedPersonalDataResponse	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private PersonalDataList responseField;
		public PersonalDataList response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.responseField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAdvancedPersonalDataResponse(){
		}



		public static GetAdvancedPersonalDataResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetAdvancedPersonalDataResponse getAdvancedPersonalDataResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getAdvancedPersonalDataResponse = (getAdvancedPersonalDataResponse == null) ? new GetAdvancedPersonalDataResponse() : getAdvancedPersonalDataResponse;
				getAdvancedPersonalDataResponse.responseEnvelope = responseEnvelope;
			}
			PersonalDataList response =  PersonalDataList.CreateInstance(map, prefix + "response", -1);
			if (response != null)
			{
				getAdvancedPersonalDataResponse = (getAdvancedPersonalDataResponse == null) ? new GetAdvancedPersonalDataResponse() : getAdvancedPersonalDataResponse;
				getAdvancedPersonalDataResponse.response = response;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getAdvancedPersonalDataResponse = (getAdvancedPersonalDataResponse == null) ? new GetAdvancedPersonalDataResponse() : getAdvancedPersonalDataResponse;
					getAdvancedPersonalDataResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getAdvancedPersonalDataResponse;
		}
	}





}