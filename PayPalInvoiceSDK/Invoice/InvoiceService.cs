using System;
using System.Collections.Generic;
using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.NVP;
using PayPal.Invoice.Model;

namespace PayPal.Invoice 
{
	public partial class InvoiceService : BasePayPalService 
	{

		/// <summary>
		/// Service Version
		/// </summary>
		private const string ServiceVersion = "1.10.0";

		/// <summary>
		/// Service Name
		/// </summary>
		private const string ServiceName = "Invoice";
		
		/// <summary>
		/// SDK Name
		/// </summary>
		private const string SDKName = "invoice-dotnet-sdk";
	
		/// <summary>
		/// SDK Version
		/// </summary>
		private const string SDKVersion = "2.4.106";

		/// <summary>
		/// Default constructor for loading configuration from *.Config file
		/// </summary>
		public InvoiceService() : base() {}
		
		/// <summary>
		/// constructor for passing in a dynamic configuration object
		/// </summary>
		public InvoiceService(Dictionary<string, string> config) : base(config) {}
		

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="createInvoiceRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest createInvoiceRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, createInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CreateInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return CreateInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="createInvoiceRequest"></param>
	 	
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest createInvoiceRequest)
	 	{
	 		return CreateInvoice(createInvoiceRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="createInvoiceRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest createInvoiceRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, createInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CreateInvoice", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return CreateInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="sendInvoiceRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest sendInvoiceRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, sendInvoiceRequest.ToNVPString(string.Empty), ServiceName, "SendInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return SendInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="sendInvoiceRequest"></param>
	 	
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest sendInvoiceRequest)
	 	{
	 		return SendInvoice(sendInvoiceRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="sendInvoiceRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest sendInvoiceRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, sendInvoiceRequest.ToNVPString(string.Empty), ServiceName, "SendInvoice", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return SendInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="remindInvoiceRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public RemindInvoiceResponse RemindInvoice(RemindInvoiceRequest remindInvoiceRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, remindInvoiceRequest.ToNVPString(string.Empty), ServiceName, "RemindInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return RemindInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="remindInvoiceRequest"></param>
	 	
	 	public RemindInvoiceResponse RemindInvoice(RemindInvoiceRequest remindInvoiceRequest)
	 	{
	 		return RemindInvoice(remindInvoiceRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="remindInvoiceRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public RemindInvoiceResponse RemindInvoice(RemindInvoiceRequest remindInvoiceRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, remindInvoiceRequest.ToNVPString(string.Empty), ServiceName, "RemindInvoice", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return RemindInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="createAndSendInvoiceRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest createAndSendInvoiceRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, createAndSendInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CreateAndSendInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return CreateAndSendInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="createAndSendInvoiceRequest"></param>
	 	
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest createAndSendInvoiceRequest)
	 	{
	 		return CreateAndSendInvoice(createAndSendInvoiceRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="createAndSendInvoiceRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest createAndSendInvoiceRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, createAndSendInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CreateAndSendInvoice", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return CreateAndSendInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="updateInvoiceRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest updateInvoiceRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, updateInvoiceRequest.ToNVPString(string.Empty), ServiceName, "UpdateInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return UpdateInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="updateInvoiceRequest"></param>
	 	
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest updateInvoiceRequest)
	 	{
	 		return UpdateInvoice(updateInvoiceRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="updateInvoiceRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest updateInvoiceRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, updateInvoiceRequest.ToNVPString(string.Empty), ServiceName, "UpdateInvoice", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return UpdateInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="getInvoiceDetailsRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest getInvoiceDetailsRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getInvoiceDetailsRequest.ToNVPString(string.Empty), ServiceName, "GetInvoiceDetails", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return GetInvoiceDetailsResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="getInvoiceDetailsRequest"></param>
	 	
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest getInvoiceDetailsRequest)
	 	{
	 		return GetInvoiceDetails(getInvoiceDetailsRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="getInvoiceDetailsRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest getInvoiceDetailsRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getInvoiceDetailsRequest.ToNVPString(string.Empty), ServiceName, "GetInvoiceDetails", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return GetInvoiceDetailsResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="cancelInvoiceRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest cancelInvoiceRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, cancelInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CancelInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return CancelInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="cancelInvoiceRequest"></param>
	 	
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest cancelInvoiceRequest)
	 	{
	 		return CancelInvoice(cancelInvoiceRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="cancelInvoiceRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest cancelInvoiceRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, cancelInvoiceRequest.ToNVPString(string.Empty), ServiceName, "CancelInvoice", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return CancelInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="searchInvoicesRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest searchInvoicesRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, searchInvoicesRequest.ToNVPString(string.Empty), ServiceName, "SearchInvoices", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return SearchInvoicesResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="searchInvoicesRequest"></param>
	 	
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest searchInvoicesRequest)
	 	{
	 		return SearchInvoices(searchInvoicesRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="searchInvoicesRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest searchInvoicesRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, searchInvoicesRequest.ToNVPString(string.Empty), ServiceName, "SearchInvoices", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return SearchInvoicesResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="markInvoiceAsPaidRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest markInvoiceAsPaidRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, markInvoiceAsPaidRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsPaid", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsPaidResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="markInvoiceAsPaidRequest"></param>
	 	
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest markInvoiceAsPaidRequest)
	 	{
	 		return MarkInvoiceAsPaid(markInvoiceAsPaidRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="markInvoiceAsPaidRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest markInvoiceAsPaidRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, markInvoiceAsPaidRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsPaid", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsPaidResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="markInvoiceAsUnpaidRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest markInvoiceAsUnpaidRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, markInvoiceAsUnpaidRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsUnpaid", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsUnpaidResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="markInvoiceAsUnpaidRequest"></param>
	 	
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest markInvoiceAsUnpaidRequest)
	 	{
	 		return MarkInvoiceAsUnpaid(markInvoiceAsUnpaidRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="markInvoiceAsUnpaidRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest markInvoiceAsUnpaidRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, markInvoiceAsUnpaidRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsUnpaid", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsUnpaidResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="markInvoiceAsRefundedRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest markInvoiceAsRefundedRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, markInvoiceAsRefundedRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsRefunded", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsRefundedResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="markInvoiceAsRefundedRequest"></param>
	 	
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest markInvoiceAsRefundedRequest)
	 	{
	 		return MarkInvoiceAsRefunded(markInvoiceAsRefundedRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="markInvoiceAsRefundedRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest markInvoiceAsRefundedRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, markInvoiceAsRefundedRequest.ToNVPString(string.Empty), ServiceName, "MarkInvoiceAsRefunded", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsRefundedResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="deleteInvoiceRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public DeleteInvoiceResponse DeleteInvoice(DeleteInvoiceRequest deleteInvoiceRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, deleteInvoiceRequest.ToNVPString(string.Empty), ServiceName, "DeleteInvoice", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";
			
			NVPUtil util = new NVPUtil();
			return DeleteInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="deleteInvoiceRequest"></param>
	 	
	 	public DeleteInvoiceResponse DeleteInvoice(DeleteInvoiceRequest deleteInvoiceRequest)
	 	{
	 		return DeleteInvoice(deleteInvoiceRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="deleteInvoiceRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public DeleteInvoiceResponse DeleteInvoice(DeleteInvoiceRequest deleteInvoiceRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, deleteInvoiceRequest.ToNVPString(string.Empty), ServiceName, "DeleteInvoice", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Invoice";

			NVPUtil util = new NVPUtil();
			return DeleteInvoiceResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	}
}
