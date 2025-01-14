// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> API server endpoint for the control plane. </summary>
    public partial class ControlPlaneEndpointProfileControlPlaneEndpoint
    {
        /// <summary> Initializes a new instance of ControlPlaneEndpointProfileControlPlaneEndpoint. </summary>
        public ControlPlaneEndpointProfileControlPlaneEndpoint()
        {
        }

        /// <summary> Initializes a new instance of ControlPlaneEndpointProfileControlPlaneEndpoint. </summary>
        /// <param name="hostIP"> Host IP address for API server. </param>
        /// <param name="port"> Port for the API server. </param>
        internal ControlPlaneEndpointProfileControlPlaneEndpoint(string hostIP, string port)
        {
            HostIP = hostIP;
            Port = port;
        }

        /// <summary> Host IP address for API server. </summary>
        public string HostIP { get; set; }
        /// <summary> Port for the API server. </summary>
        public string Port { get; set; }
    }
}
