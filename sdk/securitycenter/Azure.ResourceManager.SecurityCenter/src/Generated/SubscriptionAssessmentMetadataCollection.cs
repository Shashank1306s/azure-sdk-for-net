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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionAssessmentMetadataResource" /> and their operations.
    /// Each <see cref="SubscriptionAssessmentMetadataResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubscriptionAssessmentMetadataCollection" /> instance call the GetSubscriptionAssessmentMetadata method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubscriptionAssessmentMetadataCollection : ArmCollection, IEnumerable<SubscriptionAssessmentMetadataResource>, IAsyncEnumerable<SubscriptionAssessmentMetadataResource>
    {
        private readonly ClientDiagnostics _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics;
        private readonly AssessmentsMetadataRestOperations _subscriptionAssessmentMetadataAssessmentsMetadataRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionAssessmentMetadataCollection"/> class for mocking. </summary>
        protected SubscriptionAssessmentMetadataCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionAssessmentMetadataCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionAssessmentMetadataCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SubscriptionAssessmentMetadataResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionAssessmentMetadataResource.ResourceType, out string subscriptionAssessmentMetadataAssessmentsMetadataApiVersion);
            _subscriptionAssessmentMetadataAssessmentsMetadataRestClient = new AssessmentsMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionAssessmentMetadataAssessmentsMetadataApiVersion);
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
        /// Create metadata information on an assessment type in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_CreateInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="data"> AssessmentMetadata object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionAssessmentMetadataResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string assessmentMetadataName, SecurityAssessmentMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.CreateInSubscriptionAsync(Id.SubscriptionId, assessmentMetadataName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SubscriptionAssessmentMetadataResource>(Response.FromValue(new SubscriptionAssessmentMetadataResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create metadata information on an assessment type in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_CreateInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="data"> AssessmentMetadata object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionAssessmentMetadataResource> CreateOrUpdate(WaitUntil waitUntil, string assessmentMetadataName, SecurityAssessmentMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.CreateInSubscription(Id.SubscriptionId, assessmentMetadataName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SubscriptionAssessmentMetadataResource>(Response.FromValue(new SubscriptionAssessmentMetadataResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get metadata information on an assessment type in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_GetInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionAssessmentMetadataResource>> GetAsync(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.GetInSubscriptionAsync(Id.SubscriptionId, assessmentMetadataName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionAssessmentMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get metadata information on an assessment type in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_GetInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual Response<SubscriptionAssessmentMetadataResource> Get(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.GetInSubscription(Id.SubscriptionId, assessmentMetadataName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionAssessmentMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get metadata information on all assessment types in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionAssessmentMetadataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionAssessmentMetadataResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SubscriptionAssessmentMetadataResource(Client, SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(e)), _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics, Pipeline, "SubscriptionAssessmentMetadataCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get metadata information on all assessment types in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionAssessmentMetadataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionAssessmentMetadataResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SubscriptionAssessmentMetadataResource(Client, SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(e)), _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics, Pipeline, "SubscriptionAssessmentMetadataCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_GetInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.GetInSubscriptionAsync(Id.SubscriptionId, assessmentMetadataName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_GetInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual Response<bool> Exists(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.GetInSubscription(Id.SubscriptionId, assessmentMetadataName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionAssessmentMetadataResource> IEnumerable<SubscriptionAssessmentMetadataResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionAssessmentMetadataResource> IAsyncEnumerable<SubscriptionAssessmentMetadataResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
