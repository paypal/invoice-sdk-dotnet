<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendInvoice.aspx.cs" Inherits="InvoicingSampleApp.SendInvoice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Send Invoice test page</title>
</head>
<body>

    <form id="form1" runat="server" action="InvoiceHandler.ashx">
    <div>
    <table>
    <tr><td>Invoice Id :<input type="text" name="invoiceId" value="" /></td></tr>
    <tr><td><input type="submit" name="InvoiceBtn" value="SendInvoice"/></td></tr>
    </table>
    </div>
    </form>

</body>
</html>
