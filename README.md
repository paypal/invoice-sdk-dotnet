This repository contains .NET SDK and samples for Adaptive Accounts API.

Prerequisites:
--------------
*	Visual Studio 2005 or higher

SDK Integration:
----------------
*	Create a new ASP.NET Web Application with appropriate web application and solution name

*	Add 'PayPal_Invoicing_SDK.csproj' as 'Existing Project' to your solution

*	In case of a higher version of Visual Studio, use the Visual Studio Convertion Wizard to target .NET Framework 2.0

*	Add reference to 'PayPal_Invoicing_SDK' project

*	Add reference to 'PayPal_Core_SDK.dll' from the 'lib' folder in 'PayPal_Invoicing_SDK' project

*	Namespaces to be used
	•	PayPal
	•	PayPal.Invoice
	•	PayPal.Invoice.Model
	•	PayPal.Permissions
	•	PayPal.Permissions.Model
	•	PayPal.Util
	•	PayPal.Exception
 
Web.config:
-----------
Please refer to the sample web.config file in 'InvoicingSampleApp' sample application to configure the following
 
*	Configuration Sections
	•	paypal
	•	log4net

*	PayPal Settings
	•	endpoint
	•	connectionTimeout
	•	requestRetries
	•	IPAddress
	•	sandboxEmailAddress

*	PayPal (Multiple) Accounts API credentials
	•	apiUsername
	•	apiPassword
	•	apiSignature
	•	applicationId

Tools:
------
*	log4net.dll - included in 'lib' folder in 'PayPal_Invoicing_SDK' project
	log4net is a tool to help output log statements to a variety of output targets.
	
*	C#–ObjectDumper - included in 'InvoicingSampleApp' sample application
	ObjectDumper.cs is a nifty little utility class that you can use to dump the data within an object (It will walk the object graph to a specified depth which you can then output to console or a textWriter).