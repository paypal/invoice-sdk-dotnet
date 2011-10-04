<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestPermissions.aspx.cs" Inherits="InvoicingSampleApp.RequestPermissions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Request Permissions</title>
</head>
<body>
    <form id="form1" runat="server" action="InvoiceHandler.ashx">
    <div>
    	<div class="param_name">request_token</div>
	<div class="param_value"><input type="text" name="txtrequest_token" size="50" maxlength="260" id="txtrequest_token" runat="server"/></div>
	<div class="param_name">verification_code</div>
	<div class="param_value"><input type="text" name="txtverification_code" size="50" maxlength="260" id="txtverification_code" runat="server"/><br />
        <input name="InvoiceBtn" type="submit" value="GetAccessToken" /><br />
        &nbsp;</div>

    </div>
    </form>
</body>
</html>
