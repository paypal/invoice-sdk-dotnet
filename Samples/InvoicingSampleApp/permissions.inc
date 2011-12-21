<div>
  <br/><br/><input type="checkbox" name="authentication" id="authentication" onclick="javascript: toggleDisplay('permissions');"/>
  <label for="authentication">Use Permission Credentials</label> <br/>
  <table id="permissions">
    <tr>
      <td class="left">
        <div class="param_name">Access Token</div>
        <div class="param_value">
	        <input type="text" name="accessToken" id="accessToken" value=""/>
        </div>
        <div class="param_name">Token Secret</div>
        <div class="param_value">
	        <input type="text" name="tokenSecret" value="" id="tokenSecret" />
        </div>
      </td>
      <td>
        <div>Obtain token</div>
        <div class="submit">
          <input type="submit" name="InvoiceBtn" value="RequestPermission"/>
        </div>
      </td>      
    </tr>
  </table>
  <br/>
</div>