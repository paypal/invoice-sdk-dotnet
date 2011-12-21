<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InvoicingSampleApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Invoicing Sample App</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />
    <script type="text/javascript" src="sdk.js"></script>    
</head>
<body>
    <h2>Invoicing API samples</h2>
    <form id="form1" runat="server">    
    <div>        
        <ul>
            <li><a href="createinvoice.aspx">Create Invoice</a> </li>
            <li><a href="createinvoice.aspx">Create and Send Invoice</a></li>
            <li><a href="sendinvoice.aspx">Send Invoice</a></li>
            <li><a href="getinvoicedetails.aspx">Get Invoice Details</a></li>
            <li><a href="markinvoiceaspaid.aspx">Mark Invoice As Paid</a></li>
            <li><a href="cancelinvoice.aspx">Cancel Invoice</a></li>
            <li><a href="updateinvoice.aspx">Update Invoice</a></li>
            <li><a href="searchinvoices.aspx">Search Invoices</a></li>
        </ul>
    </div>
    </form>
</body>
</html>
