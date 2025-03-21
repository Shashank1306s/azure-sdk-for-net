// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class RestRequestAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(AuthType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static RestRequestAuthentication DeserializeRestRequestAuthentication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ApiKey": return ApiKeyAuthentication.DeserializeApiKeyAuthentication(element);
                    case "RolloutIdentity": return RolloutIdentityAuthentication.DeserializeRolloutIdentityAuthentication(element);
                }
            }
            return UnknownRestRequestAuthentication.DeserializeUnknownRestRequestAuthentication(element);
        }
    }
}
