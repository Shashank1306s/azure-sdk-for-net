// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the PartnerNamespace data model.
    /// EventGrid Partner Namespace.
    /// </summary>
    public partial class PartnerNamespaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of PartnerNamespaceData. </summary>
        /// <param name="location"> The location. </param>
        public PartnerNamespaceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<EventGridPrivateEndpointConnectionData>();
            InboundIPRules = new ChangeTrackingList<EventGridInboundIPRule>();
        }

        /// <summary> Initializes a new instance of PartnerNamespaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="privateEndpointConnections"></param>
        /// <param name="provisioningState"> Provisioning state of the partner namespace. </param>
        /// <param name="partnerRegistrationFullyQualifiedId">
        /// The fully qualified ARM Id of the partner registration that should be associated with this partner namespace. This takes the following format:
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}.
        /// </param>
        /// <param name="minimumTlsVersionAllowed"> Minimum TLS version of the publisher allowed to publish to this partner namespace. </param>
        /// <param name="endpoint"> Endpoint for the partner namespace. </param>
        /// <param name="publicNetworkAccess">
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PartnerNamespaceProperties.InboundIpRules" /&gt;
        /// </param>
        /// <param name="inboundIPRules"> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </param>
        /// <param name="isLocalAuthDisabled"> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the partner namespace. </param>
        /// <param name="partnerTopicRoutingMode">
        /// This determines if events published to this partner namespace should use the source attribute in the event payload
        /// or use the channel name in the header when matching to the partner topic. If none is specified, source attribute routing will be used to match the partner topic.
        /// </param>
        internal PartnerNamespaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IReadOnlyList<EventGridPrivateEndpointConnectionData> privateEndpointConnections, PartnerNamespaceProvisioningState? provisioningState, ResourceIdentifier partnerRegistrationFullyQualifiedId, TlsVersion? minimumTlsVersionAllowed, Uri endpoint, EventGridPublicNetworkAccess? publicNetworkAccess, IList<EventGridInboundIPRule> inboundIPRules, bool? isLocalAuthDisabled, PartnerTopicRoutingMode? partnerTopicRoutingMode) : base(id, name, resourceType, systemData, tags, location)
        {
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            PartnerRegistrationFullyQualifiedId = partnerRegistrationFullyQualifiedId;
            MinimumTlsVersionAllowed = minimumTlsVersionAllowed;
            Endpoint = endpoint;
            PublicNetworkAccess = publicNetworkAccess;
            InboundIPRules = inboundIPRules;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            PartnerTopicRoutingMode = partnerTopicRoutingMode;
        }

        /// <summary> Gets the private endpoint connections. </summary>
        public IReadOnlyList<EventGridPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Provisioning state of the partner namespace. </summary>
        public PartnerNamespaceProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// The fully qualified ARM Id of the partner registration that should be associated with this partner namespace. This takes the following format:
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}.
        /// </summary>
        public ResourceIdentifier PartnerRegistrationFullyQualifiedId { get; set; }
        /// <summary> Minimum TLS version of the publisher allowed to publish to this partner namespace. </summary>
        public TlsVersion? MinimumTlsVersionAllowed { get; set; }
        /// <summary> Endpoint for the partner namespace. </summary>
        public Uri Endpoint { get; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PartnerNamespaceProperties.InboundIpRules" /&gt;
        /// </summary>
        public EventGridPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </summary>
        public IList<EventGridInboundIPRule> InboundIPRules { get; }
        /// <summary> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the partner namespace. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary>
        /// This determines if events published to this partner namespace should use the source attribute in the event payload
        /// or use the channel name in the header when matching to the partner topic. If none is specified, source attribute routing will be used to match the partner topic.
        /// </summary>
        public PartnerTopicRoutingMode? PartnerTopicRoutingMode { get; set; }
    }
}
