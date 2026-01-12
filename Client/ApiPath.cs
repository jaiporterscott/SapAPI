using System.Collections.Generic;

namespace Sap.Client;

public static class ApiPath
{
    public static string ChangeLog = "/sap/opu/odata4/sap/api_changerecordhistory/srvd_a2x/sap/changerecordhistory/0001";
    public static string EHSIncident = "/sap/opu/odata/sap/API_EHS_REPORT_INCIDENT_SRV";
    public static string MaintenanceNotification = "/sap/opu/odata/sap/API_MAINTNOTIFICATION";
    public static string PurchaseOrder = "/sap/opu/odata4/sap/api_purchaseorder_2/srvd_a2x/sap/purchaseorder/0001";
    public static string SupplierInvoice = "/sap/opu/odata/sap/API_SUPPLIERINVOICE_PROCESS_SRV";
    public static string Users = "/rgm-user-management/scim";
    public static string ManageBusinessUser = "/sap/bc/srt/scs_ext/sap/managebusinessuserin";

    public static Dictionary<string, string> Path = new Dictionary<string, string>
    {
        {OperationNames.UsersApi.ApiClassName, Users},
        {OperationNames.ChangeRecordHistoryApi.ApiClassName, ChangeLog},

        {OperationNames.AttachmentApi.ApiClassName, EHSIncident},
        {OperationNames.EHSLocationApi.ApiClassName, EHSIncident},
        {OperationNames.EHSLocationTypeApi.ApiClassName, EHSIncident},
        {OperationNames.EHSPersonValueHelpApi.ApiClassName, EHSIncident},
        {OperationNames.HierarchyForCurrentRevOfEHSLocApi.ApiClassName, EHSIncident},
        {OperationNames.IncidentApi.ApiClassName, EHSIncident},
        {OperationNames.LocationApi.ApiClassName, EHSIncident},
        {OperationNames.LocationClassifierApi.ApiClassName, EHSIncident},
        {OperationNames.LocationClassifierTextApi.ApiClassName, EHSIncident},
        {OperationNames.PersonApi.ApiClassName, EHSIncident},

        {OperationNames.MaintenanceNotificationApi.ApiClassName, MaintenanceNotification},
        {OperationNames.MaintenanceNotificationItemActivityApi.ApiClassName, MaintenanceNotification},
        {OperationNames.MaintenanceNotificationItemApi.ApiClassName, MaintenanceNotification},
        {OperationNames.MaintenanceNotificationItemCauseApi.ApiClassName, MaintenanceNotification},
        {OperationNames.MaintenanceNotificationPartnerApi.ApiClassName, MaintenanceNotification},

        {OperationNames.AccountAssignmentApi.ApiClassName, PurchaseOrder},
        {OperationNames.HeaderNotesApi.ApiClassName, PurchaseOrder},
        {OperationNames.InvoicingPlanApi.ApiClassName, PurchaseOrder},
        {OperationNames.InvoicingPlanItemApi.ApiClassName, PurchaseOrder},
        {OperationNames.ItemDeliveryAddressApi.ApiClassName, PurchaseOrder},
        {OperationNames.ItemNotesApi.ApiClassName, PurchaseOrder},
        {OperationNames.PartnerApi.ApiClassName, PurchaseOrder},
        {OperationNames.PricingElementApi.ApiClassName, PurchaseOrder},
        {OperationNames.PurchaseOrderApi.ApiClassName, PurchaseOrder},
        {OperationNames.PurchaseOrderItemApi.ApiClassName, PurchaseOrder},
        {OperationNames.ScheduleLinesApi.ApiClassName, PurchaseOrder},
        {OperationNames.SubcontractingComponentsApi.ApiClassName, PurchaseOrder},
        {OperationNames.SupplierAddressApi.ApiClassName, PurchaseOrder},

        {OperationNames.AccountAssignmentDataApi.ApiClassName, SupplierInvoice},
        {OperationNames.AdditionalDataApi.ApiClassName, SupplierInvoice},
        {OperationNames.HeaderDataApi.ApiClassName, SupplierInvoice},
        {OperationNames.ItemForAssetPostingApi.ApiClassName, SupplierInvoice},
        {OperationNames.ItemForGLAccountPostingApi.ApiClassName, SupplierInvoice},
        {OperationNames.ItemForMaterialPostingApi.ApiClassName, SupplierInvoice},
        {OperationNames.ItemWithPurchaseOrderReferenceApi.ApiClassName, SupplierInvoice},
        {OperationNames.NotaFiscalDataApi.ApiClassName, SupplierInvoice},
        {OperationNames.OfficialDocumentNumberApi.ApiClassName, SupplierInvoice},
        {OperationNames.SIEnteredDeliveryNotesApi.ApiClassName, SupplierInvoice},
        {OperationNames.SIEnteredPurchasingDocumentsApi.ApiClassName, SupplierInvoice},
        {OperationNames.SIEnteredServiceEntrySheetsLeanApi.ApiClassName, SupplierInvoice},
        {OperationNames.ServiceOperationsApi.ApiClassName, SupplierInvoice},
        {OperationNames.TaxDataApi.ApiClassName, SupplierInvoice},
        {OperationNames.WithholdingTaxDataApi.ApiClassName, SupplierInvoice},

        //{OperationNames.BatchRequestsApi.ApiClassName, Api}
    };
}
