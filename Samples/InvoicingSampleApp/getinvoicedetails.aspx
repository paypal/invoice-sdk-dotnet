<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getinvoicedetails.aspx.cs" Inherits="InvoicingSampleApp.getinvoicedetails" %>
<%@ Register TagPrefix="uc" TagName="Permissions" Src="permissions.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>PayPal Invoicing SDK - GetInvoiceDetails Sample Page</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />
    <script type="text/javascript" src="sdk.js"></script>    
</head>
<body>
    <h2>GetInvoiceDetails API Sample Page</h2>
    <div id="apidetails">The GetInvoiceDetails API operation is used to get detailed information about 
    an invoice.</div>
    <form id="form2" runat="server" action="InvoiceHandler.ashx">
    	<div class="params">
	        <div class="param_name">InvoiceID * (Get Invoice ID via <a href='createinvoice.aspx'>CreateInvoice
						or CreateAndSendInvoice </a>)</div>
	        <div class="param_value"><input type="text" name="invoiceId" value=""/></div>
            <uc:Permissions id="permission" runat="server"/>
        </div>        
		<div class="submit">
			<input type="submit" name="invoiceBtn" value="GetInvoiceDetails" /> <br />
		</div>	    
    </form>
    <a href="Default.aspx">Home</a>    
</body>
</html>
