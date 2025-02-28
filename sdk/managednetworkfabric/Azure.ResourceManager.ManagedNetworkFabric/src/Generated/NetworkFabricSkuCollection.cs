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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFabricSkuResource" /> and their operations.
    /// Each <see cref="NetworkFabricSkuResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="NetworkFabricSkuCollection" /> instance call the GetNetworkFabricSkus method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class NetworkFabricSkuCollection : ArmCollection, IEnumerable<NetworkFabricSkuResource>, IAsyncEnumerable<NetworkFabricSkuResource>
    {
        private readonly ClientDiagnostics _networkFabricSkuClientDiagnostics;
        private readonly NetworkFabricSkusRestOperations _networkFabricSkuRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricSkuCollection"/> class for mocking. </summary>
        protected NetworkFabricSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricSkuCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricSkuClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricSkuResource.ResourceType, out string networkFabricSkuApiVersion);
            _networkFabricSkuRestClient = new NetworkFabricSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricSkuApiVersion);
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
        /// Implements Network Fabric SKU GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkFabricSkus/{networkFabricSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricSkuName"> Name of the Network Fabric SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricSkuName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricSkuResource>> GetAsync(string networkFabricSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricSkuName, nameof(networkFabricSkuName));

            using var scope = _networkFabricSkuClientDiagnostics.CreateScope("NetworkFabricSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricSkuRestClient.GetAsync(Id.SubscriptionId, networkFabricSkuName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements Network Fabric SKU GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkFabricSkus/{networkFabricSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricSkuName"> Name of the Network Fabric SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricSkuName"/> is null. </exception>
        public virtual Response<NetworkFabricSkuResource> Get(string networkFabricSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricSkuName, nameof(networkFabricSkuName));

            using var scope = _networkFabricSkuClientDiagnostics.CreateScope("NetworkFabricSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricSkuRestClient.Get(Id.SubscriptionId, networkFabricSkuName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements Network Fabric SKUs list by subscription GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkFabricSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricSkus_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricSkuResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricSkuRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricSkuRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricSkuResource(Client, NetworkFabricSkuData.DeserializeNetworkFabricSkuData(e)), _networkFabricSkuClientDiagnostics, Pipeline, "NetworkFabricSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Implements Network Fabric SKUs list by subscription GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkFabricSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricSkus_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricSkuResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricSkuRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricSkuRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricSkuResource(Client, NetworkFabricSkuData.DeserializeNetworkFabricSkuData(e)), _networkFabricSkuClientDiagnostics, Pipeline, "NetworkFabricSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkFabricSkus/{networkFabricSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricSkuName"> Name of the Network Fabric SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricSkuName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkFabricSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricSkuName, nameof(networkFabricSkuName));

            using var scope = _networkFabricSkuClientDiagnostics.CreateScope("NetworkFabricSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricSkuRestClient.GetAsync(Id.SubscriptionId, networkFabricSkuName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkFabricSkus/{networkFabricSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricSkuName"> Name of the Network Fabric SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricSkuName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkFabricSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricSkuName, nameof(networkFabricSkuName));

            using var scope = _networkFabricSkuClientDiagnostics.CreateScope("NetworkFabricSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricSkuRestClient.Get(Id.SubscriptionId, networkFabricSkuName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricSkuResource> IEnumerable<NetworkFabricSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricSkuResource> IAsyncEnumerable<NetworkFabricSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
