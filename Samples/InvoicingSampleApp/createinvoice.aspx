<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateInvoice.aspx.cs" Inherits="InvoicingSampleApp.CreateInvoice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CreateInvoice Test Page</title>
</head>
<body>

<h2>CreateInvoice API Test Page</h2>

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
	</div>
	
	
			<input type="checkbox" name="authentication"/>Using Permission
		Credentials 
		<input type="submit" name="InvoiceBtn" value="RequestPermission"/>(Don't have permission
			credentials... Get it here...)<br />

		<div class="param_name">Access Token</div>
		<div class="param_value">
			<input type="text" name="accessToken"
				value=""
				size="50" maxlength="260" id="accessToken" runat="server" />
		</div>
		<div class="param_name">Token Secret</div>
		<div class="param_value">
			<input type="text" name="tokenSecret"
				value="" size="50" maxlength="260" id="tokenSecret" runat="server" />
		</div>

	
    <input type="hidden" name="radioCall" value="CreateInvoice" />
	<input type="submit" name="InvoiceBtn" value="CreateInvoice"/>
    <input type="submit" name="InvoiceBtn" value="CreateAndSendInvoice"/>
    

</form>

</body>
</html>
