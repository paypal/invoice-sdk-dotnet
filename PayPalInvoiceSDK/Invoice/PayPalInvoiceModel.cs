/*
 * Stub objects for Invoice 
 * AUTO_GENERATED_CODE 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using PayPal.Util;

namespace PayPal.Invoice.Model
{

	/// <summary>
	/// Utility class for Enums with descriptions
	/// </summary>
	public static class EnumUtils
	{
		/// <summary>
		/// Get description for a give enum value
		/// </summary>	
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
		
		/// <summary>
		/// Convert a string to an enum object
		/// </summary>	
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


	/// <summary>
	/// 
    /// </summary>
	public partial class BaseAddress	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string line1Field;
		public string line1
		{
			get
			{
				return this.line1Field;
			}
			set
			{
				this.line1Field = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string line2Field;
		public string line2
		{
			get
			{
				return this.line2Field;
			}
			set
			{
				this.line2Field = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cityField;
		public string city
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string stateField;
		public string state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string postalCodeField;
		public string postalCode
		{
			get
			{
				return this.postalCodeField;
			}
			set
			{
				this.postalCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string typeField;
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public BaseAddress(string line1, string city, string countryCode)
	 	{
			this.line1 = line1;
			this.city = city;
			this.countryCode = countryCode;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public BaseAddress()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.line1 != null)
			{
					sb.Append(prefix).Append("line1").Append("=").Append(HttpUtility.UrlEncode(this.line1, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.line2 != null)
			{
					sb.Append(prefix).Append("line2").Append("=").Append(HttpUtility.UrlEncode(this.line2, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.city != null)
			{
					sb.Append(prefix).Append("city").Append("=").Append(HttpUtility.UrlEncode(this.city, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.state != null)
			{
					sb.Append(prefix).Append("state").Append("=").Append(HttpUtility.UrlEncode(this.state, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.postalCode != null)
			{
					sb.Append(prefix).Append("postalCode").Append("=").Append(HttpUtility.UrlEncode(this.postalCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.countryCode != null)
			{
					sb.Append(prefix).Append("countryCode").Append("=").Append(HttpUtility.UrlEncode(this.countryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.type != null)
			{
					sb.Append(prefix).Append("type").Append("=").Append(HttpUtility.UrlEncode(this.type, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new BaseAddress object created from the passed in NVP map
	 	/// </returns>
		public static BaseAddress CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			BaseAddress baseAddress = null;
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
			key = prefix + "line1";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.line1 = map[key];
			}
			key = prefix + "line2";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.line2 = map[key];
			}
			key = prefix + "city";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.city = map[key];
			}
			key = prefix + "state";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.state = map[key];
			}
			key = prefix + "postalCode";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.postalCode = map[key];
			}
			key = prefix + "countryCode";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.countryCode = map[key];
			}
			key = prefix + "type";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.type = map[key];
			}
			return baseAddress;
		}
	}




	/// <summary>
	/// This type contains the detailed error information resulting
	/// from the service operation. 
    /// </summary>
	public partial class ErrorData	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public ErrorData()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new ErrorData object created from the passed in NVP map
	 	/// </returns>
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




	/// <summary>
	/// 
    /// </summary>
	public partial class ErrorParameter	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public ErrorParameter()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new ErrorParameter object created from the passed in NVP map
	 	/// </returns>
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




	/// <summary>
	/// This specifies a fault, encapsulating error data, with
	/// specific error codes. 
    /// </summary>
	public partial class FaultMessage	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public FaultMessage()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new FaultMessage object created from the passed in NVP map
	 	/// </returns>
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




	/// <summary>
	/// This specifies the list of parameters with every request to
	/// the service. 
    /// </summary>
	public partial class RequestEnvelope	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private DetailLevelCode? detailLevelField;
		public DetailLevelCode? detailLevel
		{
			get
			{
				return this.detailLevelField;
			}
			set
			{
				this.detailLevelField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public RequestEnvelope(string errorLanguage)
	 	{
			this.errorLanguage = errorLanguage;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public RequestEnvelope()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.detailLevel != null)
			{
					sb.Append(prefix).Append("detailLevel").Append("=").Append(EnumUtils.GetDescription(this.detailLevel));
					sb.Append("&");
			}
			if (this.errorLanguage != null)
			{
					sb.Append(prefix).Append("errorLanguage").Append("=").Append(HttpUtility.UrlEncode(this.errorLanguage, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// This specifies a list of parameters with every response from
	/// a service. 
    /// </summary>
	public partial class ResponseEnvelope	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public ResponseEnvelope()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new ResponseEnvelope object created from the passed in NVP map
	 	/// </returns>
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




	/// <summary>
	/// AckCodeType This code identifies the
	///  acknowledgment code types that could be used to
	///  communicate the status of processing a (request)
	///  message to an application. This code would be
	///  used as part of a response message that contains
	///  an application level acknowledgment element.
	///  
	/// </summary>
    [Serializable]
	public enum AckCode {
		[Description("Success")]SUCCESS,	
		[Description("Failure")]FAILURE,	
		[Description("Warning")]WARNING,	
		[Description("SuccessWithWarning")]SUCCESSWITHWARNING,	
		[Description("FailureWithWarning")]FAILUREWITHWARNING	
	}




	/// <summary>
	/// DetailLevelCodeType
	///  
	/// </summary>
    [Serializable]
	public enum DetailLevelCode {
		[Description("ReturnAll")]RETURNALL	
	}




	/// <summary>
	/// 
	/// </summary>
    [Serializable]
	public enum ErrorCategory {
		[Description("System")]SYSTEM,	
		[Description("Application")]APPLICATION,	
		[Description("Request")]REQUEST	
	}




	/// <summary>
	/// 
	/// </summary>
    [Serializable]
	public enum ErrorSeverity {
		[Description("Error")]ERROR,	
		[Description("Warning")]WARNING	
	}




	/// <summary>
	/// Specifies the payment terms for this invoice.
	///  
	/// </summary>
    [Serializable]
	public enum PaymentTermsType {
		[Description("DueOnReceipt")]DUEONRECEIPT,	
		[Description("DueOnDateSpecified")]DUEONDATESPECIFIED,	
		[Description("Net10")]NET1,	
		[Description("Net15")]NET2,	
		[Description("Net30")]NET3,	
		[Description("Net45")]NET4	
	}




	/// <summary>
	/// Specifies the payment methods that can be used to mark an
	/// invoice as paid.
	///  
	/// </summary>
    [Serializable]
	public enum PaymentMethodsType {
		[Description("BankTransfer")]BANKTRANSFER,	
		[Description("Cash")]CASH,	
		[Description("Check")]CHECK,	
		[Description("CreditCard")]CREDITCARD,	
		[Description("DebitCard")]DEBITCARD,	
		[Description("Other")]OTHER,	
		[Description("PayPal")]PAYPAL,	
		[Description("WireTransfer")]WIRETRANSFER	
	}




	/// <summary>
	/// Specifies the invoice status.
	///  
	/// </summary>
    [Serializable]
	public enum StatusType {
		[Description("Draft")]DRAFT,	
		[Description("Sent")]SENT,	
		[Description("Paid")]PAID,	
		[Description("MarkedAsPaid")]MARKEDASPAID,	
		[Description("Canceled")]CANCELED,	
		[Description("Refunded")]REFUNDED,	
		[Description("PartiallyRefunded")]PARTIALLYREFUNDED,	
		[Description("MarkedAsRefunded")]MARKEDASREFUNDED	
	}




	/// <summary>
	/// Specifies the merchant or payer.
	///  
	/// </summary>
    [Serializable]
	public enum OriginType {
		[Description("Web")]WEB,	
		[Description("API")]API	
	}




	/// <summary>
	/// Specifies the merchant or payer.
	///  
	/// </summary>
    [Serializable]
	public enum ActorType {
		[Description("Merchant")]MERCHANT,	
		[Description("Payer")]PAYER	
	}




	/// <summary>
	/// Contact information for a company participating in the
	/// invoicing system. 
    /// </summary>
	public partial class BusinessInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string firstNameField;
		public string firstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string lastNameField;
		public string lastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string businessNameField;
		public string businessName
		{
			get
			{
				return this.businessNameField;
			}
			set
			{
				this.businessNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string phoneField;
		public string phone
		{
			get
			{
				return this.phoneField;
			}
			set
			{
				this.phoneField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string faxField;
		public string fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				this.faxField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string websiteField;
		public string website
		{
			get
			{
				return this.websiteField;
			}
			set
			{
				this.websiteField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string customValueField;
		public string customValue
		{
			get
			{
				return this.customValueField;
			}
			set
			{
				this.customValueField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private BaseAddress addressField;
		public BaseAddress address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public BusinessInfoType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.firstName != null)
			{
					sb.Append(prefix).Append("firstName").Append("=").Append(HttpUtility.UrlEncode(this.firstName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.lastName != null)
			{
					sb.Append(prefix).Append("lastName").Append("=").Append(HttpUtility.UrlEncode(this.lastName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.businessName != null)
			{
					sb.Append(prefix).Append("businessName").Append("=").Append(HttpUtility.UrlEncode(this.businessName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.phone != null)
			{
					sb.Append(prefix).Append("phone").Append("=").Append(HttpUtility.UrlEncode(this.phone, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.fax != null)
			{
					sb.Append(prefix).Append("fax").Append("=").Append(HttpUtility.UrlEncode(this.fax, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.website != null)
			{
					sb.Append(prefix).Append("website").Append("=").Append(HttpUtility.UrlEncode(this.website, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customValue != null)
			{
					sb.Append(prefix).Append("customValue").Append("=").Append(HttpUtility.UrlEncode(this.customValue, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.address != null)
			{
					string newPrefix = prefix + "address" + ".";
					sb.Append(this.addressField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new BusinessInfoType object created from the passed in NVP map
	 	/// </returns>
		public static BusinessInfoType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			BusinessInfoType businessInfoType = null;
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
			key = prefix + "firstName";
			if (map.ContainsKey(key))
			{
				businessInfoType = (businessInfoType == null) ? new BusinessInfoType() : businessInfoType;
				businessInfoType.firstName = map[key];
			}
			key = prefix + "lastName";
			if (map.ContainsKey(key))
			{
				businessInfoType = (businessInfoType == null) ? new BusinessInfoType() : businessInfoType;
				businessInfoType.lastName = map[key];
			}
			key = prefix + "businessName";
			if (map.ContainsKey(key))
			{
				businessInfoType = (businessInfoType == null) ? new BusinessInfoType() : businessInfoType;
				businessInfoType.businessName = map[key];
			}
			key = prefix + "phone";
			if (map.ContainsKey(key))
			{
				businessInfoType = (businessInfoType == null) ? new BusinessInfoType() : businessInfoType;
				businessInfoType.phone = map[key];
			}
			key = prefix + "fax";
			if (map.ContainsKey(key))
			{
				businessInfoType = (businessInfoType == null) ? new BusinessInfoType() : businessInfoType;
				businessInfoType.fax = map[key];
			}
			key = prefix + "website";
			if (map.ContainsKey(key))
			{
				businessInfoType = (businessInfoType == null) ? new BusinessInfoType() : businessInfoType;
				businessInfoType.website = map[key];
			}
			key = prefix + "customValue";
			if (map.ContainsKey(key))
			{
				businessInfoType = (businessInfoType == null) ? new BusinessInfoType() : businessInfoType;
				businessInfoType.customValue = map[key];
			}
			BaseAddress address =  BaseAddress.CreateInstance(map, prefix + "address", -1);
			if (address != null)
			{
				businessInfoType = (businessInfoType == null) ? new BusinessInfoType() : businessInfoType;
				businessInfoType.address = address;
			}
			return businessInfoType;
		}
	}




	/// <summary>
	/// Item information about a service or product listed in the
	/// invoice. 
    /// </summary>
	public partial class InvoiceItemType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string descriptionField;
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dateField;
		public string date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? quantityField;
		public decimal? quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? unitPriceField;
		public decimal? unitPrice
		{
			get
			{
				return this.unitPriceField;
			}
			set
			{
				this.unitPriceField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string taxNameField;
		public string taxName
		{
			get
			{
				return this.taxNameField;
			}
			set
			{
				this.taxNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? taxRateField;
		public decimal? taxRate
		{
			get
			{
				return this.taxRateField;
			}
			set
			{
				this.taxRateField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public InvoiceItemType(string name, decimal? quantity, decimal? unitPrice)
	 	{
			this.name = name;
			this.quantity = quantity;
			this.unitPrice = unitPrice;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public InvoiceItemType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.name != null)
			{
					sb.Append(prefix).Append("name").Append("=").Append(HttpUtility.UrlEncode(this.name, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.description != null)
			{
					sb.Append(prefix).Append("description").Append("=").Append(HttpUtility.UrlEncode(this.description, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.date != null)
			{
					sb.Append(prefix).Append("date").Append("=").Append(HttpUtility.UrlEncode(this.date, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.quantity != null)
			{
					sb.Append(prefix).Append("quantity").Append("=").Append(Convert.ToString(this.quantity, DefaultCulture)).Append("&");
			}
			if (this.unitPrice != null)
			{
					sb.Append(prefix).Append("unitPrice").Append("=").Append(Convert.ToString(this.unitPrice, DefaultCulture)).Append("&");
			}
			if (this.taxName != null)
			{
					sb.Append(prefix).Append("taxName").Append("=").Append(HttpUtility.UrlEncode(this.taxName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.taxRate != null)
			{
					sb.Append(prefix).Append("taxRate").Append("=").Append(Convert.ToString(this.taxRate, DefaultCulture)).Append("&");
			}
			return sb.ToString();
		}
		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new InvoiceItemType object created from the passed in NVP map
	 	/// </returns>
		public static InvoiceItemType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InvoiceItemType invoiceItemType = null;
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
				invoiceItemType = (invoiceItemType == null) ? new InvoiceItemType() : invoiceItemType;
				invoiceItemType.name = map[key];
			}
			key = prefix + "description";
			if (map.ContainsKey(key))
			{
				invoiceItemType = (invoiceItemType == null) ? new InvoiceItemType() : invoiceItemType;
				invoiceItemType.description = map[key];
			}
			key = prefix + "date";
			if (map.ContainsKey(key))
			{
				invoiceItemType = (invoiceItemType == null) ? new InvoiceItemType() : invoiceItemType;
				invoiceItemType.date = map[key];
			}
			key = prefix + "quantity";
			if (map.ContainsKey(key))
			{
				invoiceItemType = (invoiceItemType == null) ? new InvoiceItemType() : invoiceItemType;
				invoiceItemType.quantity = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "unitPrice";
			if (map.ContainsKey(key))
			{
				invoiceItemType = (invoiceItemType == null) ? new InvoiceItemType() : invoiceItemType;
				invoiceItemType.unitPrice = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "taxName";
			if (map.ContainsKey(key))
			{
				invoiceItemType = (invoiceItemType == null) ? new InvoiceItemType() : invoiceItemType;
				invoiceItemType.taxName = map[key];
			}
			key = prefix + "taxRate";
			if (map.ContainsKey(key))
			{
				invoiceItemType = (invoiceItemType == null) ? new InvoiceItemType() : invoiceItemType;
				invoiceItemType.taxRate = System.Convert.ToDecimal(map[key]);
			}
			return invoiceItemType;
		}
	}




	/// <summary>
	/// A list of invoice items. 
    /// </summary>
	public partial class InvoiceItemListType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private List<InvoiceItemType> itemField = new List<InvoiceItemType>();
		public List<InvoiceItemType> item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public InvoiceItemListType(List<InvoiceItemType> item)
	 	{
			this.item = item;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public InvoiceItemListType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.item.Count; i++)
			{
				if (this.item[i] != null)
				{
					string newPrefix = prefix + "item" + "(" + i + ").";
					sb.Append(this.item[i].ToNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new InvoiceItemListType object created from the passed in NVP map
	 	/// </returns>
		public static InvoiceItemListType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InvoiceItemListType invoiceItemListType = null;
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
				InvoiceItemType item =  InvoiceItemType.CreateInstance(map, prefix + "item", i);
				if (item != null)
				{
					invoiceItemListType = (invoiceItemListType == null) ? new InvoiceItemListType() : invoiceItemListType;
					invoiceItemListType.item.Add(item);
					i++;
				} 
				else
				{
					break;
				}
			}
			return invoiceItemListType;
		}
	}




	/// <summary>
	/// Invoice details about the merchant, payer, totals and terms.
	/// 
    /// </summary>
	public partial class InvoiceType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string merchantEmailField;
		public string merchantEmail
		{
			get
			{
				return this.merchantEmailField;
			}
			set
			{
				this.merchantEmailField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string payerEmailField;
		public string payerEmail
		{
			get
			{
				return this.payerEmailField;
			}
			set
			{
				this.payerEmailField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string numberField;
		public string number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.numberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private BusinessInfoType merchantInfoField;
		public BusinessInfoType merchantInfo
		{
			get
			{
				return this.merchantInfoField;
			}
			set
			{
				this.merchantInfoField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private InvoiceItemListType itemListField;
		public InvoiceItemListType itemList
		{
			get
			{
				return this.itemListField;
			}
			set
			{
				this.itemListField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceDateField;
		public string invoiceDate
		{
			get
			{
				return this.invoiceDateField;
			}
			set
			{
				this.invoiceDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dueDateField;
		public string dueDate
		{
			get
			{
				return this.dueDateField;
			}
			set
			{
				this.dueDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private PaymentTermsType? paymentTermsField;
		public PaymentTermsType? paymentTerms
		{
			get
			{
				return this.paymentTermsField;
			}
			set
			{
				this.paymentTermsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? discountPercentField;
		public decimal? discountPercent
		{
			get
			{
				return this.discountPercentField;
			}
			set
			{
				this.discountPercentField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? discountAmountField;
		public decimal? discountAmount
		{
			get
			{
				return this.discountAmountField;
			}
			set
			{
				this.discountAmountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string termsField;
		public string terms
		{
			get
			{
				return this.termsField;
			}
			set
			{
				this.termsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string noteField;
		public string note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string merchantMemoField;
		public string merchantMemo
		{
			get
			{
				return this.merchantMemoField;
			}
			set
			{
				this.merchantMemoField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private BusinessInfoType billingInfoField;
		public BusinessInfoType billingInfo
		{
			get
			{
				return this.billingInfoField;
			}
			set
			{
				this.billingInfoField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private BusinessInfoType shippingInfoField;
		public BusinessInfoType shippingInfo
		{
			get
			{
				return this.shippingInfoField;
			}
			set
			{
				this.shippingInfoField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? shippingAmountField;
		public decimal? shippingAmount
		{
			get
			{
				return this.shippingAmountField;
			}
			set
			{
				this.shippingAmountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string shippingTaxNameField;
		public string shippingTaxName
		{
			get
			{
				return this.shippingTaxNameField;
			}
			set
			{
				this.shippingTaxNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? shippingTaxRateField;
		public decimal? shippingTaxRate
		{
			get
			{
				return this.shippingTaxRateField;
			}
			set
			{
				this.shippingTaxRateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string logoUrlField;
		public string logoUrl
		{
			get
			{
				return this.logoUrlField;
			}
			set
			{
				this.logoUrlField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string referrerCodeField;
		public string referrerCode
		{
			get
			{
				return this.referrerCodeField;
			}
			set
			{
				this.referrerCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string customAmountLabelField;
		public string customAmountLabel
		{
			get
			{
				return this.customAmountLabelField;
			}
			set
			{
				this.customAmountLabelField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? customAmountValueField;
		public decimal? customAmountValue
		{
			get
			{
				return this.customAmountValueField;
			}
			set
			{
				this.customAmountValueField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public InvoiceType(string merchantEmail, string payerEmail, InvoiceItemListType itemList, string currencyCode, PaymentTermsType? paymentTerms)
	 	{
			this.merchantEmail = merchantEmail;
			this.payerEmail = payerEmail;
			this.itemList = itemList;
			this.currencyCode = currencyCode;
			this.paymentTerms = paymentTerms;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public InvoiceType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.merchantEmail != null)
			{
					sb.Append(prefix).Append("merchantEmail").Append("=").Append(HttpUtility.UrlEncode(this.merchantEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.payerEmail != null)
			{
					sb.Append(prefix).Append("payerEmail").Append("=").Append(HttpUtility.UrlEncode(this.payerEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.number != null)
			{
					sb.Append(prefix).Append("number").Append("=").Append(HttpUtility.UrlEncode(this.number, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.merchantInfo != null)
			{
					string newPrefix = prefix + "merchantInfo" + ".";
					sb.Append(this.merchantInfoField.ToNVPString(newPrefix));
			}
			if (this.itemList != null)
			{
					string newPrefix = prefix + "itemList" + ".";
					sb.Append(this.itemListField.ToNVPString(newPrefix));
			}
			if (this.currencyCode != null)
			{
					sb.Append(prefix).Append("currencyCode").Append("=").Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.invoiceDate != null)
			{
					sb.Append(prefix).Append("invoiceDate").Append("=").Append(HttpUtility.UrlEncode(this.invoiceDate, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.dueDate != null)
			{
					sb.Append(prefix).Append("dueDate").Append("=").Append(HttpUtility.UrlEncode(this.dueDate, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.paymentTerms != null)
			{
					sb.Append(prefix).Append("paymentTerms").Append("=").Append(EnumUtils.GetDescription(this.paymentTerms));
					sb.Append("&");
			}
			if (this.discountPercent != null)
			{
					sb.Append(prefix).Append("discountPercent").Append("=").Append(Convert.ToString(this.discountPercent, DefaultCulture)).Append("&");
			}
			if (this.discountAmount != null)
			{
					sb.Append(prefix).Append("discountAmount").Append("=").Append(Convert.ToString(this.discountAmount, DefaultCulture)).Append("&");
			}
			if (this.terms != null)
			{
					sb.Append(prefix).Append("terms").Append("=").Append(HttpUtility.UrlEncode(this.terms, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.note != null)
			{
					sb.Append(prefix).Append("note").Append("=").Append(HttpUtility.UrlEncode(this.note, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.merchantMemo != null)
			{
					sb.Append(prefix).Append("merchantMemo").Append("=").Append(HttpUtility.UrlEncode(this.merchantMemo, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.billingInfo != null)
			{
					string newPrefix = prefix + "billingInfo" + ".";
					sb.Append(this.billingInfoField.ToNVPString(newPrefix));
			}
			if (this.shippingInfo != null)
			{
					string newPrefix = prefix + "shippingInfo" + ".";
					sb.Append(this.shippingInfoField.ToNVPString(newPrefix));
			}
			if (this.shippingAmount != null)
			{
					sb.Append(prefix).Append("shippingAmount").Append("=").Append(Convert.ToString(this.shippingAmount, DefaultCulture)).Append("&");
			}
			if (this.shippingTaxName != null)
			{
					sb.Append(prefix).Append("shippingTaxName").Append("=").Append(HttpUtility.UrlEncode(this.shippingTaxName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.shippingTaxRate != null)
			{
					sb.Append(prefix).Append("shippingTaxRate").Append("=").Append(Convert.ToString(this.shippingTaxRate, DefaultCulture)).Append("&");
			}
			if (this.logoUrl != null)
			{
					sb.Append(prefix).Append("logoUrl").Append("=").Append(HttpUtility.UrlEncode(this.logoUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.referrerCode != null)
			{
					sb.Append(prefix).Append("referrerCode").Append("=").Append(HttpUtility.UrlEncode(this.referrerCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customAmountLabel != null)
			{
					sb.Append(prefix).Append("customAmountLabel").Append("=").Append(HttpUtility.UrlEncode(this.customAmountLabel, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customAmountValue != null)
			{
					sb.Append(prefix).Append("customAmountValue").Append("=").Append(Convert.ToString(this.customAmountValue, DefaultCulture)).Append("&");
			}
			return sb.ToString();
		}
		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new InvoiceType object created from the passed in NVP map
	 	/// </returns>
		public static InvoiceType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InvoiceType invoiceType = null;
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
			key = prefix + "merchantEmail";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.merchantEmail = map[key];
			}
			key = prefix + "payerEmail";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.payerEmail = map[key];
			}
			key = prefix + "number";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.number = map[key];
			}
			BusinessInfoType merchantInfo =  BusinessInfoType.CreateInstance(map, prefix + "merchantInfo", -1);
			if (merchantInfo != null)
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.merchantInfo = merchantInfo;
			}
			InvoiceItemListType itemList =  InvoiceItemListType.CreateInstance(map, prefix + "itemList", -1);
			if (itemList != null)
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.itemList = itemList;
			}
			key = prefix + "currencyCode";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.currencyCode = map[key];
			}
			key = prefix + "invoiceDate";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.invoiceDate = map[key];
			}
			key = prefix + "dueDate";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.dueDate = map[key];
			}
			key = prefix + "paymentTerms";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.paymentTerms = (PaymentTermsType)EnumUtils.GetValue(map[key],typeof(PaymentTermsType));
			}
			key = prefix + "discountPercent";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.discountPercent = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "discountAmount";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.discountAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "terms";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.terms = map[key];
			}
			key = prefix + "note";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.note = map[key];
			}
			key = prefix + "merchantMemo";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.merchantMemo = map[key];
			}
			BusinessInfoType billingInfo =  BusinessInfoType.CreateInstance(map, prefix + "billingInfo", -1);
			if (billingInfo != null)
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.billingInfo = billingInfo;
			}
			BusinessInfoType shippingInfo =  BusinessInfoType.CreateInstance(map, prefix + "shippingInfo", -1);
			if (shippingInfo != null)
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.shippingInfo = shippingInfo;
			}
			key = prefix + "shippingAmount";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.shippingAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "shippingTaxName";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.shippingTaxName = map[key];
			}
			key = prefix + "shippingTaxRate";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.shippingTaxRate = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "logoUrl";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.logoUrl = map[key];
			}
			key = prefix + "referrerCode";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.referrerCode = map[key];
			}
			key = prefix + "customAmountLabel";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.customAmountLabel = map[key];
			}
			key = prefix + "customAmountValue";
			if (map.ContainsKey(key))
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.customAmountValue = System.Convert.ToDecimal(map[key]);
			}
			return invoiceType;
		}
	}




	/// <summary>
	/// Invoice details about the invoice status and state change
	/// dates. 
    /// </summary>
	public partial class InvoiceDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private StatusType? statusField;
		public StatusType? status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? totalAmountField;
		public decimal? totalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.totalAmountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private OriginType? originField;
		public OriginType? origin
		{
			get
			{
				return this.originField;
			}
			set
			{
				this.originField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string createdDateField;
		public string createdDate
		{
			get
			{
				return this.createdDateField;
			}
			set
			{
				this.createdDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string createdByField;
		public string createdBy
		{
			get
			{
				return this.createdByField;
			}
			set
			{
				this.createdByField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string canceledDateField;
		public string canceledDate
		{
			get
			{
				return this.canceledDateField;
			}
			set
			{
				this.canceledDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private ActorType? canceledByActorField;
		public ActorType? canceledByActor
		{
			get
			{
				return this.canceledByActorField;
			}
			set
			{
				this.canceledByActorField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string canceledByField;
		public string canceledBy
		{
			get
			{
				return this.canceledByField;
			}
			set
			{
				this.canceledByField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string lastUpdatedDateField;
		public string lastUpdatedDate
		{
			get
			{
				return this.lastUpdatedDateField;
			}
			set
			{
				this.lastUpdatedDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string lastUpdatedByField;
		public string lastUpdatedBy
		{
			get
			{
				return this.lastUpdatedByField;
			}
			set
			{
				this.lastUpdatedByField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string firstSentDateField;
		public string firstSentDate
		{
			get
			{
				return this.firstSentDateField;
			}
			set
			{
				this.firstSentDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string lastSentDateField;
		public string lastSentDate
		{
			get
			{
				return this.lastSentDateField;
			}
			set
			{
				this.lastSentDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string lastSentByField;
		public string lastSentBy
		{
			get
			{
				return this.lastSentByField;
			}
			set
			{
				this.lastSentByField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string paidDateField;
		public string paidDate
		{
			get
			{
				return this.paidDateField;
			}
			set
			{
				this.paidDateField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public InvoiceDetailsType()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new InvoiceDetailsType object created from the passed in NVP map
	 	/// </returns>
		public static InvoiceDetailsType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InvoiceDetailsType invoiceDetailsType = null;
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
			key = prefix + "status";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.status = (StatusType)EnumUtils.GetValue(map[key],typeof(StatusType));
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.totalAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "origin";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.origin = (OriginType)EnumUtils.GetValue(map[key],typeof(OriginType));
			}
			key = prefix + "createdDate";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.createdDate = map[key];
			}
			key = prefix + "createdBy";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.createdBy = map[key];
			}
			key = prefix + "canceledDate";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.canceledDate = map[key];
			}
			key = prefix + "canceledByActor";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.canceledByActor = (ActorType)EnumUtils.GetValue(map[key],typeof(ActorType));
			}
			key = prefix + "canceledBy";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.canceledBy = map[key];
			}
			key = prefix + "lastUpdatedDate";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.lastUpdatedDate = map[key];
			}
			key = prefix + "lastUpdatedBy";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.lastUpdatedBy = map[key];
			}
			key = prefix + "firstSentDate";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.firstSentDate = map[key];
			}
			key = prefix + "lastSentDate";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.lastSentDate = map[key];
			}
			key = prefix + "lastSentBy";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.lastSentBy = map[key];
			}
			key = prefix + "paidDate";
			if (map.ContainsKey(key))
			{
				invoiceDetailsType = (invoiceDetailsType == null) ? new InvoiceDetailsType() : invoiceDetailsType;
				invoiceDetailsType.paidDate = map[key];
			}
			return invoiceDetailsType;
		}
	}




	/// <summary>
	/// Details of the refund made against this invoice. 
    /// </summary>
	public partial class OtherPaymentRefundDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string noteField;
		public string note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dateField;
		public string date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public OtherPaymentRefundDetailsType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.note != null)
			{
					sb.Append(prefix).Append("note").Append("=").Append(HttpUtility.UrlEncode(this.note, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.date != null)
			{
					sb.Append(prefix).Append("date").Append("=").Append(HttpUtility.UrlEncode(this.date, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new OtherPaymentRefundDetailsType object created from the passed in NVP map
	 	/// </returns>
		public static OtherPaymentRefundDetailsType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			OtherPaymentRefundDetailsType otherPaymentRefundDetailsType = null;
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
			key = prefix + "note";
			if (map.ContainsKey(key))
			{
				otherPaymentRefundDetailsType = (otherPaymentRefundDetailsType == null) ? new OtherPaymentRefundDetailsType() : otherPaymentRefundDetailsType;
				otherPaymentRefundDetailsType.note = map[key];
			}
			key = prefix + "date";
			if (map.ContainsKey(key))
			{
				otherPaymentRefundDetailsType = (otherPaymentRefundDetailsType == null) ? new OtherPaymentRefundDetailsType() : otherPaymentRefundDetailsType;
				otherPaymentRefundDetailsType.date = map[key];
			}
			return otherPaymentRefundDetailsType;
		}
	}




	/// <summary>
	/// Details of the paypal refund made against this invoice. 
    /// </summary>
	public partial class PayPalPaymentRefundDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string dateField;
		public string date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public PayPalPaymentRefundDetailsType()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new PayPalPaymentRefundDetailsType object created from the passed in NVP map
	 	/// </returns>
		public static PayPalPaymentRefundDetailsType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PayPalPaymentRefundDetailsType payPalPaymentRefundDetailsType = null;
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
			key = prefix + "date";
			if (map.ContainsKey(key))
			{
				payPalPaymentRefundDetailsType = (payPalPaymentRefundDetailsType == null) ? new PayPalPaymentRefundDetailsType() : payPalPaymentRefundDetailsType;
				payPalPaymentRefundDetailsType.date = map[key];
			}
			return payPalPaymentRefundDetailsType;
		}
	}




	/// <summary>
	/// PayPal payment details about the invoice. 
    /// </summary>
	public partial class PayPalPaymentDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string transactionIDField;
		public string transactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dateField;
		public string date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public PayPalPaymentDetailsType()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new PayPalPaymentDetailsType object created from the passed in NVP map
	 	/// </returns>
		public static PayPalPaymentDetailsType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PayPalPaymentDetailsType payPalPaymentDetailsType = null;
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
			key = prefix + "transactionID";
			if (map.ContainsKey(key))
			{
				payPalPaymentDetailsType = (payPalPaymentDetailsType == null) ? new PayPalPaymentDetailsType() : payPalPaymentDetailsType;
				payPalPaymentDetailsType.transactionID = map[key];
			}
			key = prefix + "date";
			if (map.ContainsKey(key))
			{
				payPalPaymentDetailsType = (payPalPaymentDetailsType == null) ? new PayPalPaymentDetailsType() : payPalPaymentDetailsType;
				payPalPaymentDetailsType.date = map[key];
			}
			return payPalPaymentDetailsType;
		}
	}




	/// <summary>
	/// Offline payment details about the invoice. 
    /// </summary>
	public partial class OtherPaymentDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private PaymentMethodsType? methodField;
		public PaymentMethodsType? method
		{
			get
			{
				return this.methodField;
			}
			set
			{
				this.methodField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string noteField;
		public string note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dateField;
		public string date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public OtherPaymentDetailsType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.method != null)
			{
					sb.Append(prefix).Append("method").Append("=").Append(EnumUtils.GetDescription(this.method));
					sb.Append("&");
			}
			if (this.note != null)
			{
					sb.Append(prefix).Append("note").Append("=").Append(HttpUtility.UrlEncode(this.note, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.date != null)
			{
					sb.Append(prefix).Append("date").Append("=").Append(HttpUtility.UrlEncode(this.date, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new OtherPaymentDetailsType object created from the passed in NVP map
	 	/// </returns>
		public static OtherPaymentDetailsType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			OtherPaymentDetailsType otherPaymentDetailsType = null;
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
			key = prefix + "method";
			if (map.ContainsKey(key))
			{
				otherPaymentDetailsType = (otherPaymentDetailsType == null) ? new OtherPaymentDetailsType() : otherPaymentDetailsType;
				otherPaymentDetailsType.method = (PaymentMethodsType)EnumUtils.GetValue(map[key],typeof(PaymentMethodsType));
			}
			key = prefix + "note";
			if (map.ContainsKey(key))
			{
				otherPaymentDetailsType = (otherPaymentDetailsType == null) ? new OtherPaymentDetailsType() : otherPaymentDetailsType;
				otherPaymentDetailsType.note = map[key];
			}
			key = prefix + "date";
			if (map.ContainsKey(key))
			{
				otherPaymentDetailsType = (otherPaymentDetailsType == null) ? new OtherPaymentDetailsType() : otherPaymentDetailsType;
				otherPaymentDetailsType.date = map[key];
			}
			return otherPaymentDetailsType;
		}
	}




	/// <summary>
	/// Payment details about the invoice. 
    /// </summary>
	public partial class PaymentDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private bool? viaPayPalField;
		public bool? viaPayPal
		{
			get
			{
				return this.viaPayPalField;
			}
			set
			{
				this.viaPayPalField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private PayPalPaymentDetailsType paypalPaymentField;
		public PayPalPaymentDetailsType paypalPayment
		{
			get
			{
				return this.paypalPaymentField;
			}
			set
			{
				this.paypalPaymentField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private OtherPaymentDetailsType otherPaymentField;
		public OtherPaymentDetailsType otherPayment
		{
			get
			{
				return this.otherPaymentField;
			}
			set
			{
				this.otherPaymentField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public PaymentDetailsType()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new PaymentDetailsType object created from the passed in NVP map
	 	/// </returns>
		public static PaymentDetailsType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PaymentDetailsType paymentDetailsType = null;
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
			key = prefix + "viaPayPal";
			if (map.ContainsKey(key))
			{
				paymentDetailsType = (paymentDetailsType == null) ? new PaymentDetailsType() : paymentDetailsType;
				paymentDetailsType.viaPayPal = System.Convert.ToBoolean(map[key]);
			}
			PayPalPaymentDetailsType paypalPayment =  PayPalPaymentDetailsType.CreateInstance(map, prefix + "paypalPayment", -1);
			if (paypalPayment != null)
			{
				paymentDetailsType = (paymentDetailsType == null) ? new PaymentDetailsType() : paymentDetailsType;
				paymentDetailsType.paypalPayment = paypalPayment;
			}
			OtherPaymentDetailsType otherPayment =  OtherPaymentDetailsType.CreateInstance(map, prefix + "otherPayment", -1);
			if (otherPayment != null)
			{
				paymentDetailsType = (paymentDetailsType == null) ? new PaymentDetailsType() : paymentDetailsType;
				paymentDetailsType.otherPayment = otherPayment;
			}
			return paymentDetailsType;
		}
	}




	/// <summary>
	/// Determines an inclusive date range. 
    /// </summary>
	public partial class DateRangeType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string startDateField;
		public string startDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string endDateField;
		public string endDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.endDateField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public DateRangeType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.startDate != null)
			{
					sb.Append(prefix).Append("startDate").Append("=").Append(HttpUtility.UrlEncode(this.startDate, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.endDate != null)
			{
					sb.Append(prefix).Append("endDate").Append("=").Append(HttpUtility.UrlEncode(this.endDate, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Search parameters criteria. 
    /// </summary>
	public partial class SearchParametersType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string emailField;
		public string email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string recipientNameField;
		public string recipientName
		{
			get
			{
				return this.recipientNameField;
			}
			set
			{
				this.recipientNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string businessNameField;
		public string businessName
		{
			get
			{
				return this.businessNameField;
			}
			set
			{
				this.businessNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceNumberField;
		public string invoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<StatusType?> statusField = new List<StatusType?>();
		public List<StatusType?> status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? lowerAmountField;
		public decimal? lowerAmount
		{
			get
			{
				return this.lowerAmountField;
			}
			set
			{
				this.lowerAmountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? upperAmountField;
		public decimal? upperAmount
		{
			get
			{
				return this.upperAmountField;
			}
			set
			{
				this.upperAmountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string memoField;
		public string memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private OriginType? originField;
		public OriginType? origin
		{
			get
			{
				return this.originField;
			}
			set
			{
				this.originField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private DateRangeType invoiceDateField;
		public DateRangeType invoiceDate
		{
			get
			{
				return this.invoiceDateField;
			}
			set
			{
				this.invoiceDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private DateRangeType dueDateField;
		public DateRangeType dueDate
		{
			get
			{
				return this.dueDateField;
			}
			set
			{
				this.dueDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private DateRangeType paymentDateField;
		public DateRangeType paymentDate
		{
			get
			{
				return this.paymentDateField;
			}
			set
			{
				this.paymentDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private DateRangeType creationDateField;
		public DateRangeType creationDate
		{
			get
			{
				return this.creationDateField;
			}
			set
			{
				this.creationDateField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public SearchParametersType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.email != null)
			{
					sb.Append(prefix).Append("email").Append("=").Append(HttpUtility.UrlEncode(this.email, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.recipientName != null)
			{
					sb.Append(prefix).Append("recipientName").Append("=").Append(HttpUtility.UrlEncode(this.recipientName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.businessName != null)
			{
					sb.Append(prefix).Append("businessName").Append("=").Append(HttpUtility.UrlEncode(this.businessName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.invoiceNumber != null)
			{
					sb.Append(prefix).Append("invoiceNumber").Append("=").Append(HttpUtility.UrlEncode(this.invoiceNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			for (int i = 0; i < this.status.Count; i++)
			{
				if (this.status[i] != null)
				{
					sb.Append(prefix).Append("status(").Append(i).Append(")=").Append(EnumUtils.GetDescription(this.status[i]));
					sb.Append("&");
				}
			}
			if (this.lowerAmount != null)
			{
					sb.Append(prefix).Append("lowerAmount").Append("=").Append(Convert.ToString(this.lowerAmount, DefaultCulture)).Append("&");
			}
			if (this.upperAmount != null)
			{
					sb.Append(prefix).Append("upperAmount").Append("=").Append(Convert.ToString(this.upperAmount, DefaultCulture)).Append("&");
			}
			if (this.currencyCode != null)
			{
					sb.Append(prefix).Append("currencyCode").Append("=").Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.memo != null)
			{
					sb.Append(prefix).Append("memo").Append("=").Append(HttpUtility.UrlEncode(this.memo, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.origin != null)
			{
					sb.Append(prefix).Append("origin").Append("=").Append(EnumUtils.GetDescription(this.origin));
					sb.Append("&");
			}
			if (this.invoiceDate != null)
			{
					string newPrefix = prefix + "invoiceDate" + ".";
					sb.Append(this.invoiceDateField.ToNVPString(newPrefix));
			}
			if (this.dueDate != null)
			{
					string newPrefix = prefix + "dueDate" + ".";
					sb.Append(this.dueDateField.ToNVPString(newPrefix));
			}
			if (this.paymentDate != null)
			{
					string newPrefix = prefix + "paymentDate" + ".";
					sb.Append(this.paymentDateField.ToNVPString(newPrefix));
			}
			if (this.creationDate != null)
			{
					string newPrefix = prefix + "creationDate" + ".";
					sb.Append(this.creationDateField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Summary of invoice information. 
    /// </summary>
	public partial class InvoiceSummaryType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string merchantEmailField;
		public string merchantEmail
		{
			get
			{
				return this.merchantEmailField;
			}
			set
			{
				this.merchantEmailField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string payerEmailField;
		public string payerEmail
		{
			get
			{
				return this.payerEmailField;
			}
			set
			{
				this.payerEmailField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string numberField;
		public string number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.numberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string billingBusinessNameField;
		public string billingBusinessName
		{
			get
			{
				return this.billingBusinessNameField;
			}
			set
			{
				this.billingBusinessNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string billingFirstNameField;
		public string billingFirstName
		{
			get
			{
				return this.billingFirstNameField;
			}
			set
			{
				this.billingFirstNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string billingLastNameField;
		public string billingLastName
		{
			get
			{
				return this.billingLastNameField;
			}
			set
			{
				this.billingLastNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string shippingBusinessNameField;
		public string shippingBusinessName
		{
			get
			{
				return this.shippingBusinessNameField;
			}
			set
			{
				this.shippingBusinessNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string shippingFirstNameField;
		public string shippingFirstName
		{
			get
			{
				return this.shippingFirstNameField;
			}
			set
			{
				this.shippingFirstNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string shippingLastNameField;
		public string shippingLastName
		{
			get
			{
				return this.shippingLastNameField;
			}
			set
			{
				this.shippingLastNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? totalAmountField;
		public decimal? totalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.totalAmountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceDateField;
		public string invoiceDate
		{
			get
			{
				return this.invoiceDateField;
			}
			set
			{
				this.invoiceDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dueDateField;
		public string dueDate
		{
			get
			{
				return this.dueDateField;
			}
			set
			{
				this.dueDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private StatusType? statusField;
		public StatusType? status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private OriginType? originField;
		public OriginType? origin
		{
			get
			{
				return this.originField;
			}
			set
			{
				this.originField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string referrerCodeField;
		public string referrerCode
		{
			get
			{
				return this.referrerCodeField;
			}
			set
			{
				this.referrerCodeField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public InvoiceSummaryType()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new InvoiceSummaryType object created from the passed in NVP map
	 	/// </returns>
		public static InvoiceSummaryType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InvoiceSummaryType invoiceSummaryType = null;
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
			key = prefix + "invoiceID";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.invoiceID = map[key];
			}
			key = prefix + "merchantEmail";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.merchantEmail = map[key];
			}
			key = prefix + "payerEmail";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.payerEmail = map[key];
			}
			key = prefix + "number";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.number = map[key];
			}
			key = prefix + "billingBusinessName";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.billingBusinessName = map[key];
			}
			key = prefix + "billingFirstName";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.billingFirstName = map[key];
			}
			key = prefix + "billingLastName";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.billingLastName = map[key];
			}
			key = prefix + "shippingBusinessName";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.shippingBusinessName = map[key];
			}
			key = prefix + "shippingFirstName";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.shippingFirstName = map[key];
			}
			key = prefix + "shippingLastName";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.shippingLastName = map[key];
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.totalAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "currencyCode";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.currencyCode = map[key];
			}
			key = prefix + "invoiceDate";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.invoiceDate = map[key];
			}
			key = prefix + "dueDate";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.dueDate = map[key];
			}
			key = prefix + "status";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.status = (StatusType)EnumUtils.GetValue(map[key],typeof(StatusType));
			}
			key = prefix + "origin";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.origin = (OriginType)EnumUtils.GetValue(map[key],typeof(OriginType));
			}
			key = prefix + "referrerCode";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.referrerCode = map[key];
			}
			return invoiceSummaryType;
		}
	}




	/// <summary>
	/// A list of invoice summaries. 
    /// </summary>
	public partial class InvoiceSummaryListType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private List<InvoiceSummaryType> invoiceField = new List<InvoiceSummaryType>();
		public List<InvoiceSummaryType> invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public InvoiceSummaryListType()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new InvoiceSummaryListType object created from the passed in NVP map
	 	/// </returns>
		public static InvoiceSummaryListType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InvoiceSummaryListType invoiceSummaryListType = null;
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
				InvoiceSummaryType invoice =  InvoiceSummaryType.CreateInstance(map, prefix + "invoice", i);
				if (invoice != null)
				{
					invoiceSummaryListType = (invoiceSummaryListType == null) ? new InvoiceSummaryListType() : invoiceSummaryListType;
					invoiceSummaryListType.invoice.Add(invoice);
					i++;
				} 
				else
				{
					break;
				}
			}
			return invoiceSummaryListType;
		}
	}




	/// <summary>
	/// The request object for CreateInvoice. 
    /// </summary>
	public partial class CreateInvoiceRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private InvoiceType invoiceField;
		public InvoiceType invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public CreateInvoiceRequest(RequestEnvelope requestEnvelope, InvoiceType invoice)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.invoice = invoice;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CreateInvoiceRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.invoice != null)
			{
					string newPrefix = prefix + "invoice" + ".";
					sb.Append(this.invoiceField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for CreateInvoice. 
    /// </summary>
	public partial class CreateInvoiceResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceNumberField;
		public string invoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceURLField;
		public string invoiceURL
		{
			get
			{
				return this.invoiceURLField;
			}
			set
			{
				this.invoiceURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? totalAmountField;
		public int? totalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.totalAmountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CreateInvoiceResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new CreateInvoiceResponse object created from the passed in NVP map
	 	/// </returns>
		public static CreateInvoiceResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CreateInvoiceResponse createInvoiceResponse = null;
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
				createInvoiceResponse = (createInvoiceResponse == null) ? new CreateInvoiceResponse() : createInvoiceResponse;
				createInvoiceResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key))
			{
				createInvoiceResponse = (createInvoiceResponse == null) ? new CreateInvoiceResponse() : createInvoiceResponse;
				createInvoiceResponse.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key))
			{
				createInvoiceResponse = (createInvoiceResponse == null) ? new CreateInvoiceResponse() : createInvoiceResponse;
				createInvoiceResponse.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key))
			{
				createInvoiceResponse = (createInvoiceResponse == null) ? new CreateInvoiceResponse() : createInvoiceResponse;
				createInvoiceResponse.invoiceURL = map[key];
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key))
			{
				createInvoiceResponse = (createInvoiceResponse == null) ? new CreateInvoiceResponse() : createInvoiceResponse;
				createInvoiceResponse.totalAmount = System.Convert.ToInt32(map[key]);
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					createInvoiceResponse = (createInvoiceResponse == null) ? new CreateInvoiceResponse() : createInvoiceResponse;
					createInvoiceResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return createInvoiceResponse;
		}
	}




	/// <summary>
	/// The request object for SendInvoice. 
    /// </summary>
	public partial class SendInvoiceRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public SendInvoiceRequest(RequestEnvelope requestEnvelope, string invoiceID)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public SendInvoiceRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for SendInvoice. 
    /// </summary>
	public partial class SendInvoiceResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceURLField;
		public string invoiceURL
		{
			get
			{
				return this.invoiceURLField;
			}
			set
			{
				this.invoiceURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public SendInvoiceResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new SendInvoiceResponse object created from the passed in NVP map
	 	/// </returns>
		public static SendInvoiceResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			SendInvoiceResponse sendInvoiceResponse = null;
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
				sendInvoiceResponse = (sendInvoiceResponse == null) ? new SendInvoiceResponse() : sendInvoiceResponse;
				sendInvoiceResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key))
			{
				sendInvoiceResponse = (sendInvoiceResponse == null) ? new SendInvoiceResponse() : sendInvoiceResponse;
				sendInvoiceResponse.invoiceID = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key))
			{
				sendInvoiceResponse = (sendInvoiceResponse == null) ? new SendInvoiceResponse() : sendInvoiceResponse;
				sendInvoiceResponse.invoiceURL = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					sendInvoiceResponse = (sendInvoiceResponse == null) ? new SendInvoiceResponse() : sendInvoiceResponse;
					sendInvoiceResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return sendInvoiceResponse;
		}
	}




	/// <summary>
	/// The request object for CreateAndSendInvoice. 
    /// </summary>
	public partial class CreateAndSendInvoiceRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private InvoiceType invoiceField;
		public InvoiceType invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public CreateAndSendInvoiceRequest(RequestEnvelope requestEnvelope, InvoiceType invoice)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.invoice = invoice;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CreateAndSendInvoiceRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.invoice != null)
			{
					string newPrefix = prefix + "invoice" + ".";
					sb.Append(this.invoiceField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for CreateAndSendInvoice. 
    /// </summary>
	public partial class CreateAndSendInvoiceResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceNumberField;
		public string invoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceURLField;
		public string invoiceURL
		{
			get
			{
				return this.invoiceURLField;
			}
			set
			{
				this.invoiceURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? totalAmountField;
		public int? totalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.totalAmountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CreateAndSendInvoiceResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new CreateAndSendInvoiceResponse object created from the passed in NVP map
	 	/// </returns>
		public static CreateAndSendInvoiceResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CreateAndSendInvoiceResponse createAndSendInvoiceResponse = null;
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
				createAndSendInvoiceResponse = (createAndSendInvoiceResponse == null) ? new CreateAndSendInvoiceResponse() : createAndSendInvoiceResponse;
				createAndSendInvoiceResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key))
			{
				createAndSendInvoiceResponse = (createAndSendInvoiceResponse == null) ? new CreateAndSendInvoiceResponse() : createAndSendInvoiceResponse;
				createAndSendInvoiceResponse.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key))
			{
				createAndSendInvoiceResponse = (createAndSendInvoiceResponse == null) ? new CreateAndSendInvoiceResponse() : createAndSendInvoiceResponse;
				createAndSendInvoiceResponse.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key))
			{
				createAndSendInvoiceResponse = (createAndSendInvoiceResponse == null) ? new CreateAndSendInvoiceResponse() : createAndSendInvoiceResponse;
				createAndSendInvoiceResponse.invoiceURL = map[key];
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key))
			{
				createAndSendInvoiceResponse = (createAndSendInvoiceResponse == null) ? new CreateAndSendInvoiceResponse() : createAndSendInvoiceResponse;
				createAndSendInvoiceResponse.totalAmount = System.Convert.ToInt32(map[key]);
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					createAndSendInvoiceResponse = (createAndSendInvoiceResponse == null) ? new CreateAndSendInvoiceResponse() : createAndSendInvoiceResponse;
					createAndSendInvoiceResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return createAndSendInvoiceResponse;
		}
	}




	/// <summary>
	/// The request object for UpdateInvoice. 
    /// </summary>
	public partial class UpdateInvoiceRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private InvoiceType invoiceField;
		public InvoiceType invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public UpdateInvoiceRequest(RequestEnvelope requestEnvelope, string invoiceID, InvoiceType invoice)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
			this.invoice = invoice;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public UpdateInvoiceRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.invoice != null)
			{
					string newPrefix = prefix + "invoice" + ".";
					sb.Append(this.invoiceField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for UpdateInvoice. 
    /// </summary>
	public partial class UpdateInvoiceResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceNumberField;
		public string invoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceURLField;
		public string invoiceURL
		{
			get
			{
				return this.invoiceURLField;
			}
			set
			{
				this.invoiceURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? totalAmountField;
		public int? totalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.totalAmountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public UpdateInvoiceResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new UpdateInvoiceResponse object created from the passed in NVP map
	 	/// </returns>
		public static UpdateInvoiceResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			UpdateInvoiceResponse updateInvoiceResponse = null;
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
				updateInvoiceResponse = (updateInvoiceResponse == null) ? new UpdateInvoiceResponse() : updateInvoiceResponse;
				updateInvoiceResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key))
			{
				updateInvoiceResponse = (updateInvoiceResponse == null) ? new UpdateInvoiceResponse() : updateInvoiceResponse;
				updateInvoiceResponse.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key))
			{
				updateInvoiceResponse = (updateInvoiceResponse == null) ? new UpdateInvoiceResponse() : updateInvoiceResponse;
				updateInvoiceResponse.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key))
			{
				updateInvoiceResponse = (updateInvoiceResponse == null) ? new UpdateInvoiceResponse() : updateInvoiceResponse;
				updateInvoiceResponse.invoiceURL = map[key];
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key))
			{
				updateInvoiceResponse = (updateInvoiceResponse == null) ? new UpdateInvoiceResponse() : updateInvoiceResponse;
				updateInvoiceResponse.totalAmount = System.Convert.ToInt32(map[key]);
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					updateInvoiceResponse = (updateInvoiceResponse == null) ? new UpdateInvoiceResponse() : updateInvoiceResponse;
					updateInvoiceResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return updateInvoiceResponse;
		}
	}




	/// <summary>
	/// The request object for GetInvoiceDetails. 
    /// </summary>
	public partial class GetInvoiceDetailsRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public GetInvoiceDetailsRequest(RequestEnvelope requestEnvelope, string invoiceID)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public GetInvoiceDetailsRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for CreateInvoice. 
    /// </summary>
	public partial class GetInvoiceDetailsResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private InvoiceType invoiceField;
		public InvoiceType invoice
		{
			get
			{
				return this.invoiceField;
			}
			set
			{
				this.invoiceField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private InvoiceDetailsType invoiceDetailsField;
		public InvoiceDetailsType invoiceDetails
		{
			get
			{
				return this.invoiceDetailsField;
			}
			set
			{
				this.invoiceDetailsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private PaymentDetailsType paymentDetailsField;
		public PaymentDetailsType paymentDetails
		{
			get
			{
				return this.paymentDetailsField;
			}
			set
			{
				this.paymentDetailsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private PaymentRefundDetailsType refundDetailsField;
		public PaymentRefundDetailsType refundDetails
		{
			get
			{
				return this.refundDetailsField;
			}
			set
			{
				this.refundDetailsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceURLField;
		public string invoiceURL
		{
			get
			{
				return this.invoiceURLField;
			}
			set
			{
				this.invoiceURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public GetInvoiceDetailsResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new GetInvoiceDetailsResponse object created from the passed in NVP map
	 	/// </returns>
		public static GetInvoiceDetailsResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetInvoiceDetailsResponse getInvoiceDetailsResponse = null;
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
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.responseEnvelope = responseEnvelope;
			}
			InvoiceType invoice =  InvoiceType.CreateInstance(map, prefix + "invoice", -1);
			if (invoice != null)
			{
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.invoice = invoice;
			}
			InvoiceDetailsType invoiceDetails =  InvoiceDetailsType.CreateInstance(map, prefix + "invoiceDetails", -1);
			if (invoiceDetails != null)
			{
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.invoiceDetails = invoiceDetails;
			}
			PaymentDetailsType paymentDetails =  PaymentDetailsType.CreateInstance(map, prefix + "paymentDetails", -1);
			if (paymentDetails != null)
			{
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.paymentDetails = paymentDetails;
			}
			PaymentRefundDetailsType refundDetails =  PaymentRefundDetailsType.CreateInstance(map, prefix + "refundDetails", -1);
			if (refundDetails != null)
			{
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.refundDetails = refundDetails;
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key))
			{
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.invoiceURL = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
					getInvoiceDetailsResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getInvoiceDetailsResponse;
		}
	}




	/// <summary>
	/// The request object for CancelInvoice. 
    /// </summary>
	public partial class CancelInvoiceRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string subjectField;
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string noteForPayerField;
		public string noteForPayer
		{
			get
			{
				return this.noteForPayerField;
			}
			set
			{
				this.noteForPayerField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private bool? sendCopyToMerchantField;
		public bool? sendCopyToMerchant
		{
			get
			{
				return this.sendCopyToMerchantField;
			}
			set
			{
				this.sendCopyToMerchantField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public CancelInvoiceRequest(RequestEnvelope requestEnvelope)
	 	{
			this.requestEnvelope = requestEnvelope;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CancelInvoiceRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.subject != null)
			{
					sb.Append(prefix).Append("subject").Append("=").Append(HttpUtility.UrlEncode(this.subject, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.noteForPayer != null)
			{
					sb.Append(prefix).Append("noteForPayer").Append("=").Append(HttpUtility.UrlEncode(this.noteForPayer, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.sendCopyToMerchant != null)
			{
					sb.Append(prefix).Append("sendCopyToMerchant").Append("=").Append(this.sendCopyToMerchant.ToString().ToLower()).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for CancelInvoice. 
    /// </summary>
	public partial class CancelInvoiceResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceNumberField;
		public string invoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceURLField;
		public string invoiceURL
		{
			get
			{
				return this.invoiceURLField;
			}
			set
			{
				this.invoiceURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CancelInvoiceResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new CancelInvoiceResponse object created from the passed in NVP map
	 	/// </returns>
		public static CancelInvoiceResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CancelInvoiceResponse cancelInvoiceResponse = null;
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
				cancelInvoiceResponse = (cancelInvoiceResponse == null) ? new CancelInvoiceResponse() : cancelInvoiceResponse;
				cancelInvoiceResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key))
			{
				cancelInvoiceResponse = (cancelInvoiceResponse == null) ? new CancelInvoiceResponse() : cancelInvoiceResponse;
				cancelInvoiceResponse.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key))
			{
				cancelInvoiceResponse = (cancelInvoiceResponse == null) ? new CancelInvoiceResponse() : cancelInvoiceResponse;
				cancelInvoiceResponse.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key))
			{
				cancelInvoiceResponse = (cancelInvoiceResponse == null) ? new CancelInvoiceResponse() : cancelInvoiceResponse;
				cancelInvoiceResponse.invoiceURL = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					cancelInvoiceResponse = (cancelInvoiceResponse == null) ? new CancelInvoiceResponse() : cancelInvoiceResponse;
					cancelInvoiceResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return cancelInvoiceResponse;
		}
	}




	/// <summary>
	/// The request object for SearchInvoices. 
    /// </summary>
	public partial class SearchInvoicesRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string merchantEmailField;
		public string merchantEmail
		{
			get
			{
				return this.merchantEmailField;
			}
			set
			{
				this.merchantEmailField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private SearchParametersType parametersField;
		public SearchParametersType parameters
		{
			get
			{
				return this.parametersField;
			}
			set
			{
				this.parametersField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? pageField;
		public int? page
		{
			get
			{
				return this.pageField;
			}
			set
			{
				this.pageField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? pageSizeField;
		public int? pageSize
		{
			get
			{
				return this.pageSizeField;
			}
			set
			{
				this.pageSizeField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public SearchInvoicesRequest(RequestEnvelope requestEnvelope, string merchantEmail, SearchParametersType parameters, int? page, int? pageSize)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.merchantEmail = merchantEmail;
			this.parameters = parameters;
			this.page = page;
			this.pageSize = pageSize;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public SearchInvoicesRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.merchantEmail != null)
			{
					sb.Append(prefix).Append("merchantEmail").Append("=").Append(HttpUtility.UrlEncode(this.merchantEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.parameters != null)
			{
					string newPrefix = prefix + "parameters" + ".";
					sb.Append(this.parametersField.ToNVPString(newPrefix));
			}
			if (this.page != null)
			{
					sb.Append(prefix).Append("page").Append("=").Append(this.page).Append("&");
			}
			if (this.pageSize != null)
			{
					sb.Append(prefix).Append("pageSize").Append("=").Append(this.pageSize).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for SearchInvoices. 
    /// </summary>
	public partial class SearchInvoicesResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private int? countField;
		public int? count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private InvoiceSummaryListType invoiceListField;
		public InvoiceSummaryListType invoiceList
		{
			get
			{
				return this.invoiceListField;
			}
			set
			{
				this.invoiceListField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? pageField;
		public int? page
		{
			get
			{
				return this.pageField;
			}
			set
			{
				this.pageField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private bool? hasNextPageField;
		public bool? hasNextPage
		{
			get
			{
				return this.hasNextPageField;
			}
			set
			{
				this.hasNextPageField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private bool? hasPreviousPageField;
		public bool? hasPreviousPage
		{
			get
			{
				return this.hasPreviousPageField;
			}
			set
			{
				this.hasPreviousPageField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public SearchInvoicesResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new SearchInvoicesResponse object created from the passed in NVP map
	 	/// </returns>
		public static SearchInvoicesResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			SearchInvoicesResponse searchInvoicesResponse = null;
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
				searchInvoicesResponse = (searchInvoicesResponse == null) ? new SearchInvoicesResponse() : searchInvoicesResponse;
				searchInvoicesResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "count";
			if (map.ContainsKey(key))
			{
				searchInvoicesResponse = (searchInvoicesResponse == null) ? new SearchInvoicesResponse() : searchInvoicesResponse;
				searchInvoicesResponse.count = System.Convert.ToInt32(map[key]);
			}
			InvoiceSummaryListType invoiceList =  InvoiceSummaryListType.CreateInstance(map, prefix + "invoiceList", -1);
			if (invoiceList != null)
			{
				searchInvoicesResponse = (searchInvoicesResponse == null) ? new SearchInvoicesResponse() : searchInvoicesResponse;
				searchInvoicesResponse.invoiceList = invoiceList;
			}
			key = prefix + "page";
			if (map.ContainsKey(key))
			{
				searchInvoicesResponse = (searchInvoicesResponse == null) ? new SearchInvoicesResponse() : searchInvoicesResponse;
				searchInvoicesResponse.page = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "hasNextPage";
			if (map.ContainsKey(key))
			{
				searchInvoicesResponse = (searchInvoicesResponse == null) ? new SearchInvoicesResponse() : searchInvoicesResponse;
				searchInvoicesResponse.hasNextPage = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "hasPreviousPage";
			if (map.ContainsKey(key))
			{
				searchInvoicesResponse = (searchInvoicesResponse == null) ? new SearchInvoicesResponse() : searchInvoicesResponse;
				searchInvoicesResponse.hasPreviousPage = System.Convert.ToBoolean(map[key]);
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					searchInvoicesResponse = (searchInvoicesResponse == null) ? new SearchInvoicesResponse() : searchInvoicesResponse;
					searchInvoicesResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return searchInvoicesResponse;
		}
	}




	/// <summary>
	/// The request object for MarkInvoiceAsPaid. 
    /// </summary>
	public partial class MarkInvoiceAsPaidRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private OtherPaymentDetailsType paymentField;
		public OtherPaymentDetailsType payment
		{
			get
			{
				return this.paymentField;
			}
			set
			{
				this.paymentField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public MarkInvoiceAsPaidRequest(RequestEnvelope requestEnvelope, string invoiceID, OtherPaymentDetailsType payment)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
			this.payment = payment;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public MarkInvoiceAsPaidRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.payment != null)
			{
					string newPrefix = prefix + "payment" + ".";
					sb.Append(this.paymentField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for MarkInvoiceAsPaid. 
    /// </summary>
	public partial class MarkInvoiceAsPaidResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceNumberField;
		public string invoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceURLField;
		public string invoiceURL
		{
			get
			{
				return this.invoiceURLField;
			}
			set
			{
				this.invoiceURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public MarkInvoiceAsPaidResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new MarkInvoiceAsPaidResponse object created from the passed in NVP map
	 	/// </returns>
		public static MarkInvoiceAsPaidResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			MarkInvoiceAsPaidResponse markInvoiceAsPaidResponse = null;
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
				markInvoiceAsPaidResponse = (markInvoiceAsPaidResponse == null) ? new MarkInvoiceAsPaidResponse() : markInvoiceAsPaidResponse;
				markInvoiceAsPaidResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key))
			{
				markInvoiceAsPaidResponse = (markInvoiceAsPaidResponse == null) ? new MarkInvoiceAsPaidResponse() : markInvoiceAsPaidResponse;
				markInvoiceAsPaidResponse.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key))
			{
				markInvoiceAsPaidResponse = (markInvoiceAsPaidResponse == null) ? new MarkInvoiceAsPaidResponse() : markInvoiceAsPaidResponse;
				markInvoiceAsPaidResponse.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key))
			{
				markInvoiceAsPaidResponse = (markInvoiceAsPaidResponse == null) ? new MarkInvoiceAsPaidResponse() : markInvoiceAsPaidResponse;
				markInvoiceAsPaidResponse.invoiceURL = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					markInvoiceAsPaidResponse = (markInvoiceAsPaidResponse == null) ? new MarkInvoiceAsPaidResponse() : markInvoiceAsPaidResponse;
					markInvoiceAsPaidResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return markInvoiceAsPaidResponse;
		}
	}




	/// <summary>
	/// The request object for MarkInvoiceAsRefunded. 
    /// </summary>
	public partial class MarkInvoiceAsRefundedRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private OtherPaymentRefundDetailsType refundDetailField;
		public OtherPaymentRefundDetailsType refundDetail
		{
			get
			{
				return this.refundDetailField;
			}
			set
			{
				this.refundDetailField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public MarkInvoiceAsRefundedRequest(RequestEnvelope requestEnvelope, string invoiceID, OtherPaymentRefundDetailsType refundDetail)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
			this.refundDetail = refundDetail;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public MarkInvoiceAsRefundedRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.refundDetail != null)
			{
					string newPrefix = prefix + "refundDetail" + ".";
					sb.Append(this.refundDetailField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for MarkInvoiceAsRefunded. 
    /// </summary>
	public partial class MarkInvoiceAsRefundedResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceNumberField;
		public string invoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceURLField;
		public string invoiceURL
		{
			get
			{
				return this.invoiceURLField;
			}
			set
			{
				this.invoiceURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public MarkInvoiceAsRefundedResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new MarkInvoiceAsRefundedResponse object created from the passed in NVP map
	 	/// </returns>
		public static MarkInvoiceAsRefundedResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			MarkInvoiceAsRefundedResponse markInvoiceAsRefundedResponse = null;
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
				markInvoiceAsRefundedResponse = (markInvoiceAsRefundedResponse == null) ? new MarkInvoiceAsRefundedResponse() : markInvoiceAsRefundedResponse;
				markInvoiceAsRefundedResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key))
			{
				markInvoiceAsRefundedResponse = (markInvoiceAsRefundedResponse == null) ? new MarkInvoiceAsRefundedResponse() : markInvoiceAsRefundedResponse;
				markInvoiceAsRefundedResponse.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key))
			{
				markInvoiceAsRefundedResponse = (markInvoiceAsRefundedResponse == null) ? new MarkInvoiceAsRefundedResponse() : markInvoiceAsRefundedResponse;
				markInvoiceAsRefundedResponse.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key))
			{
				markInvoiceAsRefundedResponse = (markInvoiceAsRefundedResponse == null) ? new MarkInvoiceAsRefundedResponse() : markInvoiceAsRefundedResponse;
				markInvoiceAsRefundedResponse.invoiceURL = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					markInvoiceAsRefundedResponse = (markInvoiceAsRefundedResponse == null) ? new MarkInvoiceAsRefundedResponse() : markInvoiceAsRefundedResponse;
					markInvoiceAsRefundedResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return markInvoiceAsRefundedResponse;
		}
	}




	/// <summary>
	/// The request object for MarkInvoiceAsUnpaid. 
    /// </summary>
	public partial class MarkInvoiceAsUnpaidRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public MarkInvoiceAsUnpaidRequest(RequestEnvelope requestEnvelope, string invoiceID)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public MarkInvoiceAsUnpaidRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// The response object for MarkInvoiceAsUnpaid. 
    /// </summary>
	public partial class MarkInvoiceAsUnpaidResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceIDField;
		public string invoiceID
		{
			get
			{
				return this.invoiceIDField;
			}
			set
			{
				this.invoiceIDField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceNumberField;
		public string invoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string invoiceURLField;
		public string invoiceURL
		{
			get
			{
				return this.invoiceURLField;
			}
			set
			{
				this.invoiceURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
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
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public MarkInvoiceAsUnpaidResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new MarkInvoiceAsUnpaidResponse object created from the passed in NVP map
	 	/// </returns>
		public static MarkInvoiceAsUnpaidResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			MarkInvoiceAsUnpaidResponse markInvoiceAsUnpaidResponse = null;
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
				markInvoiceAsUnpaidResponse = (markInvoiceAsUnpaidResponse == null) ? new MarkInvoiceAsUnpaidResponse() : markInvoiceAsUnpaidResponse;
				markInvoiceAsUnpaidResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key))
			{
				markInvoiceAsUnpaidResponse = (markInvoiceAsUnpaidResponse == null) ? new MarkInvoiceAsUnpaidResponse() : markInvoiceAsUnpaidResponse;
				markInvoiceAsUnpaidResponse.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key))
			{
				markInvoiceAsUnpaidResponse = (markInvoiceAsUnpaidResponse == null) ? new MarkInvoiceAsUnpaidResponse() : markInvoiceAsUnpaidResponse;
				markInvoiceAsUnpaidResponse.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key))
			{
				markInvoiceAsUnpaidResponse = (markInvoiceAsUnpaidResponse == null) ? new MarkInvoiceAsUnpaidResponse() : markInvoiceAsUnpaidResponse;
				markInvoiceAsUnpaidResponse.invoiceURL = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					markInvoiceAsUnpaidResponse = (markInvoiceAsUnpaidResponse == null) ? new MarkInvoiceAsUnpaidResponse() : markInvoiceAsUnpaidResponse;
					markInvoiceAsUnpaidResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return markInvoiceAsUnpaidResponse;
		}
	}




	/// <summary>
	/// Payment refund details about the invoice.  
    /// </summary>
	public partial class PaymentRefundDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private bool? viaPayPalField;
		public bool? viaPayPal
		{
			get
			{
				return this.viaPayPalField;
			}
			set
			{
				this.viaPayPalField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private PayPalPaymentRefundDetailsType paypalPaymentField;
		public PayPalPaymentRefundDetailsType paypalPayment
		{
			get
			{
				return this.paypalPaymentField;
			}
			set
			{
				this.paypalPaymentField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private OtherPaymentRefundDetailsType otherPaymentField;
		public OtherPaymentRefundDetailsType otherPayment
		{
			get
			{
				return this.otherPaymentField;
			}
			set
			{
				this.otherPaymentField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public PaymentRefundDetailsType()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new PaymentRefundDetailsType object created from the passed in NVP map
	 	/// </returns>
		public static PaymentRefundDetailsType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PaymentRefundDetailsType paymentRefundDetailsType = null;
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
			key = prefix + "viaPayPal";
			if (map.ContainsKey(key))
			{
				paymentRefundDetailsType = (paymentRefundDetailsType == null) ? new PaymentRefundDetailsType() : paymentRefundDetailsType;
				paymentRefundDetailsType.viaPayPal = System.Convert.ToBoolean(map[key]);
			}
			PayPalPaymentRefundDetailsType paypalPayment =  PayPalPaymentRefundDetailsType.CreateInstance(map, prefix + "paypalPayment", -1);
			if (paypalPayment != null)
			{
				paymentRefundDetailsType = (paymentRefundDetailsType == null) ? new PaymentRefundDetailsType() : paymentRefundDetailsType;
				paymentRefundDetailsType.paypalPayment = paypalPayment;
			}
			OtherPaymentRefundDetailsType otherPayment =  OtherPaymentRefundDetailsType.CreateInstance(map, prefix + "otherPayment", -1);
			if (otherPayment != null)
			{
				paymentRefundDetailsType = (paymentRefundDetailsType == null) ? new PaymentRefundDetailsType() : paymentRefundDetailsType;
				paymentRefundDetailsType.otherPayment = otherPayment;
			}
			return paymentRefundDetailsType;
		}
	}





}