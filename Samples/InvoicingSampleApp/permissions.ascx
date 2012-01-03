<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="permissions.ascx.cs" Inherits="InvoicingSampleApp.WebUserControl1" %>
<div>
  <br/><br/>
  <input type="checkbox" id="authentication" runat="server" />
  <label for="authentication">Use Permission Credentials</label> <br/>
  <asp:Panel ID="permissions" runat="server">
  <div class="overview">
    The PayPal Permissions API allows you to request and obtain 
    permissions to execute one or more APIs on behalf of your customers
    (third party). The granted permission is represented by a access 
    token and token secret pair that you must store securely.
   </div>
  <table id="permissionsdata">
    <tr>
      <td class="left">
        <div class="param_name">Access Token</div>
        <div class="param_value">
            <asp:TextBox id="accessToken" runat="server"/>
        </div>
        <div class="param_name">Token Secret</div>
        <div class="param_value">
	        <asp:TextBox id="tokenSecret" runat="server" />
        </div>
      </td>
      <td>
        <div> Obtain token </div>
        <div class="submit">
          <input type="submit" name="InvoiceBtn" value="RequestPermission"/>
        </div>
      </td>      
    </tr>
  </table>
  </asp:Panel>
  <br/>
</div>