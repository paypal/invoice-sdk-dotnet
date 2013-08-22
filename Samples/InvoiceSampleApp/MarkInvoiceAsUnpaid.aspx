<%@ Page Language="C#" AutoEventWireup="true" Codebehind="MarkInvoiceAsUnpaid.aspx.cs"
    Inherits="InvoicingSampleApp.MarkInvoiceAsUnpaid" %>

<%@ Register TagPrefix="uc" TagName="Permissions" Src="RequestPermission.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>PayPal Invoice SDK - MarkInvoiceAsPaid Sample Page</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />

    <script type="text/javascript" src="sdk.js"></script>

</head>
<body>
	<img src="https://devtools-paypal.com/image/bdg_payments_by_pp_2line.png" alt="PAYMENTS BY PayPal" />
    <h2>
        MarkInvoiceAsUnpaid API Sample Page</h2>
    <div id="apidetails">
        The MarkInvoiceAsUnpaid API operation is used to mark an invoice as unpaid.</div>
    <form id="form2" runat="server" action="InvoiceHandler.ashx">
        <div id="request_form">
            <div class="params">
                <div class="param_name">
                    InvoiceID* (Get Invoice ID via <a href='CreateInvoice.aspx'>CreateAndSendInvoice</a>)
                </div>
                <div class="param_value">
                    <input type="text" name="invoiceId" value="" />
                </div>
            </div>
        </div>
        <div class="submit">
            <input type="submit" name="invoiceBtn" value="MarkInvoiceAsUnpaid" />
            <br />
        </div>
        <uc:Permissions ID="permission" runat="server" />
    </form>
    <a href="Default.aspx">Home</a>
</body>
</html>
