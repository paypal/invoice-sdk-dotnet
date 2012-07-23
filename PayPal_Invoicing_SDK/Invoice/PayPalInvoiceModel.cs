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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
		public BaseAddress(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "line1";
			if(map.ContainsKey(key))
			{
				this.line1 = map[key];
			}
			key = prefix + "line2";
			if(map.ContainsKey(key))
			{
				this.line2 = map[key];
			}
			key = prefix + "city";
			if(map.ContainsKey(key))
			{
				this.city = map[key];
			}
			key = prefix + "state";
			if(map.ContainsKey(key))
			{
				this.state = map[key];
			}
			key = prefix + "postalCode";
			if(map.ContainsKey(key))
			{
				this.postalCode = map[key];
			}
			key = prefix + "countryCode";
			if(map.ContainsKey(key))
			{
				this.countryCode = map[key];
			}
			key = prefix + "type";
			if(map.ContainsKey(key))
			{
				this.type = map[key];
			}
		}
		
	}




	/**
      *This type contains the detailed error information resulting
      *from the service operation. 
      */
	public partial class ErrorData	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public ErrorData(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "errorId";
			if(map.ContainsKey(key))
			{
				this.errorId = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "domain";
			if(map.ContainsKey(key))
			{
				this.domain = map[key];
			}
			key = prefix + "subdomain";
			if(map.ContainsKey(key))
			{
				this.subdomain = map[key];
			}
			key = prefix + "severity";
			if(map.ContainsKey(key))
			{
				this.severity = (ErrorSeverity)EnumUtils.getValue(map[key],typeof(ErrorSeverity));;
			}
			key = prefix + "category";
			if(map.ContainsKey(key))
			{
				this.category = (ErrorCategory)EnumUtils.getValue(map[key],typeof(ErrorCategory));;
			}
			key = prefix + "message";
			if(map.ContainsKey(key))
			{
				this.message = map[key];
			}
			key = prefix + "exceptionId";
			if(map.ContainsKey(key))
			{
				this.exceptionId = map[key];
			}
			i = 0;
			while(true){
				key = prefix + "parameter" + "(" + i + ")";
				if(map.ContainsKey(key))
				{
					this.parameter.Add(new ErrorParameter(map, key));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *
      */
	public partial class ErrorParameter	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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


		public ErrorParameter(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "name";
			if(map.ContainsKey(key))
			{
				this.name = map[key];
			}
			key = prefix + "value";
			if(map.ContainsKey(key))
			{
				this.value = map[key];
			}
		}
		
	}




	/**
      *This specifies a fault, encapsulating error data, with
      *specific error codes. 
      */
	public partial class FaultMessage	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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


		public FaultMessage(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *This specifies the list of parameters with every request to
      *the service. 
      */
	public partial class RequestEnvelope	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public ResponseEnvelope(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "timestamp";
			if(map.ContainsKey(key))
			{
				this.timestamp = map[key];
			}
			key = prefix + "ack";
			if(map.ContainsKey(key))
			{
				this.ack = (AckCode)EnumUtils.getValue(map[key],typeof(AckCode));;
			}
			key = prefix + "correlationId";
			if(map.ContainsKey(key))
			{
				this.correlationId = map[key];
			}
			key = prefix + "build";
			if(map.ContainsKey(key))
			{
				this.build = map[key];
			}
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
		public BusinessInfoType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "firstName";
			if(map.ContainsKey(key))
			{
				this.firstName = map[key];
			}
			key = prefix + "lastName";
			if(map.ContainsKey(key))
			{
				this.lastName = map[key];
			}
			key = prefix + "businessName";
			if(map.ContainsKey(key))
			{
				this.businessName = map[key];
			}
			key = prefix + "phone";
			if(map.ContainsKey(key))
			{
				this.phone = map[key];
			}
			key = prefix + "fax";
			if(map.ContainsKey(key))
			{
				this.fax = map[key];
			}
			key = prefix + "website";
			if(map.ContainsKey(key))
			{
				this.website = map[key];
			}
			key = prefix + "customValue";
			if(map.ContainsKey(key))
			{
				this.customValue = map[key];
			}
			key = prefix + "address";
			if(map.ContainsKey(key + ".line1"))
			{
				this.address = new BaseAddress(map, key + ".");
			}
		}
		
	}




	/**
      *Item information about a service or product listed in the
      *invoice. 
      */
	public partial class InvoiceItemType	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
		public InvoiceItemType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "name";
			if(map.ContainsKey(key))
			{
				this.name = map[key];
			}
			key = prefix + "description";
			if(map.ContainsKey(key))
			{
				this.description = map[key];
			}
			key = prefix + "date";
			if(map.ContainsKey(key))
			{
				this.date = map[key];
			}
			key = prefix + "quantity";
			if(map.ContainsKey(key))
			{
				this.quantity = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "unitPrice";
			if(map.ContainsKey(key))
			{
				this.unitPrice = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "taxName";
			if(map.ContainsKey(key))
			{
				this.taxName = map[key];
			}
			key = prefix + "taxRate";
			if(map.ContainsKey(key))
			{
				this.taxRate = System.Convert.ToDecimal(map[key]);
			}
		}
		
	}




	/**
      *A list of invoice items. 
      */
	public partial class InvoiceItemListType	
	{

		/**
          *No Document Comments
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
		public InvoiceItemListType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "item" + "(" + i + ")";
				if(map.ContainsKey(key + ".name"))
				{
					this.item.Add(new InvoiceItemType(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *Invoice details about the merchant, payer, totals and terms.
      *
      */
	public partial class InvoiceType	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
		public InvoiceType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "merchantEmail";
			if(map.ContainsKey(key))
			{
				this.merchantEmail = map[key];
			}
			key = prefix + "payerEmail";
			if(map.ContainsKey(key))
			{
				this.payerEmail = map[key];
			}
			key = prefix + "number";
			if(map.ContainsKey(key))
			{
				this.number = map[key];
			}
			key = prefix + "merchantInfo";
			if(map.ContainsKey(key + ".address.line1"))
			{
				this.merchantInfo = new BusinessInfoType(map, key + ".");
			}
			key = prefix + "itemList";
			if(map.ContainsKey(key + ".item(0).name"))
			{
				this.itemList = new InvoiceItemListType(map, key + ".");
			}
			key = prefix + "currencyCode";
			if(map.ContainsKey(key))
			{
				this.currencyCode = map[key];
			}
			key = prefix + "invoiceDate";
			if(map.ContainsKey(key))
			{
				this.invoiceDate = map[key];
			}
			key = prefix + "dueDate";
			if(map.ContainsKey(key))
			{
				this.dueDate = map[key];
			}
			key = prefix + "paymentTerms";
			if(map.ContainsKey(key))
			{
				this.paymentTerms = (PaymentTermsType)EnumUtils.getValue(map[key],typeof(PaymentTermsType));;
			}
			key = prefix + "discountPercent";
			if(map.ContainsKey(key))
			{
				this.discountPercent = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "discountAmount";
			if(map.ContainsKey(key))
			{
				this.discountAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "terms";
			if(map.ContainsKey(key))
			{
				this.terms = map[key];
			}
			key = prefix + "note";
			if(map.ContainsKey(key))
			{
				this.note = map[key];
			}
			key = prefix + "merchantMemo";
			if(map.ContainsKey(key))
			{
				this.merchantMemo = map[key];
			}
			key = prefix + "billingInfo";
			if(map.ContainsKey(key + ".address.line1"))
			{
				this.billingInfo = new BusinessInfoType(map, key + ".");
			}
			key = prefix + "shippingInfo";
			if(map.ContainsKey(key + ".address.line1"))
			{
				this.shippingInfo = new BusinessInfoType(map, key + ".");
			}
			key = prefix + "shippingAmount";
			if(map.ContainsKey(key))
			{
				this.shippingAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "shippingTaxName";
			if(map.ContainsKey(key))
			{
				this.shippingTaxName = map[key];
			}
			key = prefix + "shippingTaxRate";
			if(map.ContainsKey(key))
			{
				this.shippingTaxRate = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "logoUrl";
			if(map.ContainsKey(key))
			{
				this.logoUrl = map[key];
			}
			key = prefix + "referrerCode";
			if(map.ContainsKey(key))
			{
				this.referrerCode = map[key];
			}
			key = prefix + "customAmountLabel";
			if(map.ContainsKey(key))
			{
				this.customAmountLabel = map[key];
			}
			key = prefix + "customAmountValue";
			if(map.ContainsKey(key))
			{
				this.customAmountValue = System.Convert.ToDecimal(map[key]);
			}
		}
		
	}




	/**
      *Invoice details about the invoice status and state change
      *dates. 
      */
	public partial class InvoiceDetailsType	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public InvoiceDetailsType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "status";
			if(map.ContainsKey(key))
			{
				this.status = (StatusType)EnumUtils.getValue(map[key],typeof(StatusType));;
			}
			key = prefix + "totalAmount";
			if(map.ContainsKey(key))
			{
				this.totalAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "origin";
			if(map.ContainsKey(key))
			{
				this.origin = (OriginType)EnumUtils.getValue(map[key],typeof(OriginType));;
			}
			key = prefix + "createdDate";
			if(map.ContainsKey(key))
			{
				this.createdDate = map[key];
			}
			key = prefix + "createdBy";
			if(map.ContainsKey(key))
			{
				this.createdBy = map[key];
			}
			key = prefix + "canceledDate";
			if(map.ContainsKey(key))
			{
				this.canceledDate = map[key];
			}
			key = prefix + "canceledByActor";
			if(map.ContainsKey(key))
			{
				this.canceledByActor = (ActorType)EnumUtils.getValue(map[key],typeof(ActorType));;
			}
			key = prefix + "canceledBy";
			if(map.ContainsKey(key))
			{
				this.canceledBy = map[key];
			}
			key = prefix + "lastUpdatedDate";
			if(map.ContainsKey(key))
			{
				this.lastUpdatedDate = map[key];
			}
			key = prefix + "lastUpdatedBy";
			if(map.ContainsKey(key))
			{
				this.lastUpdatedBy = map[key];
			}
			key = prefix + "firstSentDate";
			if(map.ContainsKey(key))
			{
				this.firstSentDate = map[key];
			}
			key = prefix + "lastSentDate";
			if(map.ContainsKey(key))
			{
				this.lastSentDate = map[key];
			}
			key = prefix + "lastSentBy";
			if(map.ContainsKey(key))
			{
				this.lastSentBy = map[key];
			}
			key = prefix + "paidDate";
			if(map.ContainsKey(key))
			{
				this.paidDate = map[key];
			}
		}
		
	}




	/**
      *Details of the refund made against this invoice. 
      */
	public partial class OtherPaymentRefundDetailsType	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
		public OtherPaymentRefundDetailsType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "note";
			if(map.ContainsKey(key))
			{
				this.note = map[key];
			}
			key = prefix + "date";
			if(map.ContainsKey(key))
			{
				this.date = map[key];
			}
		}
		
	}




	/**
      *Details of the paypal refund made against this invoice. 
      */
	public partial class PayPalPaymentRefundDetailsType	
	{

		/**
          *No Document Comments
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


		public PayPalPaymentRefundDetailsType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "date";
			if(map.ContainsKey(key))
			{
				this.date = map[key];
			}
		}
		
	}




	/**
      *PayPal payment details about the invoice. 
      */
	public partial class PayPalPaymentDetailsType	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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


		public PayPalPaymentDetailsType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "transactionID";
			if(map.ContainsKey(key))
			{
				this.transactionID = map[key];
			}
			key = prefix + "date";
			if(map.ContainsKey(key))
			{
				this.date = map[key];
			}
		}
		
	}




	/**
      *Offline payment details about the invoice. 
      */
	public partial class OtherPaymentDetailsType	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
		public OtherPaymentDetailsType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "method";
			if(map.ContainsKey(key))
			{
				this.method = (PaymentMethodsType)EnumUtils.getValue(map[key],typeof(PaymentMethodsType));;
			}
			key = prefix + "note";
			if(map.ContainsKey(key))
			{
				this.note = map[key];
			}
			key = prefix + "date";
			if(map.ContainsKey(key))
			{
				this.date = map[key];
			}
		}
		
	}




	/**
      *Payment details about the invoice. 
      */
	public partial class PaymentDetailsType	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public PaymentDetailsType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "viaPayPal";
			if(map.ContainsKey(key))
			{
				this.viaPayPal = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "paypalPayment";
			if(map.ContainsKey(key + ".transactionID"))
			{
				this.paypalPayment = new PayPalPaymentDetailsType(map, key + ".");
			}
			key = prefix + "otherPayment";
			if(map.ContainsKey(key))
			{
				this.otherPayment = new OtherPaymentDetailsType(map, key);
			}
		}
		
	}




	/**
      *Determines an inclusive date range. 
      */
	public partial class DateRangeType	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
					sb.Append(prefix).Append("status").Append(i).Append(")=").Append(EnumUtils.getDescription(status[i]));
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public InvoiceSummaryType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "invoiceID";
			if(map.ContainsKey(key))
			{
				this.invoiceID = map[key];
			}
			key = prefix + "merchantEmail";
			if(map.ContainsKey(key))
			{
				this.merchantEmail = map[key];
			}
			key = prefix + "payerEmail";
			if(map.ContainsKey(key))
			{
				this.payerEmail = map[key];
			}
			key = prefix + "number";
			if(map.ContainsKey(key))
			{
				this.number = map[key];
			}
			key = prefix + "billingBusinessName";
			if(map.ContainsKey(key))
			{
				this.billingBusinessName = map[key];
			}
			key = prefix + "billingFirstName";
			if(map.ContainsKey(key))
			{
				this.billingFirstName = map[key];
			}
			key = prefix + "billingLastName";
			if(map.ContainsKey(key))
			{
				this.billingLastName = map[key];
			}
			key = prefix + "shippingBusinessName";
			if(map.ContainsKey(key))
			{
				this.shippingBusinessName = map[key];
			}
			key = prefix + "shippingFirstName";
			if(map.ContainsKey(key))
			{
				this.shippingFirstName = map[key];
			}
			key = prefix + "shippingLastName";
			if(map.ContainsKey(key))
			{
				this.shippingLastName = map[key];
			}
			key = prefix + "totalAmount";
			if(map.ContainsKey(key))
			{
				this.totalAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "currencyCode";
			if(map.ContainsKey(key))
			{
				this.currencyCode = map[key];
			}
			key = prefix + "invoiceDate";
			if(map.ContainsKey(key))
			{
				this.invoiceDate = map[key];
			}
			key = prefix + "dueDate";
			if(map.ContainsKey(key))
			{
				this.dueDate = map[key];
			}
			key = prefix + "status";
			if(map.ContainsKey(key))
			{
				this.status = (StatusType)EnumUtils.getValue(map[key],typeof(StatusType));;
			}
			key = prefix + "origin";
			if(map.ContainsKey(key))
			{
				this.origin = (OriginType)EnumUtils.getValue(map[key],typeof(OriginType));;
			}
			key = prefix + "referrerCode";
			if(map.ContainsKey(key))
			{
				this.referrerCode = map[key];
			}
		}
		
	}




	/**
      *A list of invoice summaries. 
      */
	public partial class InvoiceSummaryListType	
	{

		/**
          *No Document Comments
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


		public InvoiceSummaryListType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "invoice" + "(" + i + ")";
				if(map.ContainsKey(key + ".invoiceID"))
				{
					this.invoice.Add(new InvoiceSummaryType(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for CreateInvoice. 
      */
	public partial class CreateInvoiceRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public CreateInvoiceResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "invoiceID";
			if(map.ContainsKey(key))
			{
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if(map.ContainsKey(key))
			{
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if(map.ContainsKey(key))
			{
				this.invoiceURL = map[key];
			}
			key = prefix + "totalAmount";
			if(map.ContainsKey(key))
			{
				this.totalAmount = System.Convert.ToInt32(map[key]);
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for SendInvoice. 
      */
	public partial class SendInvoiceRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public SendInvoiceResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "invoiceID";
			if(map.ContainsKey(key))
			{
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceURL";
			if(map.ContainsKey(key))
			{
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for CreateAndSendInvoice. 
      */
	public partial class CreateAndSendInvoiceRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public CreateAndSendInvoiceResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "invoiceID";
			if(map.ContainsKey(key))
			{
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if(map.ContainsKey(key))
			{
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if(map.ContainsKey(key))
			{
				this.invoiceURL = map[key];
			}
			key = prefix + "totalAmount";
			if(map.ContainsKey(key))
			{
				this.totalAmount = System.Convert.ToInt32(map[key]);
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for UpdateInvoice. 
      */
	public partial class UpdateInvoiceRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public UpdateInvoiceResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "invoiceID";
			if(map.ContainsKey(key))
			{
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if(map.ContainsKey(key))
			{
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if(map.ContainsKey(key))
			{
				this.invoiceURL = map[key];
			}
			key = prefix + "totalAmount";
			if(map.ContainsKey(key))
			{
				this.totalAmount = System.Convert.ToInt32(map[key]);
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for GetInvoiceDetails. 
      */
	public partial class GetInvoiceDetailsRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public GetInvoiceDetailsResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "invoice";
			if(map.ContainsKey(key + ".merchantEmail"))
			{
				this.invoice = new InvoiceType(map, key + ".");
			}
			key = prefix + "invoiceDetails";
			if(map.ContainsKey(key + ".createdDate"))
			{
				this.invoiceDetails = new InvoiceDetailsType(map, key + ".");
			}
			key = prefix + "paymentDetails";
			if(map.ContainsKey(key + ".viaPayPal"))
			{
				this.paymentDetails = new PaymentDetailsType(map, key + ".");
			}
			key = prefix + "refundDetails";
			if(map.ContainsKey(key + ".viaPayPal"))
			{
				this.refundDetails = new PaymentRefundDetailsType(map, key + ".");
			}
			key = prefix + "invoiceURL";
			if(map.ContainsKey(key))
			{
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for CancelInvoice. 
      */
	public partial class CancelInvoiceRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public CancelInvoiceResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "invoiceID";
			if(map.ContainsKey(key))
			{
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if(map.ContainsKey(key))
			{
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if(map.ContainsKey(key))
			{
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for SearchInvoices. 
      */
	public partial class SearchInvoicesRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public SearchInvoicesResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "count";
			if(map.ContainsKey(key))
			{
				this.count = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "invoiceList";
			if(map.ContainsKey(key + ".invoice(0).invoiceID"))
			{
				this.invoiceList = new InvoiceSummaryListType(map, key + ".");
			}
			key = prefix + "page";
			if(map.ContainsKey(key))
			{
				this.page = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "hasNextPage";
			if(map.ContainsKey(key))
			{
				this.hasNextPage = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "hasPreviousPage";
			if(map.ContainsKey(key))
			{
				this.hasPreviousPage = System.Convert.ToBoolean(map[key]);
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for MarkInvoiceAsPaid. 
      */
	public partial class MarkInvoiceAsPaidRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public MarkInvoiceAsPaidResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "invoiceID";
			if(map.ContainsKey(key))
			{
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if(map.ContainsKey(key))
			{
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if(map.ContainsKey(key))
			{
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for MarkInvoiceAsRefunded. 
      */
	public partial class MarkInvoiceAsRefundedRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public MarkInvoiceAsRefundedResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "invoiceID";
			if(map.ContainsKey(key))
			{
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if(map.ContainsKey(key))
			{
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if(map.ContainsKey(key))
			{
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request object for MarkInvoiceAsUnpaid. 
      */
	public partial class MarkInvoiceAsUnpaidRequest	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public MarkInvoiceAsUnpaidResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "invoiceID";
			if(map.ContainsKey(key))
			{
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if(map.ContainsKey(key))
			{
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if(map.ContainsKey(key))
			{
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".parameter(0)"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *Payment refund details about the invoice.  
      */
	public partial class PaymentRefundDetailsType	
	{

		/**
          *No Document Comments
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
          *No Document Comments
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
          *No Document Comments
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


		public PaymentRefundDetailsType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "viaPayPal";
			if(map.ContainsKey(key))
			{
				this.viaPayPal = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "paypalPayment";
			if(map.ContainsKey(key))
			{
				this.paypalPayment = new PayPalPaymentRefundDetailsType(map, key);
			}
			key = prefix + "otherPayment";
			if(map.ContainsKey(key))
			{
				this.otherPayment = new OtherPaymentRefundDetailsType(map, key);
			}
		}
		
	}





}