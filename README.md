# SapAPI
SAP S4 Hana API in C#

Create a Configuration instance with host and port.

Add the configuration with the Extention AddConfiguration.

Add the API you want to use with the Extention methods;

Supported API's are, Change Log, EHS Incident, Maintenance Notifcations, Maintenace Order, Purchase Order and Supplier Invoice.

API's have been initially generated with OpenAPI Generator 7.

The code base has been modified to have the required constructors and member variables to correctly create the configurations and dynamicly select the API path based on the operation. Re-using a single client.

The API location is stored in ApiPath.cs and OperationNames.cs in the Client folder.
