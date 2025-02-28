// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> A reference to an Azure Virtual Machines Marketplace image or the Azure Image resource of a custom Virtual Machine. To get the list of all imageReferences verified by Azure Batch, see the 'List supported node agent SKUs' operation. </summary>
    public partial class BatchImageReference
    {
        /// <summary> Initializes a new instance of BatchImageReference. </summary>
        public BatchImageReference()
        {
        }

        /// <summary> Initializes a new instance of BatchImageReference. </summary>
        /// <param name="publisher"> For example, Canonical or MicrosoftWindowsServer. </param>
        /// <param name="offer"> For example, UbuntuServer or WindowsServer. </param>
        /// <param name="sku"> For example, 18.04-LTS or 2022-datacenter. </param>
        /// <param name="version"> A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'. </param>
        /// <param name="id"> This property is mutually exclusive with other properties. The Shared Image Gallery image must have replicas in the same region as the Azure Batch account. For information about the firewall settings for the Batch node agent to communicate with the Batch service see https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration. </param>
        internal BatchImageReference(string publisher, string offer, string sku, string version, ResourceIdentifier id)
        {
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            Version = version;
            Id = id;
        }

        /// <summary> For example, Canonical or MicrosoftWindowsServer. </summary>
        public string Publisher { get; set; }
        /// <summary> For example, UbuntuServer or WindowsServer. </summary>
        public string Offer { get; set; }
        /// <summary> For example, 18.04-LTS or 2022-datacenter. </summary>
        public string Sku { get; set; }
        /// <summary> A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'. </summary>
        public string Version { get; set; }
        /// <summary> This property is mutually exclusive with other properties. The Shared Image Gallery image must have replicas in the same region as the Azure Batch account. For information about the firewall settings for the Batch node agent to communicate with the Batch service see https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
