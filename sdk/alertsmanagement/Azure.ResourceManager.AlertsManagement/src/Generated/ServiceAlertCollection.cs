// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AlertsManagement.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AlertsManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceAlertResource" /> and their operations.
    /// Each <see cref="ServiceAlertResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="ServiceAlertCollection" /> instance call the GetServiceAlerts method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class ServiceAlertCollection : ArmCollection, IEnumerable<ServiceAlertResource>, IAsyncEnumerable<ServiceAlertResource>
    {
        private readonly ClientDiagnostics _serviceAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _serviceAlertAlertsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceAlertCollection"/> class for mocking. </summary>
        protected ServiceAlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceAlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceAlertCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AlertsManagement", ServiceAlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceAlertResource.ResourceType, out string serviceAlertAlertsApiVersion);
            _serviceAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceAlertAlertsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get information related to a specific alert
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Unique ID of an alert instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceAlertResource>> GetAsync(Guid alertId, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceAlertAlertsRestClient.GetByIdAsync(Id.SubscriptionId, alertId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information related to a specific alert
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Unique ID of an alert instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceAlertResource> Get(Guid alertId, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceAlertAlertsRestClient.GetById(Id.SubscriptionId, alertId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all existing alerts, where the results can be filtered on the basis of multiple parameters (e.g. time range). The results can then be sorted on the basis specific fields, with the default being lastModifiedDateTime.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceAlertResource> GetAllAsync(ServiceAlertCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new ServiceAlertCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceAlertAlertsRestClient.CreateGetAllRequest(Id.SubscriptionId, options.TargetResource, options.TargetResourceType, options.TargetResourceGroup, options.MonitorService, options.MonitorCondition, options.Severity, options.AlertState, options.AlertRule, options.SmartGroupId, options.IncludeContext, options.IncludeEgressConfig, options.PageCount, options.SortBy, options.SortOrder, options.Select, options.TimeRange, options.CustomTimeRange);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceAlertAlertsRestClient.CreateGetAllNextPageRequest(nextLink, Id.SubscriptionId, options.TargetResource, options.TargetResourceType, options.TargetResourceGroup, options.MonitorService, options.MonitorCondition, options.Severity, options.AlertState, options.AlertRule, options.SmartGroupId, options.IncludeContext, options.IncludeEgressConfig, options.PageCount, options.SortBy, options.SortOrder, options.Select, options.TimeRange, options.CustomTimeRange);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceAlertResource(Client, ServiceAlertData.DeserializeServiceAlertData(e)), _serviceAlertAlertsClientDiagnostics, Pipeline, "ServiceAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all existing alerts, where the results can be filtered on the basis of multiple parameters (e.g. time range). The results can then be sorted on the basis specific fields, with the default being lastModifiedDateTime.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceAlertResource> GetAll(ServiceAlertCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new ServiceAlertCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceAlertAlertsRestClient.CreateGetAllRequest(Id.SubscriptionId, options.TargetResource, options.TargetResourceType, options.TargetResourceGroup, options.MonitorService, options.MonitorCondition, options.Severity, options.AlertState, options.AlertRule, options.SmartGroupId, options.IncludeContext, options.IncludeEgressConfig, options.PageCount, options.SortBy, options.SortOrder, options.Select, options.TimeRange, options.CustomTimeRange);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceAlertAlertsRestClient.CreateGetAllNextPageRequest(nextLink, Id.SubscriptionId, options.TargetResource, options.TargetResourceType, options.TargetResourceGroup, options.MonitorService, options.MonitorCondition, options.Severity, options.AlertState, options.AlertRule, options.SmartGroupId, options.IncludeContext, options.IncludeEgressConfig, options.PageCount, options.SortBy, options.SortOrder, options.Select, options.TimeRange, options.CustomTimeRange);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceAlertResource(Client, ServiceAlertData.DeserializeServiceAlertData(e)), _serviceAlertAlertsClientDiagnostics, Pipeline, "ServiceAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Unique ID of an alert instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid alertId, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceAlertAlertsRestClient.GetByIdAsync(Id.SubscriptionId, alertId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetById</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertId"> Unique ID of an alert instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid alertId, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceAlertAlertsRestClient.GetById(Id.SubscriptionId, alertId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceAlertResource> IEnumerable<ServiceAlertResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<ServiceAlertResource> IAsyncEnumerable<ServiceAlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
