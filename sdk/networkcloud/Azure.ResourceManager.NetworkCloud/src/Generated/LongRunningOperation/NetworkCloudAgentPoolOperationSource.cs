// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetworkCloud
{
    internal class NetworkCloudAgentPoolOperationSource : IOperationSource<NetworkCloudAgentPoolResource>
    {
        private readonly ArmClient _client;

        internal NetworkCloudAgentPoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkCloudAgentPoolResource IOperationSource<NetworkCloudAgentPoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkCloudAgentPoolData.DeserializeNetworkCloudAgentPoolData(document.RootElement);
            return new NetworkCloudAgentPoolResource(_client, data);
        }

        async ValueTask<NetworkCloudAgentPoolResource> IOperationSource<NetworkCloudAgentPoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkCloudAgentPoolData.DeserializeNetworkCloudAgentPoolData(document.RootElement);
            return new NetworkCloudAgentPoolResource(_client, data);
        }
    }
}
