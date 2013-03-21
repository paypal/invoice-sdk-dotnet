
# PayPal Invoice SDK

The PayPal Invoice API enables you to create and manage invoices. The PayPal Invoice SDK provides the following API operations:

   * CreateInvoice - Use the CreateInvoice API operation to create a new invoice. The call includes merchant, payer, and API caller information, in addition to invoice detail. The response to the call contains an invoice ID and URL.
   * CancelInvoice - Use the CancelInvoice API operation to cancel an invoice. 
   * CreateAndSendInvoice - Use the CreateAndSendInvoice API operation to create and send an invoice.
   * GetInvoiceDetails - Use the GetInvoiceDetails API operation to get detailed information about an invoice.
   * MarkInvoiceAsPaid - Use the MarkInvoiceAsPaid API operation to mark an invoice as paid. 
   * MarkInvoiceAsRefunded - Use the MarkInvoiceAsRefunded API operation to mark an invoice as refunded. This API operation canonly be used for full refunds.
   * MarkInvoiceAsUnpaid - Use the MarkInvoiceAsUnpaid API operation to mark an invoice as unpaid.
   * SearchInvoices - Use the SearchInvoice API operation to search an invoice.
   * SendInvoice - Use the SendInvoice API operation to send an invoice to a payer, and notify the payer of the pending invoice.
   * UpdateInvoice - Use the UpdateInvoice API operation to update an invoice.


## Prerequisites

   * Visual Studio 2005 or higher
   * .NET Framework 2.0 or higher
   * (Optional) NuGet 2.2 for managing dependencies

## Using the SDK

   To use the SDK in your application, you must
   
   * Get the PayPalInvoiceSDK dll via NuGet or from the download bundle and add references to the PayPalInvoiceSDK and PayPalCoreSDK libraries.
   * Additionally, if you want to use third party permissioning in your app, add a reference to the PayPalPermissionsSDK library.
   * Configure your app as detailed in the configuration section.
   
## SDK Configuration

  An application that uses the PayPal SDKs can be configured in one of two ways -
  
  * Using the Web.Config / App.Config files.

	```html
    <configSections>
	<section name="paypal" type="PayPal.Manager.SDKConfigHandler, PayPalCoreSDK" />
	<section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
	</configSections>
	<!-- PayPal SDK config -->
	<paypal>
	<settings>
	    <add name="mode" value="sandbox"/>	    
	    <add name="connectionTimeout" value="30000"/>
	    .....
	</settings>
	<accounts>
	    <account apiUsername="jb-us-seller_api1.paypal.com" apiPassword="..." apiSignature="..." applicationId='...' />
	    <account apiUsername="enduser_biz_api1.gmail.com" apiPassword="..." apiCertificate="..." privateKeyPassword="..." applicationId='...' />
	</accounts>
	</paypal>
    ```
  
  * Or, by dynamically passing in a dictionary (that you can load from a database or as suits your needs).

    ```csharp
    Dictionary<string, string> config = new Dictionary<string, string>();
    config.Add("mode", "sandbox");
    config.Add("account1.apiUsername", "jb-us-seller_api1.paypal.com");
    config.Add("account1.apiPassword", "...");
    config.Add("account1.apiSignature", "...");
    config.Add("account1.applicationId", "...");
    
    InvoiceService service = new  InvoiceService(config);
    ```

## Links

   * [Installing NuGet in Visual Studio 2005 & 2008] (https://github.com/paypal/sdk-core-dotnet/wiki/Using-Nuget-in-Visual-Studio-2005-&-2008)
   * [Installing NuGet in Visual Studio 2010 & 2012] (https://github.com/paypal/sdk-core-dotnet/wiki/Using-Nuget-in-Visual-Studio-2010-&-2012)
