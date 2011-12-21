<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateInvoice.aspx.cs" Inherits="InvoicingSampleApp.CreateInvoice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PayPal Invoicing SDK - CreateInvoice Sample Page</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />
    <script type="text/javascript" src="sdk.js"></script>    
</head>
<body>

<h2>CreateInvoice API Sample Page</h2>

   <form id="form2" runat="server" action="InvoiceHandler.ashx">
	<div class="params">
	    <div class="param_name">Merchant Email</div>
	    <div class="param_value"><input type="text" name="merchantEmail" value="jb-us-seller@paypal.com" size="50" maxlength="260"/></div>
	    <div class="param_name">Payer Email</div>
	    <div class="param_value"><input type="text" name="payerEmail" value="sender@yahoo.com" size="50" maxlength="260"/></div>
	    <div class="param_name">Item Name1</div>
	    <div class="param_value"><input type="text" name="item_name1" value="item1" size="30" maxlength="30"/></div>
	    <div class="param_name">Item Quantity1</div>
	    <div class="param_value"><input type="text" name="item_quantity1" value="1" size="3" maxlength="5"/></div>
	    <div class="param_name">Item UnitPrice1</div>
	    <div class="param_value"><input type="text" name="item_unitPrice1" value="1.00" size="10" maxlength="19"/></div>
	    <div class="param_name">Item Name2</div>
	    <div class="param_value"><input type="text" name="item_name2" value="item2" size="30" maxlength="30"/></div>
	    <div class="param_name">Item Quantity2</div>
	    <div class="param_value"><input type="text" name="item_quantity2" value="2" size="3" maxlength="5"/></div>
	    <div class="param_name">Item UnitPrice2</div>
	    <div class="param_value"><input type="text" name="item_unitPrice2" value="2.00" size="10" maxlength="19"/></div>
	    <div class="param_name">Currency Code</div>
	    <div class="param_value"><input type="text" name="currencyCode" value="USD" size="50" maxlength="260"/></div>
	    <div class="param_name">Payment Terms</div>
	    <div class="param_value"><input type="text" name="paymentTerms" value="DueOnReceipt" size="50" maxlength="260"/></div>
	    <!--#include file="permissions.inc"-->        
	</div>
    <div class="submit">
        <input type="hidden" name="radioCall" value="CreateInvoice" />
	    <input type="submit" name="InvoiceBtn" value="CreateInvoice"/>    
        <input type="submit" name="InvoiceBtn" value="CreateAndSendInvoice"/>
    </div>
</form>
<a href="Default.aspx">Home</a>
</body>
</html>
