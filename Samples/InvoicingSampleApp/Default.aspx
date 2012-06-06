<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InvoicingSampleApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>PayPal Invoicing SDK Samples Home</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />
    <script type="text/javascript" src="sdk.js"></script>    
</head>
<body>
    <h4>PayPal Invoicing SDK Samples Home</h4>
    <h5>SDK v<asp:Label ID="sdkVersion" runat="server" /></h5>
    <form id="form1" runat="server">    
    <div>        
        <ul>
            <li><a href="createinvoice.aspx">Create Invoice</a> </li>
            <li><a href="sendinvoice.aspx">Send Invoice</a></li>            
            <li><a href="createinvoice.aspx">Create and Send Invoice</a></li>            
            <li><a href="updateinvoice.aspx">Update Invoice</a></li>
            <li><a href="getinvoicedetails.aspx">Get Invoice Details</a></li>            
            <li><a href="cancelinvoice.aspx">Cancel Invoice</a></li>            
            <li><a href="searchinvoices.aspx">Search Invoices</a></li>
            <li><a href="markinvoiceaspaid.aspx">Mark Invoice As Paid</a></li>
            <li><a href="markinvoiceasunpaid.aspx">Mark Invoice As Unpaid</a></li>
            <li><a href="markinvoiceasrefunded.aspx">Mark Invoice As Refunded</a></li>
        </ul>
    </div>
    </form>
</body>
</html>
