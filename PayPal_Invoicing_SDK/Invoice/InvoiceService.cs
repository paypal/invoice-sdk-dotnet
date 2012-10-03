using System.Xml;
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
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest createInvoiceRequest, string apiUserName)
	 	{
			string response = Call("CreateInvoice", createInvoiceRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return CreateInvoiceResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest createInvoiceRequest)
	 	{
	 		return CreateInvoice(createInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest sendInvoiceRequest, string apiUserName)
	 	{
			string response = Call("SendInvoice", sendInvoiceRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return SendInvoiceResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SendInvoiceResponse SendInvoice(SendInvoiceRequest sendInvoiceRequest)
	 	{
	 		return SendInvoice(sendInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest createAndSendInvoiceRequest, string apiUserName)
	 	{
			string response = Call("CreateAndSendInvoice", createAndSendInvoiceRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return CreateAndSendInvoiceResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest createAndSendInvoiceRequest)
	 	{
	 		return CreateAndSendInvoice(createAndSendInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest updateInvoiceRequest, string apiUserName)
	 	{
			string response = Call("UpdateInvoice", updateInvoiceRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return UpdateInvoiceResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest updateInvoiceRequest)
	 	{
	 		return UpdateInvoice(updateInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest getInvoiceDetailsRequest, string apiUserName)
	 	{
			string response = Call("GetInvoiceDetails", getInvoiceDetailsRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetInvoiceDetailsResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest getInvoiceDetailsRequest)
	 	{
	 		return GetInvoiceDetails(getInvoiceDetailsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest cancelInvoiceRequest, string apiUserName)
	 	{
			string response = Call("CancelInvoice", cancelInvoiceRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return CancelInvoiceResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest cancelInvoiceRequest)
	 	{
	 		return CancelInvoice(cancelInvoiceRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest searchInvoicesRequest, string apiUserName)
	 	{
			string response = Call("SearchInvoices", searchInvoicesRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return SearchInvoicesResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest searchInvoicesRequest)
	 	{
	 		return SearchInvoices(searchInvoicesRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest markInvoiceAsPaidRequest, string apiUserName)
	 	{
			string response = Call("MarkInvoiceAsPaid", markInvoiceAsPaidRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsPaidResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest markInvoiceAsPaidRequest)
	 	{
	 		return MarkInvoiceAsPaid(markInvoiceAsPaidRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest markInvoiceAsUnpaidRequest, string apiUserName)
	 	{
			string response = Call("MarkInvoiceAsUnpaid", markInvoiceAsUnpaidRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsUnpaidResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest markInvoiceAsUnpaidRequest)
	 	{
	 		return MarkInvoiceAsUnpaid(markInvoiceAsUnpaidRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest markInvoiceAsRefundedRequest, string apiUserName)
	 	{
			string response = Call("MarkInvoiceAsRefunded", markInvoiceAsRefundedRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return MarkInvoiceAsRefundedResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest markInvoiceAsRefundedRequest)
	 	{
	 		return MarkInvoiceAsRefunded(markInvoiceAsRefundedRequest, null);
	 	}
	}
}
