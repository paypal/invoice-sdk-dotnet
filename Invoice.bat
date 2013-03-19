call "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\devenv.com" PayPalInvoiceSDK\PayPalInvoiceSDK.sln /build Release

copy /Y PayPalInvoiceSDK\bin\Release\PayPalInvoiceSDK.dll Samples\InvoiceSampleApp\lib\. 
copy /Y PayPalInvoiceSDK\bin\Release\PayPalInvoiceSDK.XML Samples\InvoiceSampleApp\lib\. 
