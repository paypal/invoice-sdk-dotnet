namespace PayPal.Invoice.Model {
	using System;
	using System.Text;
	using System.Web;
	using System.Xml;
	using System.Collections;
	using System.ComponentModel;
	using System.Collections.Generic;
	using PayPal.Util;

	public class EnumUtils{
		public static string getDescription(Enum value){
			string description="";
			DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
			if (attributes.Length > 0)
			{
				description= attributes[0].Description;
			}
			return description;
		}
		public static object getValue(String value,Type enumType){
			string[] names = Enum.GetNames(enumType);
			foreach (string name in names)
			{
				if (getDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
				{
					return Enum.Parse(enumType, name);
				}
			}
			return null;
		}
	}
	public enum AckCode {
[Description("Success")]SUCCESS,
[Description("Failure")]FAILURE,
[Description("Warning")]WARNING,
[Description("SuccessWithWarning")]SUCCESSWITHWARNING,
[Description("FailureWithWarning")]FAILUREWITHWARNING,
	}
	public enum ActorType {
[Description("Merchant")]MERCHANT,
[Description("Payer")]PAYER,
	}
	/**
	 */
	public partial class BaseAddress {

		private string line1Field;
		public string line1 {
			get {
				return this.line1Field;
			}
			set {
				this.line1Field = value;
			}
		}

		private string line2Field;
		public string line2 {
			get {
				return this.line2Field;
			}
			set {
				this.line2Field = value;
			}
		}

		private string cityField;
		public string city {
			get {
				return this.cityField;
			}
			set {
				this.cityField = value;
			}
		}

		private string stateField;
		public string state {
			get {
				return this.stateField;
			}
			set {
				this.stateField = value;
			}
		}

		private string postalCodeField;
		public string postalCode {
			get {
				return this.postalCodeField;
			}
			set {
				this.postalCodeField = value;
			}
		}

		private string countryCodeField;
		public string countryCode {
			get {
				return this.countryCodeField;
			}
			set {
				this.countryCodeField = value;
			}
		}

		private string typeField;
		public string type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		public BaseAddress(string line1, string city, string countryCode) {
			this.line1 = line1;
			this.city = city;
			this.countryCode = countryCode;
		}
		public BaseAddress() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.line1 != null) {
				sb.Append(prefix).Append("line1").Append('=').Append(HttpUtility.UrlEncode(this.line1, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.line2 != null) {
				sb.Append(prefix).Append("line2").Append('=').Append(HttpUtility.UrlEncode(this.line2, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.city != null) {
				sb.Append(prefix).Append("city").Append('=').Append(HttpUtility.UrlEncode(this.city, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.state != null) {
				sb.Append(prefix).Append("state").Append('=').Append(HttpUtility.UrlEncode(this.state, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.postalCode != null) {
				sb.Append(prefix).Append("postalCode").Append('=').Append(HttpUtility.UrlEncode(this.postalCode, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.countryCode != null) {
				sb.Append(prefix).Append("countryCode").Append('=').Append(HttpUtility.UrlEncode(this.countryCode, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.type != null) {
				sb.Append(prefix).Append("type").Append('=').Append(HttpUtility.UrlEncode(this.type, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	 public BaseAddress(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "line1";
			if (map.ContainsKey(key)) {
				this.line1 = map[key];
			}
			key = prefix + "line2";
			if (map.ContainsKey(key)) {
				this.line2 = map[key];
			}
			key = prefix + "city";
			if (map.ContainsKey(key)) {
				this.city = map[key];
			}
			key = prefix + "state";
			if (map.ContainsKey(key)) {
				this.state = map[key];
			}
			key = prefix + "postalCode";
			if (map.ContainsKey(key)) {
				this.postalCode = map[key];
			}
			key = prefix + "countryCode";
			if (map.ContainsKey(key)) {
				this.countryCode = map[key];
			}
			key = prefix + "type";
			if (map.ContainsKey(key)) {
				this.type = map[key];
			}
		}
	}


	/**
	 * Contact information for a company participating in the invoicing system.
	 */
	public partial class BusinessInfoType {

		/**
		 * First name of the company contact.
		 */
		private string firstNameField;
		public string firstName {
			get {
				return this.firstNameField;
			}
			set {
				this.firstNameField = value;
			}
		}

		/**
		 * Last name of the company contact.
		 */
		private string lastNameField;
		public string lastName {
			get {
				return this.lastNameField;
			}
			set {
				this.lastNameField = value;
			}
		}

		/**
		 * Business name of the company.
		 */
		private string businessNameField;
		public string businessName {
			get {
				return this.businessNameField;
			}
			set {
				this.businessNameField = value;
			}
		}

		/**
		 * Phone number for contacting the company.
		 */
		private string phoneField;
		public string phone {
			get {
				return this.phoneField;
			}
			set {
				this.phoneField = value;
			}
		}

		/**
		 * Fax number used by the company.
		 */
		private string faxField;
		public string fax {
			get {
				return this.faxField;
			}
			set {
				this.faxField = value;
			}
		}

		/**
		 * Website used by the company.
		 */
		private string websiteField;
		public string website {
			get {
				return this.websiteField;
			}
			set {
				this.websiteField = value;
			}
		}

		/**
		 * Custom value to be displayed in the contact information details.
		 */
		private string customValueField;
		public string customValue {
			get {
				return this.customValueField;
			}
			set {
				this.customValueField = value;
			}
		}

		/**
		 * Street address of the company.
		 */
		private BaseAddress addressField;
		public BaseAddress address {
			get {
				return this.addressField;
			}
			set {
				this.addressField = value;
			}
		}

		public BusinessInfoType() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.firstName != null) {
				sb.Append(prefix).Append("firstName").Append('=').Append(HttpUtility.UrlEncode(this.firstName, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.lastName != null) {
				sb.Append(prefix).Append("lastName").Append('=').Append(HttpUtility.UrlEncode(this.lastName, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.businessName != null) {
				sb.Append(prefix).Append("businessName").Append('=').Append(HttpUtility.UrlEncode(this.businessName, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.phone != null) {
				sb.Append(prefix).Append("phone").Append('=').Append(HttpUtility.UrlEncode(this.phone, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.fax != null) {
				sb.Append(prefix).Append("fax").Append('=').Append(HttpUtility.UrlEncode(this.fax, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.website != null) {
				sb.Append(prefix).Append("website").Append('=').Append(HttpUtility.UrlEncode(this.website, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.customValue != null) {
				sb.Append(prefix).Append("customValue").Append('=').Append(HttpUtility.UrlEncode(this.customValue, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.address != null) {
				string newPrefix = prefix + "address" + '.';
				sb.Append(this.addressField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

	 public BusinessInfoType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "firstName";
			if (map.ContainsKey(key)) {
				this.firstName = map[key];
			}
			key = prefix + "lastName";
			if (map.ContainsKey(key)) {
				this.lastName = map[key];
			}
			key = prefix + "businessName";
			if (map.ContainsKey(key)) {
				this.businessName = map[key];
			}
			key = prefix + "phone";
			if (map.ContainsKey(key)) {
				this.phone = map[key];
			}
			key = prefix + "fax";
			if (map.ContainsKey(key)) {
				this.fax = map[key];
			}
			key = prefix + "website";
			if (map.ContainsKey(key)) {
				this.website = map[key];
			}
			key = prefix + "customValue";
			if (map.ContainsKey(key)) {
				this.customValue = map[key];
			}
			key = prefix + "address";
			if (map.ContainsKey(key + ".line1")) {
				this.address = new BaseAddress(map, key + '.');
			}
		}
	}


	/**
	 * The request object for CancelInvoice.
	 */
	public partial class CancelInvoiceRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * invoice's ID
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * Subject of the cancellation notification
		 */
		private string subjectField;
		public string subject {
			get {
				return this.subjectField;
			}
			set {
				this.subjectField = value;
			}
		}

		/**
		 * Note to send payer within the cancellation notification
		 */
		private string noteForPayerField;
		public string noteForPayer {
			get {
				return this.noteForPayerField;
			}
			set {
				this.noteForPayerField = value;
			}
		}

		/**
		 * send a copy of cancellation notification to merchant
		 */
		private bool? sendCopyToMerchantField;
		public bool? sendCopyToMerchant {
			get {
				return this.sendCopyToMerchantField;
			}
			set {
				this.sendCopyToMerchantField = value;
			}
		}

		public CancelInvoiceRequest(RequestEnvelope requestEnvelope) {
			this.requestEnvelope = requestEnvelope;
		}
		public CancelInvoiceRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null) {
				sb.Append(prefix).Append("invoiceID").Append('=').Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.subject != null) {
				sb.Append(prefix).Append("subject").Append('=').Append(HttpUtility.UrlEncode(this.subject, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.noteForPayer != null) {
				sb.Append(prefix).Append("noteForPayer").Append('=').Append(HttpUtility.UrlEncode(this.noteForPayer, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.sendCopyToMerchant != null) {
				sb.Append(prefix).Append("sendCopyToMerchant").Append('=').Append(this.sendCopyToMerchant).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for CancelInvoice.
	 */
	public partial class CancelInvoiceResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * The canceled invoice's ID.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * The canceled invoice's number.
		 */
		private string invoiceNumberField;
		public string invoiceNumber {
			get {
				return this.invoiceNumberField;
			}
			set {
				this.invoiceNumberField = value;
			}
		}

		/**
		 * The URL which lead merchant to view the invoice details on web.
		 */
		private string invoiceURLField;
		public string invoiceURL {
			get {
				return this.invoiceURLField;
			}
			set {
				this.invoiceURLField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public CancelInvoiceResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key)) {
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key)) {
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key)) {
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * The request object for CreateAndSendInvoice.
	 */
	public partial class CreateAndSendInvoiceRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * Data to populate the newly created invoice.
		 */
		private InvoiceType invoiceField;
		public InvoiceType invoice {
			get {
				return this.invoiceField;
			}
			set {
				this.invoiceField = value;
			}
		}

		public CreateAndSendInvoiceRequest(RequestEnvelope requestEnvelope, InvoiceType invoice) {
			this.requestEnvelope = requestEnvelope;
			this.invoice = invoice;
		}
		public CreateAndSendInvoiceRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoice != null) {
				string newPrefix = prefix + "invoice" + '.';
				sb.Append(this.invoiceField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for CreateAndSendInvoice.
	 */
	public partial class CreateAndSendInvoiceResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * The created invoice's ID.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * The created invoice's number.
		 */
		private string invoiceNumberField;
		public string invoiceNumber {
			get {
				return this.invoiceNumberField;
			}
			set {
				this.invoiceNumberField = value;
			}
		}

		/**
		 * The URL which lead merchant to view the invoice details on web.
		 */
		private string invoiceURLField;
		public string invoiceURL {
			get {
				return this.invoiceURLField;
			}
			set {
				this.invoiceURLField = value;
			}
		}

		/**
		 * The total amount of the invoice (cost of items, shipping and tax, less any discount).
		 */
		private int? totalAmountField;
		public int? totalAmount {
			get {
				return this.totalAmountField;
			}
			set {
				this.totalAmountField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public CreateAndSendInvoiceResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key)) {
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key)) {
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key)) {
				this.invoiceURL = map[key];
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key)) {
				this.totalAmount = System.Convert.ToInt32( map[key] );
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * The request object for CreateInvoice.
	 */
	public partial class CreateInvoiceRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * Data to populate the newly created invoice.
		 */
		private InvoiceType invoiceField;
		public InvoiceType invoice {
			get {
				return this.invoiceField;
			}
			set {
				this.invoiceField = value;
			}
		}

		public CreateInvoiceRequest(RequestEnvelope requestEnvelope, InvoiceType invoice) {
			this.requestEnvelope = requestEnvelope;
			this.invoice = invoice;
		}
		public CreateInvoiceRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoice != null) {
				string newPrefix = prefix + "invoice" + '.';
				sb.Append(this.invoiceField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for CreateInvoice.
	 */
	public partial class CreateInvoiceResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * The created invoice's ID.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * The created invoice's number.
		 */
		private string invoiceNumberField;
		public string invoiceNumber {
			get {
				return this.invoiceNumberField;
			}
			set {
				this.invoiceNumberField = value;
			}
		}

		/**
		 * The URL which lead merchant to view the invoice details on web.
		 */
		private string invoiceURLField;
		public string invoiceURL {
			get {
				return this.invoiceURLField;
			}
			set {
				this.invoiceURLField = value;
			}
		}

		/**
		 * The total amount of the invoice (cost of items, shipping and tax, less any discount).
		 */
		private int? totalAmountField;
		public int? totalAmount {
			get {
				return this.totalAmountField;
			}
			set {
				this.totalAmountField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public CreateInvoiceResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key)) {
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key)) {
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key)) {
				this.invoiceURL = map[key];
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key)) {
				this.totalAmount = System.Convert.ToInt32( map[key] );
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * Determines an inclusive date range.
	 */
	public partial class DateRangeType {

		/**
		 * Start of the date range.
		 */
		private string startDateField;
		public string startDate {
			get {
				return this.startDateField;
			}
			set {
				this.startDateField = value;
			}
		}

		/**
		 * End of the date range.
		 */
		private string endDateField;
		public string endDate {
			get {
				return this.endDateField;
			}
			set {
				this.endDateField = value;
			}
		}

		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.startDate != null) {
				sb.Append(prefix).Append("startDate").Append('=').Append(HttpUtility.UrlEncode(this.startDate, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.endDate != null) {
				sb.Append(prefix).Append("endDate").Append('=').Append(HttpUtility.UrlEncode(this.endDate, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	public enum DetailLevelCode {
[Description("ReturnAll")]RETURNALL,
	}
	public enum ErrorCategory {
[Description("System")]SYSTEM,
[Description("Application")]APPLICATION,
[Description("Request")]REQUEST,
	}
	/**
	 * This type contains the detailed error
	 * information resulting from the service
	 * operation.
	 */
	public partial class ErrorData {

		private int? errorIdField;
		public int? errorId {
			get {
				return this.errorIdField;
			}
			set {
				this.errorIdField = value;
			}
		}

		private string domainField;
		public string domain {
			get {
				return this.domainField;
			}
			set {
				this.domainField = value;
			}
		}

		private string subdomainField;
		public string subdomain {
			get {
				return this.subdomainField;
			}
			set {
				this.subdomainField = value;
			}
		}

		private ErrorSeverity? severityField;
		public ErrorSeverity? severity {
			get {
				return this.severityField;
			}
			set {
				this.severityField = value;
			}
		}

		private ErrorCategory? categoryField;
		public ErrorCategory? category {
			get {
				return this.categoryField;
			}
			set {
				this.categoryField = value;
			}
		}

		private string messageField;
		public string message {
			get {
				return this.messageField;
			}
			set {
				this.messageField = value;
			}
		}

		private string exceptionIdField;
		public string exceptionId {
			get {
				return this.exceptionIdField;
			}
			set {
				this.exceptionIdField = value;
			}
		}

		private List<ErrorParameter> parameterField = new List<ErrorParameter>();
		public List<ErrorParameter> parameter {
			get {
				return this.parameterField;
			}
			set {
				this.parameterField = value;
			}
		}

	 public ErrorData(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "errorId";
			if (map.ContainsKey(key)) {
				this.errorId = System.Convert.ToInt32( map[key] );
			}
			key = prefix + "domain";
			if (map.ContainsKey(key)) {
				this.domain = map[key];
			}
			key = prefix + "subdomain";
			if (map.ContainsKey(key)) {
				this.subdomain = map[key];
			}
			key = prefix + "severity";
			if (map.ContainsKey(key)) {
				this.severity = (ErrorSeverity)EnumUtils.getValue(map[key],typeof(ErrorSeverity));;
			}
			key = prefix + "category";
			if (map.ContainsKey(key)) {
				this.category = (ErrorCategory)EnumUtils.getValue(map[key],typeof(ErrorCategory));;
			}
			key = prefix + "message";
			if (map.ContainsKey(key)) {
				this.message = map[key];
			}
			key = prefix + "exceptionId";
			if (map.ContainsKey(key)) {
				this.exceptionId = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "parameter" + '(' + i + ")";
				if (map.ContainsKey(key + ".name")) {
					this.parameter.Add( new ErrorParameter(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 */
	public partial class ErrorParameter {

		private string nameField;
		public string name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}

		private string valueField;
		public string value {
			get {
				return this.valueField;
			}
			set {
				this.valueField = value;
			}
		}

	 public ErrorParameter(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "name";
			if (map.ContainsKey(key)) {
				this.name = map[key];
			}
			key = prefix + "value";
			if (map.ContainsKey(key)) {
				this.value = map[key];
			}
		}
	}


	public enum ErrorSeverity {
[Description("Error")]ERROR,
[Description("Warning")]WARNING,
	}
	/**
	 * This specifies a fault, encapsulating error
	 * data, with specific error codes.
	 */
	public partial class FaultMessage {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public FaultMessage(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * The request object for GetInvoiceDetails.
	 */
	public partial class GetInvoiceDetailsRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * ID of the invoice to retrieve.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		public GetInvoiceDetailsRequest(RequestEnvelope requestEnvelope, string invoiceID) {
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
		}
		public GetInvoiceDetailsRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null) {
				sb.Append(prefix).Append("invoiceID").Append('=').Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for CreateInvoice.
	 */
	public partial class GetInvoiceDetailsResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * The requested invoice.
		 */
		private InvoiceType invoiceField;
		public InvoiceType invoice {
			get {
				return this.invoiceField;
			}
			set {
				this.invoiceField = value;
			}
		}

		/**
		 * The requested invoice details.
		 */
		private InvoiceDetailsType invoiceDetailsField;
		public InvoiceDetailsType invoiceDetails {
			get {
				return this.invoiceDetailsField;
			}
			set {
				this.invoiceDetailsField = value;
			}
		}

		/**
		 * The requested invoice payment details.
		 */
		private PaymentDetailsType paymentDetailsField;
		public PaymentDetailsType paymentDetails {
			get {
				return this.paymentDetailsField;
			}
			set {
				this.paymentDetailsField = value;
			}
		}

		/**
		 * The requested invoice refund details.
		 */
		private PaymentRefundDetailsType refundDetailsField;
		public PaymentRefundDetailsType refundDetails {
			get {
				return this.refundDetailsField;
			}
			set {
				this.refundDetailsField = value;
			}
		}

		/**
		 * The URL which lead merchant to view the invoice details on web.
		 */
		private string invoiceURLField;
		public string invoiceURL {
			get {
				return this.invoiceURLField;
			}
			set {
				this.invoiceURLField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public GetInvoiceDetailsResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "invoice";
			if (map.ContainsKey(key + ".merchantEmail")) {
				this.invoice = new InvoiceType(map, key + '.');
			}
			key = prefix + "invoiceDetails";
			if (map.ContainsKey(key + ".totalAmount")) {
				this.invoiceDetails = new InvoiceDetailsType(map, key + '.');
			}
			key = prefix + "paymentDetails";
			if (map.ContainsKey(key + ".viaPayPal")) {
				this.paymentDetails = new PaymentDetailsType(map, key + '.');
			}
			key = prefix + "refundDetails";
			if (map.ContainsKey(key + ".viaPayPal")) {
				this.refundDetails = new PaymentRefundDetailsType(map, key + '.');
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key)) {
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * Invoice details about the invoice status and state change dates.
	 */
	public partial class InvoiceDetailsType {

		/**
		 * Status of the invoice.
		 */
		private StatusType? statusField;
		public StatusType? status {
			get {
				return this.statusField;
			}
			set {
				this.statusField = value;
			}
		}

		/**
		 * The total amount of the invoice (cost of items, shipping and tax, less any discount).
		 * This field is set by the invoicing system and will ignore any changes made by API callers.
		 */
		private decimal? totalAmountField;
		public decimal? totalAmount {
			get {
				return this.totalAmountField;
			}
			set {
				this.totalAmountField = value;
			}
		}

		/**
		 * Whether the invoice was created via the website or via an API call.
		 */
		private OriginType? originField;
		public OriginType? origin {
			get {
				return this.originField;
			}
			set {
				this.originField = value;
			}
		}

		/**
		 * Date when the invoice was created.
		 */
		private string createdDateField;
		public string createdDate {
			get {
				return this.createdDateField;
			}
			set {
				this.createdDateField = value;
			}
		}

		/**
		 * Account that created the invoice.
		 */
		private string createdByField;
		public string createdBy {
			get {
				return this.createdByField;
			}
			set {
				this.createdByField = value;
			}
		}

		/**
		 * If canceled, date when the invoice was canceled.
		 */
		private string canceledDateField;
		public string canceledDate {
			get {
				return this.canceledDateField;
			}
			set {
				this.canceledDateField = value;
			}
		}

		/**
		 * Actor who canceled the invoice.
		 */
		private ActorType? canceledByActorField;
		public ActorType? canceledByActor {
			get {
				return this.canceledByActorField;
			}
			set {
				this.canceledByActorField = value;
			}
		}

		/**
		 * Account that canceled the invoice.
		 */
		private string canceledByField;
		public string canceledBy {
			get {
				return this.canceledByField;
			}
			set {
				this.canceledByField = value;
			}
		}

		/**
		 * Date when the invoice was last edited.
		 */
		private string lastUpdatedDateField;
		public string lastUpdatedDate {
			get {
				return this.lastUpdatedDateField;
			}
			set {
				this.lastUpdatedDateField = value;
			}
		}

		/**
		 * Account that last edited the invoice.
		 */
		private string lastUpdatedByField;
		public string lastUpdatedBy {
			get {
				return this.lastUpdatedByField;
			}
			set {
				this.lastUpdatedByField = value;
			}
		}

		/**
		 * Date when the invoice was first sent.
		 */
		private string firstSentDateField;
		public string firstSentDate {
			get {
				return this.firstSentDateField;
			}
			set {
				this.firstSentDateField = value;
			}
		}

		/**
		 * Date when the invoice was last sent.
		 */
		private string lastSentDateField;
		public string lastSentDate {
			get {
				return this.lastSentDateField;
			}
			set {
				this.lastSentDateField = value;
			}
		}

		/**
		 * Account that last sent the invoice.
		 */
		private string lastSentByField;
		public string lastSentBy {
			get {
				return this.lastSentByField;
			}
			set {
				this.lastSentByField = value;
			}
		}

		/**
		 * If the invoice was paid, date when the invoice was paid.
		 */
		private string paidDateField;
		public string paidDate {
			get {
				return this.paidDateField;
			}
			set {
				this.paidDateField = value;
			}
		}

	 public InvoiceDetailsType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "status";
			if (map.ContainsKey(key)) {
				this.status = (StatusType)EnumUtils.getValue(map[key],typeof(StatusType));;
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key)) {
				this.totalAmount = System.Convert.ToDecimal( map[key] );
			}
			key = prefix + "origin";
			if (map.ContainsKey(key)) {
				this.origin = (OriginType)EnumUtils.getValue(map[key],typeof(OriginType));;
			}
			key = prefix + "createdDate";
			if (map.ContainsKey(key)) {
				this.createdDate = map[key];
			}
			key = prefix + "createdBy";
			if (map.ContainsKey(key)) {
				this.createdBy = map[key];
			}
			key = prefix + "canceledDate";
			if (map.ContainsKey(key)) {
				this.canceledDate = map[key];
			}
			key = prefix + "canceledByActor";
			if (map.ContainsKey(key)) {
				this.canceledByActor = (ActorType)EnumUtils.getValue(map[key],typeof(ActorType));;
			}
			key = prefix + "canceledBy";
			if (map.ContainsKey(key)) {
				this.canceledBy = map[key];
			}
			key = prefix + "lastUpdatedDate";
			if (map.ContainsKey(key)) {
				this.lastUpdatedDate = map[key];
			}
			key = prefix + "lastUpdatedBy";
			if (map.ContainsKey(key)) {
				this.lastUpdatedBy = map[key];
			}
			key = prefix + "firstSentDate";
			if (map.ContainsKey(key)) {
				this.firstSentDate = map[key];
			}
			key = prefix + "lastSentDate";
			if (map.ContainsKey(key)) {
				this.lastSentDate = map[key];
			}
			key = prefix + "lastSentBy";
			if (map.ContainsKey(key)) {
				this.lastSentBy = map[key];
			}
			key = prefix + "paidDate";
			if (map.ContainsKey(key)) {
				this.paidDate = map[key];
			}
		}
	}


	/**
	 * A list of invoice items.
	 */
	public partial class InvoiceItemListType {

		private List<InvoiceItemType> itemField = new List<InvoiceItemType>();
		public List<InvoiceItemType> item {
			get {
				return this.itemField;
			}
			set {
				this.itemField = value;
			}
		}

		public InvoiceItemListType(List<InvoiceItemType> item) {
			this.item = item;
		}
		public InvoiceItemListType() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.item.Count; i++) {
				if (this.item[i] != null) {
					string newPrefix = prefix + "item" + '(' + i + ").";
					sb.Append(this.item[i].toNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}

	 public InvoiceItemListType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			i = 0;
			while(true) {
				key = prefix + "item" + '(' + i + ")";
				if (map.ContainsKey(key + ".name")) {
					this.item.Add( new InvoiceItemType(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * Item information about a service or product listed in the invoice.
	 */
	public partial class InvoiceItemType {

		/**
		 * SKU or item name.
		 */
		private string nameField;
		public string name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}

		/**
		 * Description of the item.
		 */
		private string descriptionField;
		public string description {
			get {
				return this.descriptionField;
			}
			set {
				this.descriptionField = value;
			}
		}

		/**
		 * Date on which the product or service was provided.
		 */
		private string dateField;
		public string date {
			get {
				return this.dateField;
			}
			set {
				this.dateField = value;
			}
		}

		/**
		 * Item count.
		 */
		private decimal? quantityField;
		public decimal? quantity {
			get {
				return this.quantityField;
			}
			set {
				this.quantityField = value;
			}
		}

		/**
		 * Price of the item, in the currency specified by the invoice.
		 */
		private decimal? unitPriceField;
		public decimal? unitPrice {
			get {
				return this.unitPriceField;
			}
			set {
				this.unitPriceField = value;
			}
		}

		/**
		 * Name of an applicable tax, if any.
		 */
		private string taxNameField;
		public string taxName {
			get {
				return this.taxNameField;
			}
			set {
				this.taxNameField = value;
			}
		}

		/**
		 * Rate of an applicable tax, if any.
		 */
		private decimal? taxRateField;
		public decimal? taxRate {
			get {
				return this.taxRateField;
			}
			set {
				this.taxRateField = value;
			}
		}

		public InvoiceItemType(string name, decimal? quantity, decimal? unitPrice) {
			this.name = name;
			this.quantity = quantity;
			this.unitPrice = unitPrice;
		}
		public InvoiceItemType() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.name != null) {
				sb.Append(prefix).Append("name").Append('=').Append(HttpUtility.UrlEncode(this.name, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.description != null) {
				sb.Append(prefix).Append("description").Append('=').Append(HttpUtility.UrlEncode(this.description, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.date != null) {
				sb.Append(prefix).Append("date").Append('=').Append(HttpUtility.UrlEncode(this.date, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.quantity != null) {
				sb.Append(prefix).Append("quantity").Append('=').Append(this.quantity).Append('&');
			}
			if (this.unitPrice != null) {
				sb.Append(prefix).Append("unitPrice").Append('=').Append(this.unitPrice).Append('&');
			}
			if (this.taxName != null) {
				sb.Append(prefix).Append("taxName").Append('=').Append(HttpUtility.UrlEncode(this.taxName, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.taxRate != null) {
				sb.Append(prefix).Append("taxRate").Append('=').Append(this.taxRate).Append('&');
			}
			return sb.ToString();
		}

	 public InvoiceItemType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "name";
			if (map.ContainsKey(key)) {
				this.name = map[key];
			}
			key = prefix + "description";
			if (map.ContainsKey(key)) {
				this.description = map[key];
			}
			key = prefix + "date";
			if (map.ContainsKey(key)) {
				this.date = map[key];
			}
			key = prefix + "quantity";
			if (map.ContainsKey(key)) {
				this.quantity = System.Convert.ToDecimal( map[key] );
			}
			key = prefix + "unitPrice";
			if (map.ContainsKey(key)) {
				this.unitPrice = System.Convert.ToDecimal( map[key] );
			}
			key = prefix + "taxName";
			if (map.ContainsKey(key)) {
				this.taxName = map[key];
			}
			key = prefix + "taxRate";
			if (map.ContainsKey(key)) {
				this.taxRate = System.Convert.ToDecimal( map[key] );
			}
		}
	}


	/**
	 * A list of invoice summaries.
	 */
	public partial class InvoiceSummaryListType {

		private List<InvoiceSummaryType> invoiceField = new List<InvoiceSummaryType>();
		public List<InvoiceSummaryType> invoice {
			get {
				return this.invoiceField;
			}
			set {
				this.invoiceField = value;
			}
		}

	 public InvoiceSummaryListType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			i = 0;
			while(true) {
				key = prefix + "invoice" + '(' + i + ")";
				if (map.ContainsKey(key + ".invoiceID")) {
					this.invoice.Add( new InvoiceSummaryType(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * Summary of invoice information.
	 */
	public partial class InvoiceSummaryType {

		/**
		 * The created invoice's ID.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * Invoice creator's email.
		 */
		private string merchantEmailField;
		public string merchantEmail {
			get {
				return this.merchantEmailField;
			}
			set {
				this.merchantEmailField = value;
			}
		}

		/**
		 * Email to which the invoice will be sent.
		 */
		private string payerEmailField;
		public string payerEmail {
			get {
				return this.payerEmailField;
			}
			set {
				this.payerEmailField = value;
			}
		}

		/**
		 * Unique identifier for the invoice.
		 */
		private string numberField;
		public string number {
			get {
				return this.numberField;
			}
			set {
				this.numberField = value;
			}
		}

		/**
		 * Business name of the billing info.
		 */
		private string billingBusinessNameField;
		public string billingBusinessName {
			get {
				return this.billingBusinessNameField;
			}
			set {
				this.billingBusinessNameField = value;
			}
		}

		/**
		 * First name of the billing info.
		 */
		private string billingFirstNameField;
		public string billingFirstName {
			get {
				return this.billingFirstNameField;
			}
			set {
				this.billingFirstNameField = value;
			}
		}

		/**
		 * Last name of the billing info.
		 */
		private string billingLastNameField;
		public string billingLastName {
			get {
				return this.billingLastNameField;
			}
			set {
				this.billingLastNameField = value;
			}
		}

		/**
		 * Business name of the shipping info.
		 */
		private string shippingBusinessNameField;
		public string shippingBusinessName {
			get {
				return this.shippingBusinessNameField;
			}
			set {
				this.shippingBusinessNameField = value;
			}
		}

		/**
		 * First name of the shipping info.
		 */
		private string shippingFirstNameField;
		public string shippingFirstName {
			get {
				return this.shippingFirstNameField;
			}
			set {
				this.shippingFirstNameField = value;
			}
		}

		/**
		 * Last name of the shipping info.
		 */
		private string shippingLastNameField;
		public string shippingLastName {
			get {
				return this.shippingLastNameField;
			}
			set {
				this.shippingLastNameField = value;
			}
		}

		/**
		 * Total amount of the invoice.
		 */
		private decimal? totalAmountField;
		public decimal? totalAmount {
			get {
				return this.totalAmountField;
			}
			set {
				this.totalAmountField = value;
			}
		}

		/**
		 * Currency used for all invoice item amounts and totals.
		 */
		private string currencyCodeField;
		public string currencyCode {
			get {
				return this.currencyCodeField;
			}
			set {
				this.currencyCodeField = value;
			}
		}

		/**
		 * Date on which the invoice will be enabled.
		 */
		private string invoiceDateField;
		public string invoiceDate {
			get {
				return this.invoiceDateField;
			}
			set {
				this.invoiceDateField = value;
			}
		}

		/**
		 * Date on which the invoice payment is due.
		 */
		private string dueDateField;
		public string dueDate {
			get {
				return this.dueDateField;
			}
			set {
				this.dueDateField = value;
			}
		}

		/**
		 * Status of the invoice.
		 */
		private StatusType? statusField;
		public StatusType? status {
			get {
				return this.statusField;
			}
			set {
				this.statusField = value;
			}
		}

		/**
		 * Whether the invoice was created via the website or via an API call.
		 */
		private OriginType? originField;
		public OriginType? origin {
			get {
				return this.originField;
			}
			set {
				this.originField = value;
			}
		}

		/**
		 * BN code for tracking transactions with a particular partner. 
		 */
		private string referrerCodeField;
		public string referrerCode {
			get {
				return this.referrerCodeField;
			}
			set {
				this.referrerCodeField = value;
			}
		}

	 public InvoiceSummaryType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "invoiceID";
			if (map.ContainsKey(key)) {
				this.invoiceID = map[key];
			}
			key = prefix + "merchantEmail";
			if (map.ContainsKey(key)) {
				this.merchantEmail = map[key];
			}
			key = prefix + "payerEmail";
			if (map.ContainsKey(key)) {
				this.payerEmail = map[key];
			}
			key = prefix + "number";
			if (map.ContainsKey(key)) {
				this.number = map[key];
			}
			key = prefix + "billingBusinessName";
			if (map.ContainsKey(key)) {
				this.billingBusinessName = map[key];
			}
			key = prefix + "billingFirstName";
			if (map.ContainsKey(key)) {
				this.billingFirstName = map[key];
			}
			key = prefix + "billingLastName";
			if (map.ContainsKey(key)) {
				this.billingLastName = map[key];
			}
			key = prefix + "shippingBusinessName";
			if (map.ContainsKey(key)) {
				this.shippingBusinessName = map[key];
			}
			key = prefix + "shippingFirstName";
			if (map.ContainsKey(key)) {
				this.shippingFirstName = map[key];
			}
			key = prefix + "shippingLastName";
			if (map.ContainsKey(key)) {
				this.shippingLastName = map[key];
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key)) {
				this.totalAmount = System.Convert.ToDecimal( map[key] );
			}
			key = prefix + "currencyCode";
			if (map.ContainsKey(key)) {
				this.currencyCode = map[key];
			}
			key = prefix + "invoiceDate";
			if (map.ContainsKey(key)) {
				this.invoiceDate = map[key];
			}
			key = prefix + "dueDate";
			if (map.ContainsKey(key)) {
				this.dueDate = map[key];
			}
			key = prefix + "status";
			if (map.ContainsKey(key)) {
				this.status = (StatusType)EnumUtils.getValue(map[key],typeof(StatusType));;
			}
			key = prefix + "origin";
			if (map.ContainsKey(key)) {
				this.origin = (OriginType)EnumUtils.getValue(map[key],typeof(OriginType));;
			}
			key = prefix + "referrerCode";
			if (map.ContainsKey(key)) {
				this.referrerCode = map[key];
			}
		}
	}


	/**
	 * Invoice details about the merchant, payer, totals and terms.
	 */
	public partial class InvoiceType {

		/**
		 * Merchant's email.
		 */
		private string merchantEmailField;
		public string merchantEmail {
			get {
				return this.merchantEmailField;
			}
			set {
				this.merchantEmailField = value;
			}
		}

		/**
		 * Email to which the invoice will be sent.
		 */
		private string payerEmailField;
		public string payerEmail {
			get {
				return this.payerEmailField;
			}
			set {
				this.payerEmailField = value;
			}
		}

		/**
		 * Unique identifier for the invoice.
		 */
		private string numberField;
		public string number {
			get {
				return this.numberField;
			}
			set {
				this.numberField = value;
			}
		}

		/**
		 * Company contact information of the merchant company sending the invoice.
		 */
		private BusinessInfoType merchantInfoField;
		public BusinessInfoType merchantInfo {
			get {
				return this.merchantInfoField;
			}
			set {
				this.merchantInfoField = value;
			}
		}

		/**
		 * List of items included in this invoice.
		 */
		private InvoiceItemListType itemListField;
		public InvoiceItemListType itemList {
			get {
				return this.itemListField;
			}
			set {
				this.itemListField = value;
			}
		}

		/**
		 * Currency used for all invoice item amounts and totals.
		 */
		private string currencyCodeField;
		public string currencyCode {
			get {
				return this.currencyCodeField;
			}
			set {
				this.currencyCodeField = value;
			}
		}

		/**
		 * Date on which the invoice will be enabled.
		 */
		private string invoiceDateField;
		public string invoiceDate {
			get {
				return this.invoiceDateField;
			}
			set {
				this.invoiceDateField = value;
			}
		}

		/**
		 * Date on which the invoice payment is due.
		 */
		private string dueDateField;
		public string dueDate {
			get {
				return this.dueDateField;
			}
			set {
				this.dueDateField = value;
			}
		}

		/**
		 * Terms by which the invoice payment is due.
		 */
		private PaymentTermsType? paymentTermsField;
		public PaymentTermsType? paymentTerms {
			get {
				return this.paymentTermsField;
			}
			set {
				this.paymentTermsField = value;
			}
		}

		/**
		 * A discount percent applied to the invoice, if any.
		 */
		private decimal? discountPercentField;
		public decimal? discountPercent {
			get {
				return this.discountPercentField;
			}
			set {
				this.discountPercentField = value;
			}
		}

		/**
		 * A discount amount applied to the invoice, if any.  If DiscountPercent is provided, DiscountAmount is ignored.
		 */
		private decimal? discountAmountField;
		public decimal? discountAmount {
			get {
				return this.discountAmountField;
			}
			set {
				this.discountAmountField = value;
			}
		}

		/**
		 * General terms for the invoice.
		 */
		private string termsField;
		public string terms {
			get {
				return this.termsField;
			}
			set {
				this.termsField = value;
			}
		}

		/**
		 * Note to the payer company.
		 */
		private string noteField;
		public string note {
			get {
				return this.noteField;
			}
			set {
				this.noteField = value;
			}
		}

		/**
		 * Memo for book keeping that is private to the Merchant.
		 */
		private string merchantMemoField;
		public string merchantMemo {
			get {
				return this.merchantMemoField;
			}
			set {
				this.merchantMemoField = value;
			}
		}

		/**
		 * Billing information for the payer.
		 */
		private BusinessInfoType billingInfoField;
		public BusinessInfoType billingInfo {
			get {
				return this.billingInfoField;
			}
			set {
				this.billingInfoField = value;
			}
		}

		/**
		 * Shipping information for the payer.
		 */
		private BusinessInfoType shippingInfoField;
		public BusinessInfoType shippingInfo {
			get {
				return this.shippingInfoField;
			}
			set {
				this.shippingInfoField = value;
			}
		}

		/**
		 * Cost of shipping.
		 */
		private decimal? shippingAmountField;
		public decimal? shippingAmount {
			get {
				return this.shippingAmountField;
			}
			set {
				this.shippingAmountField = value;
			}
		}

		/**
		 * Name of the applicable tax on shipping cost, if any.
		 */
		private string shippingTaxNameField;
		public string shippingTaxName {
			get {
				return this.shippingTaxNameField;
			}
			set {
				this.shippingTaxNameField = value;
			}
		}

		/**
		 * Rate of the applicable tax on shipping cost, if any.
		 */
		private decimal? shippingTaxRateField;
		public decimal? shippingTaxRate {
			get {
				return this.shippingTaxRateField;
			}
			set {
				this.shippingTaxRateField = value;
			}
		}

		/**
		 * The external image URL of the invoice's logo, if any
		 */
		private string logoUrlField;
		public string logoUrl {
			get {
				return this.logoUrlField;
			}
			set {
				this.logoUrlField = value;
			}
		}

		/**
		 * BN code for tracking transactions with a particular partner. 
		 */
		private string referrerCodeField;
		public string referrerCode {
			get {
				return this.referrerCodeField;
			}
			set {
				this.referrerCodeField = value;
			}
		}

		/**
		 * Label used to display custom amount value.
		 * If a value is entered for customAmountLabel, then customAmountValue cannot be empty.
		 */
		private string customAmountLabelField;
		public string customAmountLabel {
			get {
				return this.customAmountLabelField;
			}
			set {
				this.customAmountLabelField = value;
			}
		}

		/**
		 * Value of custom amount.
		 * If a value is entered for customAmountValue, then customAmountLabel cannot be empty.
		 */
		private decimal? customAmountValueField;
		public decimal? customAmountValue {
			get {
				return this.customAmountValueField;
			}
			set {
				this.customAmountValueField = value;
			}
		}

		public InvoiceType(string merchantEmail, string payerEmail, InvoiceItemListType itemList, string currencyCode, PaymentTermsType? paymentTerms) {
			this.merchantEmail = merchantEmail;
			this.payerEmail = payerEmail;
			this.itemList = itemList;
			this.currencyCode = currencyCode;
			this.paymentTerms = paymentTerms;
		}
		public InvoiceType() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.merchantEmail != null) {
				sb.Append(prefix).Append("merchantEmail").Append('=').Append(HttpUtility.UrlEncode(this.merchantEmail, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.payerEmail != null) {
				sb.Append(prefix).Append("payerEmail").Append('=').Append(HttpUtility.UrlEncode(this.payerEmail, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.number != null) {
				sb.Append(prefix).Append("number").Append('=').Append(HttpUtility.UrlEncode(this.number, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.merchantInfo != null) {
				string newPrefix = prefix + "merchantInfo" + '.';
				sb.Append(this.merchantInfoField.toNVPString(newPrefix));
			}
			if (this.itemList != null) {
				string newPrefix = prefix + "itemList" + '.';
				sb.Append(this.itemListField.toNVPString(newPrefix));
			}
			if (this.currencyCode != null) {
				sb.Append(prefix).Append("currencyCode").Append('=').Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.invoiceDate != null) {
				sb.Append(prefix).Append("invoiceDate").Append('=').Append(HttpUtility.UrlEncode(this.invoiceDate, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.dueDate != null) {
				sb.Append(prefix).Append("dueDate").Append('=').Append(HttpUtility.UrlEncode(this.dueDate, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.paymentTerms != null) {
				sb.Append(prefix).Append("paymentTerms").Append('=').Append(EnumUtils.getDescription(paymentTerms));
				sb.Append('&');
			}
			if (this.discountPercent != null) {
				sb.Append(prefix).Append("discountPercent").Append('=').Append(this.discountPercent).Append('&');
			}
			if (this.discountAmount != null) {
				sb.Append(prefix).Append("discountAmount").Append('=').Append(this.discountAmount).Append('&');
			}
			if (this.terms != null) {
				sb.Append(prefix).Append("terms").Append('=').Append(HttpUtility.UrlEncode(this.terms, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.note != null) {
				sb.Append(prefix).Append("note").Append('=').Append(HttpUtility.UrlEncode(this.note, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.merchantMemo != null) {
				sb.Append(prefix).Append("merchantMemo").Append('=').Append(HttpUtility.UrlEncode(this.merchantMemo, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.billingInfo != null) {
				string newPrefix = prefix + "billingInfo" + '.';
				sb.Append(this.billingInfoField.toNVPString(newPrefix));
			}
			if (this.shippingInfo != null) {
				string newPrefix = prefix + "shippingInfo" + '.';
				sb.Append(this.shippingInfoField.toNVPString(newPrefix));
			}
			if (this.shippingAmount != null) {
				sb.Append(prefix).Append("shippingAmount").Append('=').Append(this.shippingAmount).Append('&');
			}
			if (this.shippingTaxName != null) {
				sb.Append(prefix).Append("shippingTaxName").Append('=').Append(HttpUtility.UrlEncode(this.shippingTaxName, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.shippingTaxRate != null) {
				sb.Append(prefix).Append("shippingTaxRate").Append('=').Append(this.shippingTaxRate).Append('&');
			}
			if (this.logoUrl != null) {
				sb.Append(prefix).Append("logoUrl").Append('=').Append(HttpUtility.UrlEncode(this.logoUrl, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.referrerCode != null) {
				sb.Append(prefix).Append("referrerCode").Append('=').Append(HttpUtility.UrlEncode(this.referrerCode, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.customAmountLabel != null) {
				sb.Append(prefix).Append("customAmountLabel").Append('=').Append(HttpUtility.UrlEncode(this.customAmountLabel, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.customAmountValue != null) {
				sb.Append(prefix).Append("customAmountValue").Append('=').Append(this.customAmountValue).Append('&');
			}
			return sb.ToString();
		}

	 public InvoiceType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "merchantEmail";
			if (map.ContainsKey(key)) {
				this.merchantEmail = map[key];
			}
			key = prefix + "payerEmail";
			if (map.ContainsKey(key)) {
				this.payerEmail = map[key];
			}
			key = prefix + "number";
			if (map.ContainsKey(key)) {
				this.number = map[key];
			}
			key = prefix + "merchantInfo";
			if (map.ContainsKey(key + ".firstName")) {
				this.merchantInfo = new BusinessInfoType(map, key + '.');
			}
			key = prefix + "itemList";
			if (map.ContainsKey(key + ".item(0).name")) {
				this.itemList = new InvoiceItemListType(map, key + '.');
			}
			key = prefix + "currencyCode";
			if (map.ContainsKey(key)) {
				this.currencyCode = map[key];
			}
			key = prefix + "invoiceDate";
			if (map.ContainsKey(key)) {
				this.invoiceDate = map[key];
			}
			key = prefix + "dueDate";
			if (map.ContainsKey(key)) {
				this.dueDate = map[key];
			}
			key = prefix + "paymentTerms";
			if (map.ContainsKey(key)) {
				this.paymentTerms = (PaymentTermsType)EnumUtils.getValue(map[key],typeof(PaymentTermsType));;
			}
			key = prefix + "discountPercent";
			if (map.ContainsKey(key)) {
				this.discountPercent = System.Convert.ToDecimal( map[key] );
			}
			key = prefix + "discountAmount";
			if (map.ContainsKey(key)) {
				this.discountAmount = System.Convert.ToDecimal( map[key] );
			}
			key = prefix + "terms";
			if (map.ContainsKey(key)) {
				this.terms = map[key];
			}
			key = prefix + "note";
			if (map.ContainsKey(key)) {
				this.note = map[key];
			}
			key = prefix + "merchantMemo";
			if (map.ContainsKey(key)) {
				this.merchantMemo = map[key];
			}
			key = prefix + "billingInfo";
			if (map.ContainsKey(key + ".firstName")) {
				this.billingInfo = new BusinessInfoType(map, key + '.');
			}
			key = prefix + "shippingInfo";
			if (map.ContainsKey(key + ".firstName")) {
				this.shippingInfo = new BusinessInfoType(map, key + '.');
			}
			key = prefix + "shippingAmount";
			if (map.ContainsKey(key)) {
				this.shippingAmount = System.Convert.ToDecimal( map[key] );
			}
			key = prefix + "shippingTaxName";
			if (map.ContainsKey(key)) {
				this.shippingTaxName = map[key];
			}
			key = prefix + "shippingTaxRate";
			if (map.ContainsKey(key)) {
				this.shippingTaxRate = System.Convert.ToDecimal( map[key] );
			}
			key = prefix + "logoUrl";
			if (map.ContainsKey(key)) {
				this.logoUrl = map[key];
			}
			key = prefix + "referrerCode";
			if (map.ContainsKey(key)) {
				this.referrerCode = map[key];
			}
			key = prefix + "customAmountLabel";
			if (map.ContainsKey(key)) {
				this.customAmountLabel = map[key];
			}
			key = prefix + "customAmountValue";
			if (map.ContainsKey(key)) {
				this.customAmountValue = System.Convert.ToDecimal( map[key] );
			}
		}
	}


	/**
	 * The request object for MarkInvoiceAsPaid.
	 */
	public partial class MarkInvoiceAsPaidRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * ID of the invoice to mark as paid.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * Details of the payment made against this invoice.
		 */
		private OtherPaymentDetailsType paymentField;
		public OtherPaymentDetailsType payment {
			get {
				return this.paymentField;
			}
			set {
				this.paymentField = value;
			}
		}

		public MarkInvoiceAsPaidRequest(RequestEnvelope requestEnvelope, string invoiceID, OtherPaymentDetailsType payment) {
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
			this.payment = payment;
		}
		public MarkInvoiceAsPaidRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null) {
				sb.Append(prefix).Append("invoiceID").Append('=').Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.payment != null) {
				string newPrefix = prefix + "payment" + '.';
				sb.Append(this.paymentField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for MarkInvoiceAsPaid.
	 */
	public partial class MarkInvoiceAsPaidResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * The paid invoice ID.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * The paid invoice number.
		 */
		private string invoiceNumberField;
		public string invoiceNumber {
			get {
				return this.invoiceNumberField;
			}
			set {
				this.invoiceNumberField = value;
			}
		}

		/**
		 * The URL which lead merchant to view the invoice details on web.
		 */
		private string invoiceURLField;
		public string invoiceURL {
			get {
				return this.invoiceURLField;
			}
			set {
				this.invoiceURLField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public MarkInvoiceAsPaidResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key)) {
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key)) {
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key)) {
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * The request object for MarkInvoiceAsRefunded.
	 */
	public partial class MarkInvoiceAsRefundedRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * ID of the invoice to mark as refunded.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * Details of the refund made against this invoice.
		 */
		private OtherPaymentRefundDetailsType refundDetailField;
		public OtherPaymentRefundDetailsType refundDetail {
			get {
				return this.refundDetailField;
			}
			set {
				this.refundDetailField = value;
			}
		}

		public MarkInvoiceAsRefundedRequest(RequestEnvelope requestEnvelope, string invoiceID, OtherPaymentRefundDetailsType refundDetail) {
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
			this.refundDetail = refundDetail;
		}
		public MarkInvoiceAsRefundedRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null) {
				sb.Append(prefix).Append("invoiceID").Append('=').Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.refundDetail != null) {
				string newPrefix = prefix + "refundDetail" + '.';
				sb.Append(this.refundDetailField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for MarkInvoiceAsRefunded.
	 */
	public partial class MarkInvoiceAsRefundedResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * The invoice ID of the invoice that was marked as refunded.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * The invoice number of the invoice that was marked as refunded.
		 */
		private string invoiceNumberField;
		public string invoiceNumber {
			get {
				return this.invoiceNumberField;
			}
			set {
				this.invoiceNumberField = value;
			}
		}

		/**
		 * The URL of the details page of the invoice that was marked as refunded.
		 */
		private string invoiceURLField;
		public string invoiceURL {
			get {
				return this.invoiceURLField;
			}
			set {
				this.invoiceURLField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public MarkInvoiceAsRefundedResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key)) {
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key)) {
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key)) {
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * The request object for MarkInvoiceAsUnpaid.
	 */
	public partial class MarkInvoiceAsUnpaidRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * ID of the invoice to mark as unpaid.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		public MarkInvoiceAsUnpaidRequest(RequestEnvelope requestEnvelope, string invoiceID) {
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
		}
		public MarkInvoiceAsUnpaidRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null) {
				sb.Append(prefix).Append("invoiceID").Append('=').Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for MarkInvoiceAsUnpaid.
	 */
	public partial class MarkInvoiceAsUnpaidResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * The invoice ID of the invoice that was marked as unpaid.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * The invoice number of the invoice that was marked as unpaid.
		 */
		private string invoiceNumberField;
		public string invoiceNumber {
			get {
				return this.invoiceNumberField;
			}
			set {
				this.invoiceNumberField = value;
			}
		}

		/**
		 * The URL of the details page of the invoice that was marked as unpaid.
		 */
		private string invoiceURLField;
		public string invoiceURL {
			get {
				return this.invoiceURLField;
			}
			set {
				this.invoiceURLField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public MarkInvoiceAsUnpaidResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key)) {
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key)) {
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key)) {
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	public enum OriginType {
[Description("Web")]WEB,
[Description("API")]API,
	}
	/**
	 * Offline payment details about the invoice.
	 */
	public partial class OtherPaymentDetailsType {

		/**
		 * Method used for the offline payment.
		 */
		private PaymentMethodsType? methodField;
		public PaymentMethodsType? method {
			get {
				return this.methodField;
			}
			set {
				this.methodField = value;
			}
		}

		/**
		 * Optional note associated with the payment.
		 */
		private string noteField;
		public string note {
			get {
				return this.noteField;
			}
			set {
				this.noteField = value;
			}
		}

		/**
		 * Date when the invoice was paid.
		 */
		private string dateField;
		public string date {
			get {
				return this.dateField;
			}
			set {
				this.dateField = value;
			}
		}

		public OtherPaymentDetailsType() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.method != null) {
				sb.Append(prefix).Append("method").Append('=').Append(EnumUtils.getDescription(method));
				sb.Append('&');
			}
			if (this.note != null) {
				sb.Append(prefix).Append("note").Append('=').Append(HttpUtility.UrlEncode(this.note, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.date != null) {
				sb.Append(prefix).Append("date").Append('=').Append(HttpUtility.UrlEncode(this.date, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	 public OtherPaymentDetailsType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "method";
			if (map.ContainsKey(key)) {
				this.method = (PaymentMethodsType)EnumUtils.getValue(map[key],typeof(PaymentMethodsType));;
			}
			key = prefix + "note";
			if (map.ContainsKey(key)) {
				this.note = map[key];
			}
			key = prefix + "date";
			if (map.ContainsKey(key)) {
				this.date = map[key];
			}
		}
	}


	/**
	 * Details of the refund made against this invoice.
	 */
	public partial class OtherPaymentRefundDetailsType {

		/**
		 * Optional note associated with the refund.
		 */
		private string noteField;
		public string note {
			get {
				return this.noteField;
			}
			set {
				this.noteField = value;
			}
		}

		/**
		 * Date when the invoice was marked as refunded. If the date is not specified, the current date and time is used as a default.
		 * In addition, the date must be after the payment date of the invoice.
		 */
		private string dateField;
		public string date {
			get {
				return this.dateField;
			}
			set {
				this.dateField = value;
			}
		}

		public OtherPaymentRefundDetailsType() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.note != null) {
				sb.Append(prefix).Append("note").Append('=').Append(HttpUtility.UrlEncode(this.note, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.date != null) {
				sb.Append(prefix).Append("date").Append('=').Append(HttpUtility.UrlEncode(this.date, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	 public OtherPaymentRefundDetailsType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "note";
			if (map.ContainsKey(key)) {
				this.note = map[key];
			}
			key = prefix + "date";
			if (map.ContainsKey(key)) {
				this.date = map[key];
			}
		}
	}


	/**
	 * PayPal payment details about the invoice.
	 */
	public partial class PayPalPaymentDetailsType {

		/**
		 * Transaction ID of the PayPal payment.
		 */
		private string transactionIDField;
		public string transactionID {
			get {
				return this.transactionIDField;
			}
			set {
				this.transactionIDField = value;
			}
		}

		/**
		 * Date when the invoice was paid.
		 */
		private string dateField;
		public string date {
			get {
				return this.dateField;
			}
			set {
				this.dateField = value;
			}
		}

	 public PayPalPaymentDetailsType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "transactionID";
			if (map.ContainsKey(key)) {
				this.transactionID = map[key];
			}
			key = prefix + "date";
			if (map.ContainsKey(key)) {
				this.date = map[key];
			}
		}
	}


	/**
	 * Details of the paypal refund made against this invoice.
	 */
	public partial class PayPalPaymentRefundDetailsType {

		/**
		 * Date when the invoice was marked as refunded by PayPal.
		 */
		private string dateField;
		public string date {
			get {
				return this.dateField;
			}
			set {
				this.dateField = value;
			}
		}

	 public PayPalPaymentRefundDetailsType(Dictionary<string, string> map, string prefix) {
				string key = prefix + "date" ;
			if (map.ContainsKey(key)) {
				this.date  = map[key];
			}
		}
	}


	/**
	 * Payment details about the invoice.
	 */
	public partial class PaymentDetailsType {

		/**
		 * True if the invoice was paid using PayPal.
		 */
		private bool? viaPayPalField;
		public bool? viaPayPal {
			get {
				return this.viaPayPalField;
			}
			set {
				this.viaPayPalField = value;
			}
		}

		/**
		 * PayPal payment details.
		 */
		private PayPalPaymentDetailsType paypalPaymentField;
		public PayPalPaymentDetailsType paypalPayment {
			get {
				return this.paypalPaymentField;
			}
			set {
				this.paypalPaymentField = value;
			}
		}

		/**
		 * Other payment details.
		 */
		private OtherPaymentDetailsType otherPaymentField;
		public OtherPaymentDetailsType otherPayment {
			get {
				return this.otherPaymentField;
			}
			set {
				this.otherPaymentField = value;
			}
		}

	 public PaymentDetailsType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "viaPayPal";
			if (map.ContainsKey(key)) {
				this.viaPayPal = System.Convert.ToBoolean( map[key] );
			}
			key = prefix + "paypalPayment";
			if (map.ContainsKey(key + ".transactionID")) {
				this.paypalPayment = new PayPalPaymentDetailsType(map, key + '.');
			}
			key = prefix + "otherPayment";
			if (map.ContainsKey(key + ".note")) {
				this.otherPayment = new OtherPaymentDetailsType(map, key + '.');
			}
		}
	}


	public enum PaymentMethodsType {
[Description("BankTransfer")]BANKTRANSFER,
[Description("Cash")]CASH,
[Description("Check")]CHECK,
[Description("CreditCard")]CREDITCARD,
[Description("DebitCard")]DEBITCARD,
[Description("Other")]OTHER,
[Description("PayPal")]PAYPAL,
[Description("WireTransfer")]WIRETRANSFER,
	}
	/**
	 * Payment refund details about the invoice.
	 */
	public partial class PaymentRefundDetailsType {

		/**
		 * True if the invoice was refunded using PayPal.
		 */
		private bool? viaPayPalField;
		public bool? viaPayPal {
			get {
				return this.viaPayPalField;
			}
			set {
				this.viaPayPalField = value;
			}
		}

		/**
		 * Other payment refund details.
		 */
		private PayPalPaymentRefundDetailsType paypalPaymentField;
		public PayPalPaymentRefundDetailsType paypalPayment {
			get {
				return this.paypalPaymentField;
			}
			set {
				this.paypalPaymentField = value;
			}
		}

		/**
		 * details.
		 */
		private OtherPaymentRefundDetailsType otherPaymentField;
		public OtherPaymentRefundDetailsType otherPayment {
			get {
				return this.otherPaymentField;
			}
			set {
				this.otherPaymentField = value;
			}
		}

	 public PaymentRefundDetailsType(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "viaPayPal";
			if (map.ContainsKey(key)) {
				this.viaPayPal = System.Convert.ToBoolean( map[key] );
			}
			key = prefix + "paypalPayment";
			if (map.ContainsKey(key)) {
				this.paypalPayment = new PayPalPaymentRefundDetailsType(map, key);
			}
			key = prefix + "otherPayment";
			if (map.ContainsKey(key + ".note")) {
				this.otherPayment = new OtherPaymentRefundDetailsType(map, key + '.');
			}
		}
	}


	public enum PaymentTermsType {
[Description("DueOnReceipt")]DUEONRECEIPT,
[Description("DueOnDateSpecified")]DUEONDATESPECIFIED,
[Description("Net10")]NET1,
[Description("Net15")]NET2,
[Description("Net30")]NET3,
[Description("Net45")]NET4,
	}
	/**
	 * This specifies the list of parameters with every
	 * request to the service.
	 */
	public partial class RequestEnvelope {

		/**
		 * This specifies the required detail level
		 * that is needed by a client application
		 * pertaining to a particular data
		 * component (e.g., Item, Transaction,
		 * etc.). The detail level is specified in
		 * the DetailLevelCodeType which has all
		 * the enumerated values of the detail
		 * level for each component.
		 */
		private DetailLevelCode? detailLevelField;
		public DetailLevelCode? detailLevel {
			get {
				return this.detailLevelField;
			}
			set {
				this.detailLevelField = value;
			}
		}

		/**
		 * This should be the standard RFC 3066
		 * language identification tag, e.g.,
		 * en_US.
		 */
		private string errorLanguageField;
		public string errorLanguage {
			get {
				return this.errorLanguageField;
			}
			set {
				this.errorLanguageField = value;
			}
		}

		public RequestEnvelope(string errorLanguage) {
			this.errorLanguage = errorLanguage;
		}
		public RequestEnvelope() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.detailLevel != null) {
				sb.Append(prefix).Append("detailLevel").Append('=').Append(EnumUtils.getDescription(detailLevel));
				sb.Append('&');
			}
			if (this.errorLanguage != null) {
				sb.Append(prefix).Append("errorLanguage").Append('=').Append(HttpUtility.UrlEncode(this.errorLanguage, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * This specifies a list of parameters with every
	 * response from a service.
	 */
	public partial class ResponseEnvelope {

		private string timestampField;
		public string timestamp {
			get {
				return this.timestampField;
			}
			set {
				this.timestampField = value;
			}
		}

		/**
		 * Application level acknowledgment code.
		 */
		private AckCode? ackField;
		public AckCode? ack {
			get {
				return this.ackField;
			}
			set {
				this.ackField = value;
			}
		}

		private string correlationIdField;
		public string correlationId {
			get {
				return this.correlationIdField;
			}
			set {
				this.correlationIdField = value;
			}
		}

		private string buildField;
		public string build {
			get {
				return this.buildField;
			}
			set {
				this.buildField = value;
			}
		}

	 public ResponseEnvelope(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "timestamp";
			if (map.ContainsKey(key)) {
				this.timestamp = map[key];
			}
			key = prefix + "ack";
			if (map.ContainsKey(key)) {
				this.ack = (AckCode)EnumUtils.getValue(map[key],typeof(AckCode));;
			}
			key = prefix + "correlationId";
			if (map.ContainsKey(key)) {
				this.correlationId = map[key];
			}
			key = prefix + "build";
			if (map.ContainsKey(key)) {
				this.build = map[key];
			}
		}
	}


	/**
	 * The request object for SearchInvoices.
	 */
	public partial class SearchInvoicesRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * Invoice creator's email.
		 */
		private string merchantEmailField;
		public string merchantEmail {
			get {
				return this.merchantEmailField;
			}
			set {
				this.merchantEmailField = value;
			}
		}

		/**
		 * Parameters constraining the search.
		 */
		private SearchParametersType parametersField;
		public SearchParametersType parameters {
			get {
				return this.parametersField;
			}
			set {
				this.parametersField = value;
			}
		}

		/**
		 * Page number of result set, starting with 1.
		 */
		private int? pageField;
		public int? page {
			get {
				return this.pageField;
			}
			set {
				this.pageField = value;
			}
		}

		/**
		 * Number of results per page, between 1 and 100.
		 */
		private int? pageSizeField;
		public int? pageSize {
			get {
				return this.pageSizeField;
			}
			set {
				this.pageSizeField = value;
			}
		}

		public SearchInvoicesRequest(RequestEnvelope requestEnvelope, string merchantEmail, SearchParametersType parameters, int? page, int? pageSize) {
			this.requestEnvelope = requestEnvelope;
			this.merchantEmail = merchantEmail;
			this.parameters = parameters;
			this.page = page;
			this.pageSize = pageSize;
		}
		public SearchInvoicesRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.merchantEmail != null) {
				sb.Append(prefix).Append("merchantEmail").Append('=').Append(HttpUtility.UrlEncode(this.merchantEmail, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.parameters != null) {
				string newPrefix = prefix + "parameters" + '.';
				sb.Append(this.parametersField.toNVPString(newPrefix));
			}
			if (this.page != null) {
				sb.Append(prefix).Append("page").Append('=').Append(this.page).Append('&');
			}
			if (this.pageSize != null) {
				sb.Append(prefix).Append("pageSize").Append('=').Append(this.pageSize).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for SearchInvoices.
	 */
	public partial class SearchInvoicesResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * Number of invoices that matched the search.
		 */
		private int? countField;
		public int? count {
			get {
				return this.countField;
			}
			set {
				this.countField = value;
			}
		}

		/**
		 * Page of invoice summaries that matched the search.
		 */
		private InvoiceSummaryListType invoiceListField;
		public InvoiceSummaryListType invoiceList {
			get {
				return this.invoiceListField;
			}
			set {
				this.invoiceListField = value;
			}
		}

		/**
		 * Page number of result set.
		 */
		private int? pageField;
		public int? page {
			get {
				return this.pageField;
			}
			set {
				this.pageField = value;
			}
		}

		/**
		 * True if another page of invoice summary results exists.
		 */
		private bool? hasNextPageField;
		public bool? hasNextPage {
			get {
				return this.hasNextPageField;
			}
			set {
				this.hasNextPageField = value;
			}
		}

		/**
		 * True if a previous page of invoice summary results exists.
		 */
		private bool? hasPreviousPageField;
		public bool? hasPreviousPage {
			get {
				return this.hasPreviousPageField;
			}
			set {
				this.hasPreviousPageField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public SearchInvoicesResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "count";
			if (map.ContainsKey(key)) {
				this.count = System.Convert.ToInt32( map[key] );
			}
			key = prefix + "invoiceList";
			if (map.ContainsKey(key + ".invoice(0).invoiceID")) {
				this.invoiceList = new InvoiceSummaryListType(map, key + '.');
			}
			key = prefix + "page";
			if (map.ContainsKey(key)) {
				this.page = System.Convert.ToInt32( map[key] );
			}
			key = prefix + "hasNextPage";
			if (map.ContainsKey(key)) {
				this.hasNextPage = System.Convert.ToBoolean( map[key] );
			}
			key = prefix + "hasPreviousPage";
			if (map.ContainsKey(key)) {
				this.hasPreviousPage = System.Convert.ToBoolean( map[key] );
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * Search parameters criteria.
	 */
	public partial class SearchParametersType {

		/**
		 * Email search string.
		 */
		private string emailField;
		public string email {
			get {
				return this.emailField;
			}
			set {
				this.emailField = value;
			}
		}

		/**
		 * Recipient search string.
		 */
		private string recipientNameField;
		public string recipientName {
			get {
				return this.recipientNameField;
			}
			set {
				this.recipientNameField = value;
			}
		}

		/**
		 * Company search string.
		 */
		private string businessNameField;
		public string businessName {
			get {
				return this.businessNameField;
			}
			set {
				this.businessNameField = value;
			}
		}

		/**
		 * Invoice number search string.
		 */
		private string invoiceNumberField;
		public string invoiceNumber {
			get {
				return this.invoiceNumberField;
			}
			set {
				this.invoiceNumberField = value;
			}
		}

		/**
		 * Invoice status search.
		 */
		private List<StatusType?> statusField = new List<StatusType?>();
		public List<StatusType?> status {
			get {
				return this.statusField;
			}
			set {
				this.statusField = value;
			}
		}

		/**
		 * Invoice amount search.  Specifies the smallest amount to be returned.
		 */
		private decimal? lowerAmountField;
		public decimal? lowerAmount {
			get {
				return this.lowerAmountField;
			}
			set {
				this.lowerAmountField = value;
			}
		}

		/**
		 * Invoice amount search.  Specifies the largest amount to be returned.
		 */
		private decimal? upperAmountField;
		public decimal? upperAmount {
			get {
				return this.upperAmountField;
			}
			set {
				this.upperAmountField = value;
			}
		}

		/**
		 * Currency used for lower and upper amounts.  Required when lowerAmount or upperAmount is specified.
		 */
		private string currencyCodeField;
		public string currencyCode {
			get {
				return this.currencyCodeField;
			}
			set {
				this.currencyCodeField = value;
			}
		}

		/**
		 * Invoice memo search string.
		 */
		private string memoField;
		public string memo {
			get {
				return this.memoField;
			}
			set {
				this.memoField = value;
			}
		}

		/**
		 * Whether the invoice was created via the website or via an API call.
		 */
		private OriginType? originField;
		public OriginType? origin {
			get {
				return this.originField;
			}
			set {
				this.originField = value;
			}
		}

		/**
		 * Invoice date range filter.
		 */
		private DateRangeType invoiceDateField;
		public DateRangeType invoiceDate {
			get {
				return this.invoiceDateField;
			}
			set {
				this.invoiceDateField = value;
			}
		}

		/**
		 * Invoice due date range filter.
		 */
		private DateRangeType dueDateField;
		public DateRangeType dueDate {
			get {
				return this.dueDateField;
			}
			set {
				this.dueDateField = value;
			}
		}

		/**
		 * Invoice payment date range filter.
		 */
		private DateRangeType paymentDateField;
		public DateRangeType paymentDate {
			get {
				return this.paymentDateField;
			}
			set {
				this.paymentDateField = value;
			}
		}

		/**
		 * Invoice creation date range filter.
		 */
		private DateRangeType creationDateField;
		public DateRangeType creationDate {
			get {
				return this.creationDateField;
			}
			set {
				this.creationDateField = value;
			}
		}

		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.email != null) {
				sb.Append(prefix).Append("email").Append('=').Append(HttpUtility.UrlEncode(this.email, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.recipientName != null) {
				sb.Append(prefix).Append("recipientName").Append('=').Append(HttpUtility.UrlEncode(this.recipientName, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.businessName != null) {
				sb.Append(prefix).Append("businessName").Append('=').Append(HttpUtility.UrlEncode(this.businessName, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.invoiceNumber != null) {
				sb.Append(prefix).Append("invoiceNumber").Append('=').Append(HttpUtility.UrlEncode(this.invoiceNumber, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			for (int i = 0; i < this.status.Count; i++) {
				if (this.status[i] != null) {
				sb.Append(prefix).Append("status").Append(i).Append(")=").Append(EnumUtils.getDescription(status[i]));
				sb.Append('&');
				}
			}
			if (this.lowerAmount != null) {
				sb.Append(prefix).Append("lowerAmount").Append('=').Append(this.lowerAmount).Append('&');
			}
			if (this.upperAmount != null) {
				sb.Append(prefix).Append("upperAmount").Append('=').Append(this.upperAmount).Append('&');
			}
			if (this.currencyCode != null) {
				sb.Append(prefix).Append("currencyCode").Append('=').Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.memo != null) {
				sb.Append(prefix).Append("memo").Append('=').Append(HttpUtility.UrlEncode(this.memo, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.origin != null) {
				sb.Append(prefix).Append("origin").Append('=').Append(EnumUtils.getDescription(origin));
				sb.Append('&');
			}
			if (this.invoiceDate != null) {
				string newPrefix = prefix + "invoiceDate" + '.';
				sb.Append(this.invoiceDateField.toNVPString(newPrefix));
			}
			if (this.dueDate != null) {
				string newPrefix = prefix + "dueDate" + '.';
				sb.Append(this.dueDateField.toNVPString(newPrefix));
			}
			if (this.paymentDate != null) {
				string newPrefix = prefix + "paymentDate" + '.';
				sb.Append(this.paymentDateField.toNVPString(newPrefix));
			}
			if (this.creationDate != null) {
				string newPrefix = prefix + "creationDate" + '.';
				sb.Append(this.creationDateField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

	}


	/**
	 * The request object for SendInvoice.
	 */
	public partial class SendInvoiceRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * ID of the invoice to send.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		public SendInvoiceRequest(RequestEnvelope requestEnvelope, string invoiceID) {
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
		}
		public SendInvoiceRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null) {
				sb.Append(prefix).Append("invoiceID").Append('=').Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for SendInvoice.
	 */
	public partial class SendInvoiceResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * The sent invoice's ID.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * The URL which lead merchant to view the invoice details on web.
		 */
		private string invoiceURLField;
		public string invoiceURL {
			get {
				return this.invoiceURLField;
			}
			set {
				this.invoiceURLField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public SendInvoiceResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key)) {
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key)) {
				this.invoiceURL = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	public enum StatusType {
[Description("Draft")]DRAFT,
[Description("Sent")]SENT,
[Description("Paid")]PAID,
[Description("MarkedAsPaid")]MARKEDASPAID,
[Description("Canceled")]CANCELED,
[Description("Refunded")]REFUNDED,
[Description("PartiallyRefunded")]PARTIALLYREFUNDED,
[Description("MarkedAsRefunded")]MARKEDASREFUNDED,
	}
	/**
	 * The request object for UpdateInvoice.
	 */
	public partial class UpdateInvoiceRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * invoice's ID
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * Data to populate the newly created invoice.
		 */
		private InvoiceType invoiceField;
		public InvoiceType invoice {
			get {
				return this.invoiceField;
			}
			set {
				this.invoiceField = value;
			}
		}

		public UpdateInvoiceRequest(RequestEnvelope requestEnvelope, string invoiceID, InvoiceType invoice) {
			this.requestEnvelope = requestEnvelope;
			this.invoiceID = invoiceID;
			this.invoice = invoice;
		}
		public UpdateInvoiceRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.invoiceID != null) {
				sb.Append(prefix).Append("invoiceID").Append('=').Append(HttpUtility.UrlEncode(this.invoiceID, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.invoice != null) {
				string newPrefix = prefix + "invoice" + '.';
				sb.Append(this.invoiceField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

	}


	/**
	 * The response object for UpdateInvoice.
	 */
	public partial class UpdateInvoiceResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * The invoice's ID.
		 */
		private string invoiceIDField;
		public string invoiceID {
			get {
				return this.invoiceIDField;
			}
			set {
				this.invoiceIDField = value;
			}
		}

		/**
		 * The updated invoice's number.
		 */
		private string invoiceNumberField;
		public string invoiceNumber {
			get {
				return this.invoiceNumberField;
			}
			set {
				this.invoiceNumberField = value;
			}
		}

		/**
		 * The URL which lead merchant to view the invoice details on web.
		 */
		private string invoiceURLField;
		public string invoiceURL {
			get {
				return this.invoiceURLField;
			}
			set {
				this.invoiceURLField = value;
			}
		}

		/**
		 * The total amount of the invoice (cost of items, shipping and tax, less any discount).
		 */
		private int? totalAmountField;
		public int? totalAmount {
			get {
				return this.totalAmountField;
			}
			set {
				this.totalAmountField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public UpdateInvoiceResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "invoiceID";
			if (map.ContainsKey(key)) {
				this.invoiceID = map[key];
			}
			key = prefix + "invoiceNumber";
			if (map.ContainsKey(key)) {
				this.invoiceNumber = map[key];
			}
			key = prefix + "invoiceURL";
			if (map.ContainsKey(key)) {
				this.invoiceURL = map[key];
			}
			key = prefix + "totalAmount";
			if (map.ContainsKey(key)) {
				this.totalAmount = System.Convert.ToInt32( map[key] );
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


}
