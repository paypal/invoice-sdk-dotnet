/**
  * Stub objects for Invoice 
  * AUTO_GENERATED_CODE 
  */
using System;
using System.Text;
using System.Web;
using System.Xml;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using PayPal.Util;

namespace PayPal.Invoice.Model
{

	public class EnumUtils
	{
		public static string getDescription(Enum value)
		{
			string description = "";
			DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
			{
				description= attributes[0].Description;
			}
			return description;
		}
		
		public static object getValue(String value,Type enumType)
		{
			string[] names = Enum.GetNames(enumType);
			foreach(string name in names)
            {
            	if (getDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
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
	public partial class BaseAddress	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BaseAddress(string line1, string city, string countryCode){
			this.line1 = line1;
			this.city = city;
			this.countryCode = countryCode;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BaseAddress(){
		}


		public string toNVPString(string prefix)
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

		public static BaseAddress createInstance(Dictionary<string, string> map, string prefix, int index)
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




	/**
      *This type contains the detailed error information resulting
      *from the service operation. 
      */
	public partial class ErrorData	
	{

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



		public static ErrorData createInstance(Dictionary<string, string> map, string prefix, int index)
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
				errorData.severity = (ErrorSeverity)EnumUtils.getValue(map[key],typeof(ErrorSeverity));;
			}
			key = prefix + "category";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.category = (ErrorCategory)EnumUtils.getValue(map[key],typeof(ErrorCategory));;
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
				ErrorParameter parameter =  ErrorParameter.createInstance(map, prefix + "parameter", i);
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
	public partial class ErrorParameter	
	{

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



		public static ErrorParameter createInstance(Dictionary<string, string> map, string prefix, int index)
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
      *This specifies a fault, encapsulating error data, with
      *specific error codes. 
      */
	public partial class FaultMessage	
	{

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



		public static FaultMessage createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				faultMessage = (faultMessage == null) ? new FaultMessage() : faultMessage;
				faultMessage.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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
      *This specifies the list of parameters with every request to
      *the service. 
      */
	public partial class RequestEnvelope	
	{

		/**
          *
		  */
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


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.detailLevel != null)
			{
					sb.Append(prefix).Append("detailLevel").Append("=").Append(EnumUtils.getDescription(detailLevel));
					sb.Append("&");
			}
			if (this.errorLanguage != null)
			{
					sb.Append(prefix).Append("errorLanguage").Append("=").Append(HttpUtility.UrlEncode(this.errorLanguage, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *This specifies a list of parameters with every response from
      *a service. 
      */
	public partial class ResponseEnvelope	
	{

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



		public static ResponseEnvelope createInstance(Dictionary<string, string> map, string prefix, int index)
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
				responseEnvelope.ack = (AckCode)EnumUtils.getValue(map[key],typeof(AckCode));;
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
      * AckCodeType This code identifies the
      * acknowledgment code types that could be used to
      * communicate the status of processing a (request)
      * message to an application. This code would be
      * used as part of a response message that contains
      * an application level acknowledgment element.
      * 
      */
	public enum AckCode {
		[Description("Success")]SUCCESS,	
		[Description("Failure")]FAILURE,	
		[Description("Warning")]WARNING,	
		[Description("SuccessWithWarning")]SUCCESSWITHWARNING,	
		[Description("FailureWithWarning")]FAILUREWITHWARNING	
	}




	/**
      * DetailLevelCodeType
      * 
      */
	public enum DetailLevelCode {
		[Description("ReturnAll")]RETURNALL	
	}




	/**
      *
      */
	public enum ErrorCategory {
		[Description("System")]SYSTEM,	
		[Description("Application")]APPLICATION,	
		[Description("Request")]REQUEST	
	}




	/**
      *
      */
	public enum ErrorSeverity {
		[Description("Error")]ERROR,	
		[Description("Warning")]WARNING	
	}




	/**
      * Specifies the payment terms for this invoice.
      * 
      */
	public enum PaymentTermsType {
		[Description("DueOnReceipt")]DUEONRECEIPT,	
		[Description("DueOnDateSpecified")]DUEONDATESPECIFIED,	
		[Description("Net10")]NET1,	
		[Description("Net15")]NET2,	
		[Description("Net30")]NET3,	
		[Description("Net45")]NET4	
	}




	/**
      * Specifies the payment methods that can be used to mark an
      *invoice as paid.
      * 
      */
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




	/**
      * Specifies the invoice status.
      * 
      */
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




	/**
      * Specifies the merchant or payer.
      * 
      */
	public enum OriginType {
		[Description("Web")]WEB,	
		[Description("API")]API	
	}




	/**
      * Specifies the merchant or payer.
      * 
      */
	public enum ActorType {
		[Description("Merchant")]MERCHANT,	
		[Description("Payer")]PAYER	
	}




	/**
      *Contact information for a company participating in the
      *invoicing system. 
      */
	public partial class BusinessInfoType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BusinessInfoType(){
		}


		public string toNVPString(string prefix)
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
					sb.Append(this.addressField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

		public static BusinessInfoType createInstance(Dictionary<string, string> map, string prefix, int index)
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
			BaseAddress address =  BaseAddress.createInstance(map, prefix + "address", -1);
			if (address != null)
			{
				businessInfoType = (businessInfoType == null) ? new BusinessInfoType() : businessInfoType;
				businessInfoType.address = address;
			}
			return businessInfoType;
		}
		
	}




	/**
      *Item information about a service or product listed in the
      *invoice. 
      */
	public partial class InvoiceItemType	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public InvoiceItemType(string name, decimal? quantity, decimal? unitPrice){
			this.name = name;
			this.quantity = quantity;
			this.unitPrice = unitPrice;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public InvoiceItemType(){
		}


		public string toNVPString(string prefix)
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
					sb.Append(prefix).Append("quantity").Append("=").Append(this.quantity).Append("&");
			}
			if (this.unitPrice != null)
			{
					sb.Append(prefix).Append("unitPrice").Append("=").Append(this.unitPrice).Append("&");
			}
			if (this.taxName != null)
			{
					sb.Append(prefix).Append("taxName").Append("=").Append(HttpUtility.UrlEncode(this.taxName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.taxRate != null)
			{
					sb.Append(prefix).Append("taxRate").Append("=").Append(this.taxRate).Append("&");
			}
			return sb.ToString();
		}

		public static InvoiceItemType createInstance(Dictionary<string, string> map, string prefix, int index)
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




	/**
      *A list of invoice items. 
      */
	public partial class InvoiceItemListType	
	{

		/**
          *
		  */
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public InvoiceItemListType(List<InvoiceItemType> item){
			this.item = item;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public InvoiceItemListType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.item.Count; i++)
			{
				if (this.item[i] != null)
				{
					string newPrefix = prefix + "item" + "(" + i + ").";
					sb.Append(this.item[i].toNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}

		public static InvoiceItemListType createInstance(Dictionary<string, string> map, string prefix, int index)
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
				InvoiceItemType item =  InvoiceItemType.createInstance(map, prefix + "item", i);
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




	/**
      *Invoice details about the merchant, payer, totals and terms.
      *
      */
	public partial class InvoiceType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public InvoiceType(string merchantEmail, string payerEmail, InvoiceItemListType itemList, string currencyCode, PaymentTermsType? paymentTerms){
			this.merchantEmail = merchantEmail;
			this.payerEmail = payerEmail;
			this.itemList = itemList;
			this.currencyCode = currencyCode;
			this.paymentTerms = paymentTerms;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public InvoiceType(){
		}


		public string toNVPString(string prefix)
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
					sb.Append(this.merchantInfoField.toNVPString(newPrefix));
			}
			if (this.itemList != null)
			{
					string newPrefix = prefix + "itemList" + ".";
					sb.Append(this.itemListField.toNVPString(newPrefix));
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
					sb.Append(prefix).Append("paymentTerms").Append("=").Append(EnumUtils.getDescription(paymentTerms));
					sb.Append("&");
			}
			if (this.discountPercent != null)
			{
					sb.Append(prefix).Append("discountPercent").Append("=").Append(this.discountPercent).Append("&");
			}
			if (this.discountAmount != null)
			{
					sb.Append(prefix).Append("discountAmount").Append("=").Append(this.discountAmount).Append("&");
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
					sb.Append(this.billingInfoField.toNVPString(newPrefix));
			}
			if (this.shippingInfo != null)
			{
					string newPrefix = prefix + "shippingInfo" + ".";
					sb.Append(this.shippingInfoField.toNVPString(newPrefix));
			}
			if (this.shippingAmount != null)
			{
					sb.Append(prefix).Append("shippingAmount").Append("=").Append(this.shippingAmount).Append("&");
			}
			if (this.shippingTaxName != null)
			{
					sb.Append(prefix).Append("shippingTaxName").Append("=").Append(HttpUtility.UrlEncode(this.shippingTaxName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.shippingTaxRate != null)
			{
					sb.Append(prefix).Append("shippingTaxRate").Append("=").Append(this.shippingTaxRate).Append("&");
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
					sb.Append(prefix).Append("customAmountValue").Append("=").Append(this.customAmountValue).Append("&");
			}
			return sb.ToString();
		}

		public static InvoiceType createInstance(Dictionary<string, string> map, string prefix, int index)
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
			BusinessInfoType merchantInfo =  BusinessInfoType.createInstance(map, prefix + "merchantInfo", -1);
			if (merchantInfo != null)
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.merchantInfo = merchantInfo;
			}
			InvoiceItemListType itemList =  InvoiceItemListType.createInstance(map, prefix + "itemList", -1);
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
				invoiceType.paymentTerms = (PaymentTermsType)EnumUtils.getValue(map[key],typeof(PaymentTermsType));;
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
			BusinessInfoType billingInfo =  BusinessInfoType.createInstance(map, prefix + "billingInfo", -1);
			if (billingInfo != null)
			{
				invoiceType = (invoiceType == null) ? new InvoiceType() : invoiceType;
				invoiceType.billingInfo = billingInfo;
			}
			BusinessInfoType shippingInfo =  BusinessInfoType.createInstance(map, prefix + "shippingInfo", -1);
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




	/**
      *Invoice details about the invoice status and state change
      *dates. 
      */
	public partial class InvoiceDetailsType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InvoiceDetailsType(){
		}



		public static InvoiceDetailsType createInstance(Dictionary<string, string> map, string prefix, int index)
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
				invoiceDetailsType.status = (StatusType)EnumUtils.getValue(map[key],typeof(StatusType));;
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
				invoiceDetailsType.origin = (OriginType)EnumUtils.getValue(map[key],typeof(OriginType));;
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
				invoiceDetailsType.canceledByActor = (ActorType)EnumUtils.getValue(map[key],typeof(ActorType));;
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




	/**
      *Details of the refund made against this invoice. 
      */
	public partial class OtherPaymentRefundDetailsType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public OtherPaymentRefundDetailsType(){
		}


		public string toNVPString(string prefix)
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

		public static OtherPaymentRefundDetailsType createInstance(Dictionary<string, string> map, string prefix, int index)
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




	/**
      *Details of the paypal refund made against this invoice. 
      */
	public partial class PayPalPaymentRefundDetailsType	
	{

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PayPalPaymentRefundDetailsType(){
		}



		public static PayPalPaymentRefundDetailsType createInstance(Dictionary<string, string> map, string prefix, int index)
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




	/**
      *PayPal payment details about the invoice. 
      */
	public partial class PayPalPaymentDetailsType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PayPalPaymentDetailsType(){
		}



		public static PayPalPaymentDetailsType createInstance(Dictionary<string, string> map, string prefix, int index)
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




	/**
      *Offline payment details about the invoice. 
      */
	public partial class OtherPaymentDetailsType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public OtherPaymentDetailsType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.method != null)
			{
					sb.Append(prefix).Append("method").Append("=").Append(EnumUtils.getDescription(method));
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

		public static OtherPaymentDetailsType createInstance(Dictionary<string, string> map, string prefix, int index)
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
				otherPaymentDetailsType.method = (PaymentMethodsType)EnumUtils.getValue(map[key],typeof(PaymentMethodsType));;
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




	/**
      *Payment details about the invoice. 
      */
	public partial class PaymentDetailsType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentDetailsType(){
		}



		public static PaymentDetailsType createInstance(Dictionary<string, string> map, string prefix, int index)
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
			PayPalPaymentDetailsType paypalPayment =  PayPalPaymentDetailsType.createInstance(map, prefix + "paypalPayment", -1);
			if (paypalPayment != null)
			{
				paymentDetailsType = (paymentDetailsType == null) ? new PaymentDetailsType() : paymentDetailsType;
				paymentDetailsType.paypalPayment = paypalPayment;
			}
			OtherPaymentDetailsType otherPayment =  OtherPaymentDetailsType.createInstance(map, prefix + "otherPayment", -1);
			if (otherPayment != null)
			{
				paymentDetailsType = (paymentDetailsType == null) ? new PaymentDetailsType() : paymentDetailsType;
				paymentDetailsType.otherPayment = otherPayment;
			}
			return paymentDetailsType;
		}
		
	}




	/**
      *Determines an inclusive date range. 
      */
	public partial class DateRangeType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DateRangeType(){
		}


		public string toNVPString(string prefix)
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




	/**
      *Search parameters criteria. 
      */
	public partial class SearchParametersType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SearchParametersType(){
		}


		public string toNVPString(string prefix)
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
					sb.Append(prefix).Append("status(").Append(i).Append(")=").Append(EnumUtils.getDescription(status[i]));
					sb.Append("&");
				}
			}
			if (this.lowerAmount != null)
			{
					sb.Append(prefix).Append("lowerAmount").Append("=").Append(this.lowerAmount).Append("&");
			}
			if (this.upperAmount != null)
			{
					sb.Append(prefix).Append("upperAmount").Append("=").Append(this.upperAmount).Append("&");
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
					sb.Append(prefix).Append("origin").Append("=").Append(EnumUtils.getDescription(origin));
					sb.Append("&");
			}
			if (this.invoiceDate != null)
			{
					string newPrefix = prefix + "invoiceDate" + ".";
					sb.Append(this.invoiceDateField.toNVPString(newPrefix));
			}
			if (this.dueDate != null)
			{
					string newPrefix = prefix + "dueDate" + ".";
					sb.Append(this.dueDateField.toNVPString(newPrefix));
			}
			if (this.paymentDate != null)
			{
					string newPrefix = prefix + "paymentDate" + ".";
					sb.Append(this.paymentDateField.toNVPString(newPrefix));
			}
			if (this.creationDate != null)
			{
					string newPrefix = prefix + "creationDate" + ".";
					sb.Append(this.creationDateField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *Summary of invoice information. 
      */
	public partial class InvoiceSummaryType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InvoiceSummaryType(){
		}



		public static InvoiceSummaryType createInstance(Dictionary<string, string> map, string prefix, int index)
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
				invoiceSummaryType.status = (StatusType)EnumUtils.getValue(map[key],typeof(StatusType));;
			}
			key = prefix + "origin";
			if (map.ContainsKey(key))
			{
				invoiceSummaryType = (invoiceSummaryType == null) ? new InvoiceSummaryType() : invoiceSummaryType;
				invoiceSummaryType.origin = (OriginType)EnumUtils.getValue(map[key],typeof(OriginType));;
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




	/**
      *A list of invoice summaries. 
      */
	public partial class InvoiceSummaryListType	
	{

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InvoiceSummaryListType(){
		}



		public static InvoiceSummaryListType createInstance(Dictionary<string, string> map, string prefix, int index)
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
				InvoiceSummaryType invoice =  InvoiceSummaryType.createInstance(map, prefix + "invoice", i);
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




	/**
      *The request object for CreateInvoice. 
      */
	public partial class CreateInvoiceRequest	
	{

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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CreateInvoiceRequest(RequestEnvelope requestEnvelope, InvoiceType invoice){
			this.requestEnvelope = requestEnvelope;
			this.invoice = invoice;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateInvoiceRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoice != null)
			{
					string newPrefix = prefix + "invoice" + ".";
					sb.Append(this.invoiceField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *The response object for CreateInvoice. 
      */
	public partial class CreateInvoiceResponse	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
	 	public CreateInvoiceResponse(){
		}



		public static CreateInvoiceResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *The request object for SendInvoice. 
      */
	public partial class SendInvoiceRequest	
	{

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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SendInvoiceRequest(RequestEnvelope requestEnvelope, string invoiceID){
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SendInvoiceRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The response object for SendInvoice. 
      */
	public partial class SendInvoiceResponse	
	{

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
		

		/**
          *
		  */
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
	 	public SendInvoiceResponse(){
		}



		public static SendInvoiceResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *The request object for CreateAndSendInvoice. 
      */
	public partial class CreateAndSendInvoiceRequest	
	{

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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CreateAndSendInvoiceRequest(RequestEnvelope requestEnvelope, InvoiceType invoice){
			this.requestEnvelope = requestEnvelope;
			this.invoice = invoice;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateAndSendInvoiceRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoice != null)
			{
					string newPrefix = prefix + "invoice" + ".";
					sb.Append(this.invoiceField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *The response object for CreateAndSendInvoice. 
      */
	public partial class CreateAndSendInvoiceResponse	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
	 	public CreateAndSendInvoiceResponse(){
		}



		public static CreateAndSendInvoiceResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *The request object for UpdateInvoice. 
      */
	public partial class UpdateInvoiceRequest	
	{

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
		

		/**
          *
		  */
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public UpdateInvoiceRequest(RequestEnvelope requestEnvelope, string invoiceID, InvoiceType invoice){
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
			this.invoice = invoice;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public UpdateInvoiceRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.invoice != null)
			{
					string newPrefix = prefix + "invoice" + ".";
					sb.Append(this.invoiceField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *The response object for UpdateInvoice. 
      */
	public partial class UpdateInvoiceResponse	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
	 	public UpdateInvoiceResponse(){
		}



		public static UpdateInvoiceResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *The request object for GetInvoiceDetails. 
      */
	public partial class GetInvoiceDetailsRequest	
	{

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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetInvoiceDetailsRequest(RequestEnvelope requestEnvelope, string invoiceID){
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetInvoiceDetailsRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The response object for CreateInvoice. 
      */
	public partial class GetInvoiceDetailsResponse	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
	 	public GetInvoiceDetailsResponse(){
		}



		public static GetInvoiceDetailsResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.responseEnvelope = responseEnvelope;
			}
			InvoiceType invoice =  InvoiceType.createInstance(map, prefix + "invoice", -1);
			if (invoice != null)
			{
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.invoice = invoice;
			}
			InvoiceDetailsType invoiceDetails =  InvoiceDetailsType.createInstance(map, prefix + "invoiceDetails", -1);
			if (invoiceDetails != null)
			{
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.invoiceDetails = invoiceDetails;
			}
			PaymentDetailsType paymentDetails =  PaymentDetailsType.createInstance(map, prefix + "paymentDetails", -1);
			if (paymentDetails != null)
			{
				getInvoiceDetailsResponse = (getInvoiceDetailsResponse == null) ? new GetInvoiceDetailsResponse() : getInvoiceDetailsResponse;
				getInvoiceDetailsResponse.paymentDetails = paymentDetails;
			}
			PaymentRefundDetailsType refundDetails =  PaymentRefundDetailsType.createInstance(map, prefix + "refundDetails", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *The request object for CancelInvoice. 
      */
	public partial class CancelInvoiceRequest	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CancelInvoiceRequest(RequestEnvelope requestEnvelope){
			this.requestEnvelope = requestEnvelope;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CancelInvoiceRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
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
					sb.Append(prefix).Append("sendCopyToMerchant").Append("=").Append(this.sendCopyToMerchant).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The response object for CancelInvoice. 
      */
	public partial class CancelInvoiceResponse	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
	 	public CancelInvoiceResponse(){
		}



		public static CancelInvoiceResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *The request object for SearchInvoices. 
      */
	public partial class SearchInvoicesRequest	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SearchInvoicesRequest(RequestEnvelope requestEnvelope, string merchantEmail, SearchParametersType parameters, int? page, int? pageSize){
			this.requestEnvelope = requestEnvelope;
			this.merchantEmail = merchantEmail;
			this.parameters = parameters;
			this.page = page;
			this.pageSize = pageSize;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SearchInvoicesRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.merchantEmail != null)
			{
					sb.Append(prefix).Append("merchantEmail").Append("=").Append(HttpUtility.UrlEncode(this.merchantEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.parameters != null)
			{
					string newPrefix = prefix + "parameters" + ".";
					sb.Append(this.parametersField.toNVPString(newPrefix));
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




	/**
      *The response object for SearchInvoices. 
      */
	public partial class SearchInvoicesResponse	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
	 	public SearchInvoicesResponse(){
		}



		public static SearchInvoicesResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
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
			InvoiceSummaryListType invoiceList =  InvoiceSummaryListType.createInstance(map, prefix + "invoiceList", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *The request object for MarkInvoiceAsPaid. 
      */
	public partial class MarkInvoiceAsPaidRequest	
	{

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
		

		/**
          *
		  */
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public MarkInvoiceAsPaidRequest(RequestEnvelope requestEnvelope, string invoiceID, OtherPaymentDetailsType payment){
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
			this.payment = payment;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public MarkInvoiceAsPaidRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.payment != null)
			{
					string newPrefix = prefix + "payment" + ".";
					sb.Append(this.paymentField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *The response object for MarkInvoiceAsPaid. 
      */
	public partial class MarkInvoiceAsPaidResponse	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
	 	public MarkInvoiceAsPaidResponse(){
		}



		public static MarkInvoiceAsPaidResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *The request object for MarkInvoiceAsRefunded. 
      */
	public partial class MarkInvoiceAsRefundedRequest	
	{

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
		

		/**
          *
		  */
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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public MarkInvoiceAsRefundedRequest(RequestEnvelope requestEnvelope, string invoiceID, OtherPaymentRefundDetailsType refundDetail){
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
			this.refundDetail = refundDetail;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public MarkInvoiceAsRefundedRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.refundDetail != null)
			{
					string newPrefix = prefix + "refundDetail" + ".";
					sb.Append(this.refundDetailField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *The response object for MarkInvoiceAsRefunded. 
      */
	public partial class MarkInvoiceAsRefundedResponse	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
	 	public MarkInvoiceAsRefundedResponse(){
		}



		public static MarkInvoiceAsRefundedResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *The request object for MarkInvoiceAsUnpaid. 
      */
	public partial class MarkInvoiceAsUnpaidRequest	
	{

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
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public MarkInvoiceAsUnpaidRequest(RequestEnvelope requestEnvelope, string invoiceID){
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public MarkInvoiceAsUnpaidRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null)
			{
					sb.Append(prefix).Append("invoiceID").Append("=").Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The response object for MarkInvoiceAsUnpaid. 
      */
	public partial class MarkInvoiceAsUnpaidResponse	
	{

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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
	 	public MarkInvoiceAsUnpaidResponse(){
		}



		public static MarkInvoiceAsUnpaidResponse createInstance(Dictionary<string, string> map, string prefix, int index)
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
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
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
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
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




	/**
      *Payment refund details about the invoice.  
      */
	public partial class PaymentRefundDetailsType	
	{

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
          *
		  */
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
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentRefundDetailsType(){
		}



		public static PaymentRefundDetailsType createInstance(Dictionary<string, string> map, string prefix, int index)
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
			PayPalPaymentRefundDetailsType paypalPayment =  PayPalPaymentRefundDetailsType.createInstance(map, prefix + "paypalPayment", -1);
			if (paypalPayment != null)
			{
				paymentRefundDetailsType = (paymentRefundDetailsType == null) ? new PaymentRefundDetailsType() : paymentRefundDetailsType;
				paymentRefundDetailsType.paypalPayment = paypalPayment;
			}
			OtherPaymentRefundDetailsType otherPayment =  OtherPaymentRefundDetailsType.createInstance(map, prefix + "otherPayment", -1);
			if (otherPayment != null)
			{
				paymentRefundDetailsType = (paymentRefundDetailsType == null) ? new PaymentRefundDetailsType() : paymentRefundDetailsType;
				paymentRefundDetailsType.otherPayment = otherPayment;
			}
			return paymentRefundDetailsType;
		}
		
	}





}