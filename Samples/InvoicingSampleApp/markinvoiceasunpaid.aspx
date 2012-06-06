<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="markinvoiceasunpaid.aspx.cs" Inherits="InvoicingSampleApp.markinvoiceasunpaid" %>
<%@ Register TagPrefix="uc" TagName="Permissions" Src="permissions.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>PayPal Invoicing SDK - MarkInvoiceAsPaid Sample Page</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />
    <script type="text/javascript" src="sdk.js"></script>      
</head>
<body>
    <h2>MarkInvoiceAsUnpaid API Sample Page</h2>
    <div id="apidetails">The MarkInvoiceAsUnpaid API operation is used to mark an invoice as unpaid.</div>
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
        </div>
		<div class="submit">
			<input type="submit" name="invoiceBtn" value="MarkInvoiceAsUnpaid" /> <br />
		</div>			
        <uc:Permissions id="permission" runat="server"/>
    </form>
    <a href="Default.aspx">Home</a>
</body>
</html>