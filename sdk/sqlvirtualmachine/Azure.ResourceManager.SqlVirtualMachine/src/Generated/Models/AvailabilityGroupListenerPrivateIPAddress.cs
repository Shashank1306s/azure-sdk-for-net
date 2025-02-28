// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> A private IP address bound to the availability group listener. </summary>
    public partial class AvailabilityGroupListenerPrivateIPAddress
    {
        /// <summary> Initializes a new instance of AvailabilityGroupListenerPrivateIPAddress. </summary>
        public AvailabilityGroupListenerPrivateIPAddress()
        {
        }

        /// <summary> Initializes a new instance of AvailabilityGroupListenerPrivateIPAddress. </summary>
        /// <param name="ipAddress"> Private IP address bound to the availability group listener. </param>
        /// <param name="subnetResourceId"> Subnet used to include private IP. </param>
        internal AvailabilityGroupListenerPrivateIPAddress(IPAddress ipAddress, ResourceIdentifier subnetResourceId)
        {
            IPAddress = ipAddress;
            SubnetResourceId = subnetResourceId;
        }

        /// <summary> Private IP address bound to the availability group listener. </summary>
        public IPAddress IPAddress { get; set; }
        /// <summary> Subnet used to include private IP. </summary>
        public ResourceIdentifier SubnetResourceId { get; set; }
    }
}
