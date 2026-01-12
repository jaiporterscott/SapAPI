namespace Sap.Client
{
    /// <summary>
    /// Centralized operation-name values used by RequestOptions.Operation across all API clients.
    /// Pattern: "{ApiClassName}.{MethodName}"
    /// </summary>
    public static class OperationNames
    {
        /// <summary>
        /// Builds an operation name matching the generator pattern: "{ApiClassName}.{MethodName}".
        /// Use this to avoid scattering string literals while still matching RequestOptions.Operation values.
        /// </summary>
        public static string For(string apiClassName, string methodName) => $"{apiClassName}.{methodName}";

        public static string For(string apiClassName)
        {
            return apiClassName;
        }
        // Root-level APIs (Api/*.cs)
        public static class BatchRequestsApi
        {
            public const string ApiPath = "BatchRequestsApi";
            public const string ApiClassName = "BatchRequestsApi";

            // Keep explicit constants where you want compile-time discoverability:
            public const string BatchPost = "BatchRequestsApi.BatchPost";

            // Prefer using: OperationNames.For(ApiClassName, nameof(Sap.Api.BatchRequestsApi.BatchPost))
            // to cover all methods without listing each one.
        }

        public static class UsersApi
        {
            public const string ApiClassName = "UsersApi";
        }

        // Folder: Api/ChangeLog/*
        public static class ChangeRecordHistoryApi
        {
            public const string ApiPath = "BatchRequestsApi";
            public const string ApiClassName = "ChangeRecordHistoryApi";
        }

        // Folder: Api/EHSIncident/*
        public static class AttachmentApi
        {
            public const string ApiClassName = "AttachmentApi";
        }

        public static class EHSLocationApi
        {
            public const string ApiClassName = "EHSLocationApi";
        }

        public static class EHSLocationTypeApi
        {
            public const string ApiClassName = "EHSLocationTypeApi";
        }

        public static class EHSPersonValueHelpApi
        {
            public const string ApiClassName = "EHSPersonValueHelpApi";
        }

        public static class HierarchyForCurrentRevOfEHSLocApi
        {
            public const string ApiClassName = "HierarchyForCurrentRevOfEHSLocApi";
        }

        public static class IncidentApi
        {
            public const string ApiClassName = "IncidentApi";
        }

        public static class LocationApi
        {
            public const string ApiClassName = "LocationApi";
        }

        public static class LocationClassifierApi
        {
            public const string ApiClassName = "LocationClassifierApi";
        }

        public static class LocationClassifierTextApi
        {
            public const string ApiClassName = "LocationClassifierTextApi";
        }

        public static class PersonApi
        {
            public const string ApiClassName = "PersonApi";
        }

        // Folder: Api/MaintenanceNotification/*
        public static class MaintenanceNotificationApi
        {
            public const string ApiClassName = "MaintenanceNotificationApi";
            public const string OperationPrefix = ApiClassName + ".";

            public const string MaintenanceNotificationMaintenanceNotificationGet =
                OperationPrefix + "MaintenanceNotificationMaintenanceNotificationGet";

            // Alias for clarity at call sites; both resolve to the same operation name.
            public const string MaintenanceNotificationByIdGet =
                MaintenanceNotificationMaintenanceNotificationGet;

            public const string CompleteMaintNotificationPost =
                OperationPrefix + "CompleteMaintNotificationPost";

            public const string MaintNotificationItemActivityGet =
                OperationPrefix + "MaintNotificationItemActivityMaintNotificationActivityMaintNotificationActivityMaintenanceNotificationMaintenanceNotificationMaintenanceNotificationItemMaintenanceNotificationItemToNotifGet";

            public const string MaintNotificationItemCauseGet =
                OperationPrefix + "MaintNotificationItemCauseMaintenanceNotificationMaintenanceNotificationMaintenanceNotificationItemMaintenanceNotificationItemMaintenanceNotificationCauseMaintenanceNotificationCauseToNotifGet";

            public const string MaintenanceNotificationGet =
                OperationPrefix + "MaintenanceNotificationGet";

            public const string MaintenanceNotificationPatch =
                OperationPrefix + "MaintenanceNotificationMaintenanceNotificationPatch";

            public const string MaintenanceNotificationToItemGet =
                OperationPrefix + "MaintenanceNotificationMaintenanceNotificationToItemGet";

            public const string MaintenanceNotificationToItemPost =
                OperationPrefix + "MaintenanceNotificationMaintenanceNotificationToItemPost";

            public const string MaintenanceNotificationToPartnerGet =
                OperationPrefix + "MaintenanceNotificationMaintenanceNotificationToPartnerGet";

            public const string MaintenanceNotificationToPartnerPost =
                OperationPrefix + "MaintenanceNotificationMaintenanceNotificationToPartnerPost";

            public const string MaintenanceNotificationPost =
                OperationPrefix + "MaintenanceNotificationPost";

            public const string SetMaintNotifToInProcessPost =
                OperationPrefix + "SetMaintNotifToInProcessPost";
        }

        public static class MaintenanceNotificationItemActivityApi
        {
            public const string ApiClassName = "MaintenanceNotificationItemActivityApi";
        }

        public static class MaintenanceNotificationItemApi
        {
            public const string ApiClassName = "MaintenanceNotificationItemApi";
        }

        public static class MaintenanceNotificationItemCauseApi
        {
            public const string ApiClassName = "MaintenanceNotificationItemCauseApi";
        }

        public static class MaintenanceNotificationPartnerApi
        {
            public const string ApiClassName = "MaintenanceNotificationPartnerApi";
        }

        // Folder: Api/PurchaseOrder/*
        public static class AccountAssignmentApi
        {
            public const string ApiClassName = "AccountAssignmentApi";
        }

        public static class HeaderNotesApi
        {
            public const string ApiClassName = "HeaderNotesApi";
        }

        public static class InvoicingPlanApi
        {
            public const string ApiClassName = "InvoicingPlanApi";
        }

        public static class InvoicingPlanItemApi
        {
            public const string ApiClassName = "InvoicingPlanItemApi";
        }

        public static class ItemDeliveryAddressApi
        {
            public const string ApiClassName = "ItemDeliveryAddressApi";
        }

        public static class ItemNotesApi
        {
            public const string ApiClassName = "ItemNotesApi";
        }

        public static class PartnerApi
        {
            public const string ApiClassName = "PartnerApi";
        }

        public static class PricingElementApi
        {
            public const string ApiClassName = "PricingElementApi";
        }

        public static class PurchaseOrderApi
        {
            public const string ApiClassName = "PurchaseOrderApi";
        }

        public static class PurchaseOrderItemApi
        {
            public const string ApiClassName = "PurchaseOrderItemApi";
        }

        public static class ScheduleLinesApi
        {
            public const string ApiClassName = "ScheduleLinesApi";
        }

        public static class SubcontractingComponentsApi
        {
            public const string ApiClassName = "SubcontractingComponentsApi";
        }

        public static class SupplierAddressApi
        {
            public const string ApiClassName = "SupplierAddressApi";
        }

        // Folder: Api/SupplierInvoice/*
        public static class AccountAssignmentDataApi
        {
            public const string ApiClassName = "AccountAssignmentDataApi";
        }

        public static class AdditionalDataApi
        {
            public const string ApiClassName = "AdditionalDataApi";
        }

        public static class HeaderDataApi
        {
            public const string ApiClassName = "HeaderDataApi";
        }

        public static class ItemForAssetPostingApi
        {
            public const string ApiClassName = "ItemForAssetPostingApi";
        }

        public static class ItemForGLAccountPostingApi
        {
            public const string ApiClassName = "ItemForGLAccountPostingApi";
        }

        public static class ItemForMaterialPostingApi
        {
            public const string ApiClassName = "ItemForMaterialPostingApi";
        }

        public static class ItemWithPurchaseOrderReferenceApi
        {
            public const string ApiClassName = "ItemWithPurchaseOrderReferenceApi";
        }

        public static class NotaFiscalDataApi
        {
            public const string ApiClassName = "NotaFiscalDataApi";
        }

        public static class OfficialDocumentNumberApi
        {
            public const string ApiClassName = "OfficialDocumentNumberApi";
        }

        public static class SIEnteredDeliveryNotesApi
        {
            public const string ApiClassName = "SIEnteredDeliveryNotesApi";
        }

        public static class SIEnteredPurchasingDocumentsApi
        {
            public const string ApiClassName = "SIEnteredPurchasingDocumentsApi";
        }

        public static class SIEnteredServiceEntrySheetsLeanApi
        {
            public const string ApiClassName = "SIEnteredServiceEntrySheetsLeanApi";
        }

        public static class ServiceOperationsApi
        {
            public const string ApiClassName = "ServiceOperationsApi";
        }

        public static class TaxDataApi
        {
            public const string ApiClassName = "TaxDataApi";
        }

        public static class WithholdingTaxDataApi
        {
            public const string ApiClassName = "WithholdingTaxDataApi";
        }
    }
}
