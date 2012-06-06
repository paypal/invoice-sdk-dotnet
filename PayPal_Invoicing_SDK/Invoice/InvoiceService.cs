/** 
 * Auto generated code
 */

using PayPal.Authentication;

namespace PayPal.Invoice {

	using PayPal;
	using PayPal.Util;
	using PayPal.Manager;
	using PayPal.Invoice.Model;

	public partial class InvoiceService : BasePayPalService{

		private static string serviceName = "Invoice";
		private static string serviceVersion = "1.6.0";

		public InvoiceService() : base(serviceName, serviceVersion) {}
		/**
		 *
		 */
		public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest CreateInvoiceRequest, string apiUsername) 
		{
			string resp = call("CreateInvoice", CreateInvoiceRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new CreateInvoiceResponse(util.parseNVPString(resp), "");
		}

		public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest CreateInvoiceRequest) 
		{
			return CreateInvoice(CreateInvoiceRequest, null);
		}
		/**
		 *
		 */
		public SendInvoiceResponse SendInvoice(SendInvoiceRequest SendInvoiceRequest, string apiUsername) 
		{
			string resp = call("SendInvoice", SendInvoiceRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new SendInvoiceResponse(util.parseNVPString(resp), "");
		}

		public SendInvoiceResponse SendInvoice(SendInvoiceRequest SendInvoiceRequest) 
		{
			return SendInvoice(SendInvoiceRequest, null);
		}
		/**
		 *
		 */
		public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest CreateAndSendInvoiceRequest, string apiUsername) 
		{
			string resp = call("CreateAndSendInvoice", CreateAndSendInvoiceRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new CreateAndSendInvoiceResponse(util.parseNVPString(resp), "");
		}

		public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest CreateAndSendInvoiceRequest) 
		{
			return CreateAndSendInvoice(CreateAndSendInvoiceRequest, null);
		}
		/**
		 *
		 */
		public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest UpdateInvoiceRequest, string apiUsername) 
		{
			string resp = call("UpdateInvoice", UpdateInvoiceRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new UpdateInvoiceResponse(util.parseNVPString(resp), "");
		}

		public UpdateInvoiceResponse UpdateInvoice(UpdateInvoiceRequest UpdateInvoiceRequest) 
		{
			return UpdateInvoice(UpdateInvoiceRequest, null);
		}
		/**
		 *
		 */
		public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest GetInvoiceDetailsRequest, string apiUsername) 
		{
			string resp = call("GetInvoiceDetails", GetInvoiceDetailsRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetInvoiceDetailsResponse(util.parseNVPString(resp), "");
		}

		public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest GetInvoiceDetailsRequest) 
		{
			return GetInvoiceDetails(GetInvoiceDetailsRequest, null);
		}
		/**
		 *
		 */
		public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest CancelInvoiceRequest, string apiUsername) 
		{
			string resp = call("CancelInvoice", CancelInvoiceRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new CancelInvoiceResponse(util.parseNVPString(resp), "");
		}

		public CancelInvoiceResponse CancelInvoice(CancelInvoiceRequest CancelInvoiceRequest) 
		{
			return CancelInvoice(CancelInvoiceRequest, null);
		}
		/**
		 *
		 */
		public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest SearchInvoicesRequest, string apiUsername) 
		{
			string resp = call("SearchInvoices", SearchInvoicesRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new SearchInvoicesResponse(util.parseNVPString(resp), "");
		}

		public SearchInvoicesResponse SearchInvoices(SearchInvoicesRequest SearchInvoicesRequest) 
		{
			return SearchInvoices(SearchInvoicesRequest, null);
		}
		/**
		 *
		 */
		public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest MarkInvoiceAsPaidRequest, string apiUsername) 
		{
			string resp = call("MarkInvoiceAsPaid", MarkInvoiceAsPaidRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new MarkInvoiceAsPaidResponse(util.parseNVPString(resp), "");
		}

		public MarkInvoiceAsPaidResponse MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest MarkInvoiceAsPaidRequest) 
		{
			return MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest, null);
		}
		/**
		 *
		 */
		public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest MarkInvoiceAsUnpaidRequest, string apiUsername) 
		{
			string resp = call("MarkInvoiceAsUnpaid", MarkInvoiceAsUnpaidRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new MarkInvoiceAsUnpaidResponse(util.parseNVPString(resp), "");
		}

		public MarkInvoiceAsUnpaidResponse MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest MarkInvoiceAsUnpaidRequest) 
		{
			return MarkInvoiceAsUnpaid(MarkInvoiceAsUnpaidRequest, null);
		}
		/**
		 *
		 */
		public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest MarkInvoiceAsRefundedRequest, string apiUsername) 
		{
			string resp = call("MarkInvoiceAsRefunded", MarkInvoiceAsRefundedRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new MarkInvoiceAsRefundedResponse(util.parseNVPString(resp), "");
		}

		public MarkInvoiceAsRefundedResponse MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest MarkInvoiceAsRefundedRequest) 
		{
			return MarkInvoiceAsRefunded(MarkInvoiceAsRefundedRequest, null);
		}
	}
}

