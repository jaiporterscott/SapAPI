using Microsoft.Extensions.DependencyInjection;
using Sap.Api.ChangeLog;
using Sap.Api.EHSIncident;
using Sap.Api.MaintenanceNotification;
using Sap.Api.PurchaseOrder;
using Sap.Api;
using Sap.Api.SupplierInvoice;
using Sap.Client;


namespace Sap;

/// <summary>
/// Provides extension methods for configuring and registering SAP-related services
/// into an <see cref="IServiceCollection"/>.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Registers batch request services into the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <returns>The same service collection so that multiple calls can be chained.</returns>
    public static IServiceCollection AddBatch(
        this IServiceCollection services)
    {

        services.AddScoped<IBatchRequestsApi, BatchRequestsApi>();
        return services;
    }

    /// <summary>
    /// Registers the SAP configuration as a singleton in the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the configuration to.</param>
    /// <param name="configuration">The SAP configuration instance.</param>
    /// <returns>The same service collection so that multiple calls can be chained.</returns>
    public static IServiceCollection AddConfiguration(
        this IServiceCollection services, Configuration configuration)
    {

        services.AddSingleton(configuration);
        return services;
    }

    /// <summary>
    /// Registers SAP EHS (Environment, Health, and Safety) Incident services into the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <returns>The same service collection so that multiple calls can be chained.</returns>
    public static IServiceCollection AddSapApiEhs(
        this IServiceCollection services)
    {
        services.AddScoped<IIncidentApi, IncidentApi>();
        services.AddScoped<IAttachmentApi, AttachmentApi>();
        services.AddScoped<ILocationApi, LocationApi>();
        services.AddScoped<ILocationClassifierApi, LocationClassifierApi>();
        services.AddScoped<ILocationClassifierTextApi, LocationClassifierTextApi>();
        services.AddScoped<IEHSLocationApi, EHSLocationApi>();
        services.AddScoped<IEHSLocationTypeApi, EHSLocationTypeApi>();
        services.AddScoped<IEHSPersonValueHelpApi, EHSPersonValueHelpApi>();
        services.AddScoped<IHierarchyForCurrentRevOfEHSLocApi, HierarchyForCurrentRevOfEHSLocApi>();

        return services;
    }

    /// <summary>
    /// Registers SAP Change Log services into the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <returns>The same service collection so that multiple calls can be chained.</returns>
    public static IServiceCollection AddSapApiChangeLog(this IServiceCollection services)
    {
        services.AddScoped<IChangeRecordHistoryApi, ChangeRecordHistoryApi>();
        return services;
    }

    /// <summary>
    /// Registers SAP Purchase Order services into the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <returns>The same service collection so that multiple calls can be chained.</returns>
    public static IServiceCollection AddSapApiPurchaseOrder(this IServiceCollection services)
    {
        services.AddScoped<IPurchaseOrderApi, PurchaseOrderApi>();
        services.AddScoped<IAccountAssignmentApi, AccountAssignmentApi>();
        services.AddScoped<IPurchaseOrderItemApi, PurchaseOrderItemApi>();
        services.AddScoped<IHeaderNotesApi, HeaderNotesApi>();
        services.AddScoped<IInvoicingPlanApi, InvoicingPlanApi>();
        services.AddScoped<IInvoicingPlanItemApi, InvoicingPlanItemApi>();
        services.AddScoped<IItemDeliveryAddressApi, ItemDeliveryAddressApi>();
        services.AddScoped<IItemNotesApi, ItemNotesApi>();
        services.AddScoped<IPartnerApi, PartnerApi>();
        services.AddScoped<IPricingElementApi, PricingElementApi>();
        services.AddScoped<IScheduleLinesApi, ScheduleLinesApi>();
        services.AddScoped<ISubcontractingComponentsApi, SubcontractingComponentsApi>();
        services.AddScoped<ISupplierAddressApi, SupplierAddressApi>();
        return services;
    }

    /// <summary>
    /// Registers SAP Supplier Invoice services into the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <returns>The same service collection so that multiple calls can be chained.</returns>
    public static IServiceCollection AddSapApiSupplierInvoice(this IServiceCollection services)
    {
        services.AddScoped<IItemWithPurchaseOrderReferenceApi, ItemWithPurchaseOrderReferenceApi>();
        services.AddScoped<IAccountAssignmentApi, AccountAssignmentApi>();
        services.AddScoped<IAdditionalDataApi, AdditionalDataApi>();
        services.AddScoped<IHeaderDataApi, HeaderDataApi>();
        services.AddScoped<IItemForAssetPostingApi, ItemForAssetPostingApi>();
        services.AddScoped<IItemForGLAccountPostingApi, ItemForGLAccountPostingApi>();
        services.AddScoped<IItemForMaterialPostingApi, ItemForMaterialPostingApi>();
        services.AddScoped<INotaFiscalDataApi, NotaFiscalDataApi>();
        services.AddScoped<IOfficialDocumentNumberApi, OfficialDocumentNumberApi>();
        services.AddScoped<IServiceOperationsApi, ServiceOperationsApi>();
        services.AddScoped<ISIEnteredDeliveryNotesApi, SIEnteredDeliveryNotesApi>();
        services.AddScoped<ISIEnteredPurchasingDocumentsApi, SIEnteredPurchasingDocumentsApi>();
        services.AddScoped<ISIEnteredServiceEntrySheetsLeanApi, SIEnteredServiceEntrySheetsLeanApi>();
        services.AddScoped<ITaxDataApi, TaxDataApi>();
        services.AddScoped<IWithholdingTaxDataApi, WithholdingTaxDataApi>();

        return services;
    }

    /// <summary>
    /// Registers SAP Maintenance Notification services into the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <returns>The same service collection so that multiple calls can be chained.</returns>
    public static IServiceCollection AddSapApiMaintenanceNotification(this IServiceCollection services)
    {
        services.AddScoped<IMaintenanceNotificationApi, MaintenanceNotificationApi>();
        services.AddScoped<IMaintenanceNotificationItemApi, MaintenanceNotificationItemApi>();

        return services;
    }
}
