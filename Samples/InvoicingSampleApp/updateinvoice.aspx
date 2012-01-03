<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateinvoice.aspx.cs" Inherits="InvoicingSampleApp.updateinvoice" %>
<%@ Register TagPrefix="uc" TagName="Permissions" Src="permissions.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>PayPal Invoicing SDK - UpdateInvoice Sample Page</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />
    <script type="text/javascript" src="sdk.js"></script>    
</head>
<body>
    <h2>UpdateInvoice API Sample Page</h2>
    <div id="apidetails">The UpdateInvoice API operation is used to update an invoice.</div>
    <form id="form2" runat="server" action="InvoiceHandler.ashx">
    	<div class="params">
	        <div class="param_name">InvoiceID * (Get Invoice ID via <a href='createinvoice.aspx'>CreateInvoice
						or CreateAndSendInvoice </a>)</div>
	        <div class="param_value"><input type="text" name="invoiceId" value=""/></div>
	        <div class="param_name">Merchant Email</div>
	        <div class="param_value"><input type="text" name="merchantEmail" value="jb-us-seller@paypal.com" /></div>
	        <div class="param_name">Payer Email</div>
	        <div class="param_value"><input type="text" name="payerEmail" value="sender@yahoo.com" /></div>
	        <div class="param_name">Item1 Name</div>
	        <div class="param_value"><input type="text" name="item_name1" value="item1" /></div>
	        <div class="param_name">Item1 Quantity</div>
	        <div class="param_value"><input type="text" name="item_quantity1" value="1" /></div>
	        <div class="param_name">Item1 Unit price</div>
	        <div class="param_value"><input type="text" name="item_unitPrice1" value="1.00" /></div>
	        <div class="param_name">Item2 Name</div>
	        <div class="param_value"><input type="text" name="item_name2" value="item2" /></div>
	        <div class="param_name">Item2 Quantity</div>
	        <div class="param_value"><input type="text" name="item_quantity2" value="2" /></div>
	        <div class="param_name">Item2 Unit price</div>
	        <div class="param_value"><input type="text" name="item_unitPrice2" value="2.00"/></div>
	        <div class="param_name">Currency Code</div>
	        <div class="param_value"><input type="text" name="currencyCode" value="USD" /></div>
	        <div class="param_name">Payment Terms</div>
	        <div class="param_value"><input type="text" name="paymentTerms" value="DUEONRECEIPT" /></div>	        	        
            <uc:Permissions id="permission" runat="server"/>
        </div>        
		<div class="submit">
			<input type="submit" name="invoiceBtn" value="UpdateInvoice" /> <br />
		</div>	    
    </form>
    <a href="Default.aspx">Home</a>
</body>
</html>
