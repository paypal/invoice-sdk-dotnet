using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.Invoice.Model;

namespace PayPal.Invoice {
	public partial class InvoiceService : BasePayPalService {

		// Service Version
		private static string ServiceVersion = "1.6.0";

		// Service Name
		private static string ServiceName = "Invoice";

		public InvoiceService() : base(ServiceName, ServiceVersion)
		{
		}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest CreateInvoiceRequest, string apiUsername)
	 	{
			string resp = call("CreateInvoice", CreateInvoiceRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return CreateInvoiceResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest CreateInvoiceRequest)
	 	{
	 		return CreateInvoice(CreateInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest SendInvoiceRequest, string apiUsername)
	 	{
			string resp = call("SendInvoice", SendInvoiceRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return SendInvoiceResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest SendInvoiceRequest)
	 	{
	 		return SendInvoice(SendInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest CreateAndSendInvoiceRequest, string apiUsername)
	 	{
			string resp = call("CreateAndSendInvoice", CreateAndSendInvoiceRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return CreateAndSendInvoiceResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest CreateAndSendInvoiceRequest)
	 	{
	 		return CreateAndSendInvoice(CreateAndSendInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest UpdateInvoiceRequest, string apiUsername)
	 	{
			string resp = call("UpdateInvoice", UpdateInvoiceRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return UpdateInvoiceResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest UpdateInvoiceRequest)
	 	{
	 		return UpdateInvoice(UpdateInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest GetInvoiceDetailsRequest, string apiUsername)
	 	{
			string resp = call("GetInvoiceDetails", GetInvoiceDetailsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetInvoiceDetailsResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest GetInvoiceDetailsRequest)
	 	{
	 		return GetInvoiceDetails(GetInvoiceDetailsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest CancelInvoiceRequest, string apiUsername)
	 	{
			string resp = call("CancelInvoice", CancelInvoiceRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return CancelInvoiceResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest CancelInvoiceRequest)
	 	{
	 		return CancelInvoice(CancelInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest SearchInvoicesRequest, string apiUsername)
	 	{
			string resp = call("SearchInvoices", SearchInvoicesRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return SearchInvoicesResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest SearchInvoicesRequest)
	 	{
	 		return SearchInvoices(SearchInvoicesRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest MarkInvoiceAsPaidRequest, string apiUsername)
	 	{
			string resp = call("MarkInvoiceAsPaid", MarkInvoiceAsPaidRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsPaidResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest MarkInvoiceAsPaidRequest)
	 	{
	 		return MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest MarkInvoiceAsUnpaidRequest, string apiUsername)
	 	{
			string resp = call("MarkInvoiceAsUnpaid", MarkInvoiceAsUnpaidRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsUnpaidResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest MarkInvoiceAsUnpaidRequest)
	 	{
	 		return MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest MarkInvoiceAsRefundedRequest, string apiUsername)
	 	{
			string resp = call("MarkInvoiceAsRefunded", MarkInvoiceAsRefundedRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsRefundedResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest MarkInvoiceAsRefundedRequest)
	 	{
	 		return MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest, null);
	 	}
	}
}
