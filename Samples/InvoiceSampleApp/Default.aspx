<%@ Page Language="C#" AutoEventWireup="true" Codebehind="Default.aspx.cs" Inherits="InvoicingSampleApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PayPal Invoice SDK Samples Home</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />

    <script type="text/javascript" src="sdk.js"></script>

</head>
<body>
    <h4>
        PayPal Invoice SDK Samples Home</h4>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a href="CreateInvoice.aspx">Create Invoice</a> </li>
                <li><a href="SendInvoice.aspx">Send Invoice</a></li>
                <li><a href="CreateInvoice.aspx">Create and Send Invoice</a></li>
                <li><a href="UpdateInvoice.aspx">Update Invoice</a></li>
                <li><a href="GetInvoiceDetails.aspx">Get Invoice Details</a></li>
                <li><a href="CancelInvoice.aspx">Cancel Invoice</a></li>
                <li><a href="SearchInvoices.aspx">Search Invoices</a></li>
                <li><a href="MarkInvoiceAsPaid.aspx">Mark Invoice As Paid</a></li>
                <li><a href="MarkInvoiceAsUnpaid.aspx">Mark Invoice As Unpaid</a></li>
                <li><a href="MarkInvoiceAsRefunded.aspx">Mark Invoice As Refunded</a></li>
            </ul>
        </div>
    </form>
</body>
</html>
