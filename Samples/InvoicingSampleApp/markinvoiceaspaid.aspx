<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="markinvoiceaspaid.aspx.cs" Inherits="InvoicingSampleApp.markinvoiceaspaid" %>
<%@ Register TagPrefix="uc" TagName="Permissions" Src="permissions.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>PayPal Invoicing SDK - MarkInvoiceAsPaid Sample Page</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />
    <script type="text/javascript" src="sdk.js"></script>      
</head>
<body>
    <h2>MarkInvoiceAsPaid API Sample Page</h2>
    <div id="apidetails">The MarkInvoiceAsPaid API operation is used to mark an invoice as paid.</div>
    <form id="form2" runat="server" action="InvoiceHandler.ashx">
		<div id="request_form">
			<div class="params">
				<div class="param_name">
					InvoiceID* (Get Invoice ID via <a href='createinvoice.aspx'>CreateAndSendInvoice</a>)
				</div>
				<div class="param_value">
					<input type="text" name="invoiceId" value="" />
				</div>
			</div>
			<div class="section_header">Other Payment Details *</div>
			<div class="params">
				<div class="param_name">Payment Method used for offline payment</div>
				<div class="param_value">
					<select name="paymentMethod">
						<option value="BANKTRANSFER">BankTransfer</option>
						<option value="CASH">Cash</option>
						<option value="CHECK">Check</option>
						<option value="CREDITCARD">CreditCard</option>
						<option value="DEBITCARD">DebitCard</option>
						<option value="PAYPAL">PayPal</option>
						<option value="WIRETRANSFER">WireTransfer</option>
						<option value="OTHER">Other</option>
					</select>
				</div>
			</div>
			<div class="params">
				<div class="param_name">Note</div>
				<div class="param_value">
					<input type="text" name="note" value="" />
				</div>
			</div>
			<div class="params">
				<div class="param_name">Date when the invoice is paid</div>
				<div class="param_value">
					<input type="text" name="paymentDate" value="2011-12-20T02:56:08" />
				</div>
			</div>
        </div>
		<div class="submit">
			<input type="submit" name="invoiceBtn" value="MarkInvoiceAsPaid" /> <br />
		</div>			
        <uc:Permissions id="permission" runat="server"/>
    </form>
    <a href="Default.aspx">Home</a>
</body>
</html>