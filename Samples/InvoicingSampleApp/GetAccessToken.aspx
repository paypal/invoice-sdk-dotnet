<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetAccessToken.aspx.cs" Inherits="InvoicingSampleApp.GetAccessToken" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Get Access Token</title>
    <link rel="stylesheet" href="sdk.css" type="text/css" />
    <script type="text/javascript" src="sdk.js"></script>    
</head>
<body>
    <div class="overview">Step 2) Invoke the GetAccessToken API to obtain
     a token and token secret that represents the granted third party 
     permissions. The access token and secret returned by this API must 
     be stored securely for future use.<br/></div>
    <form id="form1" runat="server" action="InvoiceHandler.ashx">
    <div>
        <div class="param_name">request_token</div>
	    <div class="param_value">
	        <input type="text" name="txtrequest_token" size="50" maxlength="260" id="txtrequest_token" runat="server"/>
	    </div>
	    <div class="param_name">verification_code</div>
	    <div class="param_value">
	        <input type="text" name="txtverification_code" size="50" maxlength="260" id="txtverification_code" runat="server"/><br />            
        </div>
        <input type="hidden" runat="server" id="source" />
        <div class="submit">
            <input name="InvoiceBtn" type="submit" value="GetAccessToken" /><br />
        </div>
    </div>
    </form>
    <a href="Default.aspx">Home</a>    
</body>
</html>
