call "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\devenv.com" PayPal_Invoicing_SDK.sln /build Release %1

copy /Y PayPal_Invoicing_SDK\bin\Release\PayPal_Invoicing_SDK.dll Samples\InvoicingSampleApp\lib\. 
