<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchinvoices.aspx.cs" Inherits="InvoicingSampleApp.searchinvoices" %>
<%@ Register TagPrefix="uc" TagName="Permissions" Src="permissions.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>PayPal Invoicing SDK - SearchInvoices Sample Page</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />
    <script type="text/javascript" src="sdk.js"></script>
</head>
<body>
    <h2>SearchInvoices API Sample Page</h2>
    <div id="apidetails">The SearchInvoice API operation is used to search for invoices that match given
    search criteria.</div>
    <form id="form2" runat="server" action="InvoiceHandler.ashx">
<%
    string searchStartDate = DateTime.Now.AddDays(-5).ToString("yyyy-MM-dd'T'HH:mm:ss");
    string searchEndDate = DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss");
%>    
        <div class="params">
			<div class="param_name">Merchant Email *</div>
			<div class="param_value">
				<input type="text" name="merchantEmail" value="jb-us-seller@paypal.com" />
			</div>
			
			<!-- Search criteria -->
			<div class="param_name">Email</div>
			<div class="param_value">
				<input type="text" name="email" value="sender@yahoo.com" />
			</div>
			<div class="param_name">Recipient name</div>
			<div class="param_value">
				<input type="text" name="recipientName" value="" />
			</div>
			<div class="param_name">Business name</div>
			<div class="param_value">
				<input type="text" name="businessName" value="" />
			</div>
			<div class="param_name">Invoice number</div>
			<div class="param_value">
				<input type="text" name="invoiceNumber" value="" />
			</div>
			<div class="param_name">Status (Provide upto 10 different status types)</div>
			<div class="param_value">
				<select name="status0">
				    <option value="">--Select a value--</option>
				    <option value="DRAFT">Draft</option>
				    <option value="SENT">Sent</option>
				    <option value="PAID">Paid</option>
				    <option value="MARKEDASPAID">MarkedAsPaid</option>
				    <option value="CANCELED">Canceled</option>
				</select>
				 (Or) 
				<select name="status1">
				    <option value="">--Select a value--</option>
				    <option value="DRAFT">Draft</option>
				    <option value="SENT">Sent</option>
				    <option value="PAID">Paid</option>
				    <option value="MARKEDASPAID">MarkedAsPaid</option>
				    <option value="CANCELED">Canceled</option>
				</select>
				 (Or) 
				<select name="status2">
				    <option value="">--Select a value--</option>
				    <option value="DRAFT">Draft</option>
				    <option value="SENT">Sent</option>
				    <option value="PAID">Paid</option>
				    <option value="MARKEDASPAID">MarkedAsPaid</option>
				    <option value="CANCELED">Canceled</option>
				</select>				
			</div>			
			<div class="param_name">Lowest invoice amount to match</div>
			<div class="param_value">
				<input type="text" name="lowerAmount" value="1.0" />
			</div>									
            <div class="param_name">Highest invoice amount to match</div>
			<div class="param_value">
				<input type="text" name="upperAmount" value="100.0" />
			</div>			
            <div class="param_name">Currency code</div>
			<div class="param_value">
				<input type="text" name="currencyCode" value="USD" />
			</div>
            <div class="param_name">Memo</div>
			<div class="param_value">
				<input type="text" name="memo" value="" />
			</div>
            <div class="param_name">Invoice origin</div>
			<div class="param_value">
				<select name="origin">
				    <option value="">--Select a value--</option>
				    <option value="WEB">Web</option>
				    <option value="API">API</option>
				</select>
			</div>
            <div class="param_name">Invoice date ( Range: From & To)</div>
			<div class="param_value">
				<input type="text" name="invoiceDateStart" value="<%=searchStartDate%>" />
				<input type="text" name="invoiceDateEnd" value="<%=searchEndDate%>" />
			</div>
            <div class="param_name">Invoice due date ( Range: From & To)</div>
			<div class="param_value">
				<input type="text" name="dueDateStart" value="" />
				<input type="text" name="dueDateEnd" value="" />
			</div>
            <div class="param_name">Payment date ( Range: From & To)</div>
			<div class="param_value">
				<input type="text" name="paymentDateStart" value="" />
				<input type="text" name="paymentDateEnd" value="" />
			</div>
            <div class="param_name">Invoice creation date ( Range: From & To)</div>
			<div class="param_value">
				<input type="text" name="creationDateStart" value="" />
				<input type="text" name="creationDateEnd" value="" />
			</div>									
			<!-- Pagination constraints -->																		
			<div class="param_name">Page *</div>
			<div class="param_value">
				<input type="text" name="page" value="1"/>
			</div>
			<div class="param_name">Page size *</div>
			<div class="param_value">
				<input type="text" name="pageSize" value="10"/>
			</div>
			<uc:Permissions id="permission" runat="server"/>
		</div>		
		<div class="submit">
			<input type="submit" name="invoiceBtn" value="SearchInvoices" /> <br />
		</div>
    </form>
    <a href="Default.aspx">Home</a>
</body>
</html>
