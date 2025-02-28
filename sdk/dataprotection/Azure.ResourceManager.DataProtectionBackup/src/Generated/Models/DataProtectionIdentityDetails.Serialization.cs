// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionIdentityDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UseSystemAssignedIdentity))
            {
                writer.WritePropertyName("useSystemAssignedIdentity"u8);
                writer.WriteBooleanValue(UseSystemAssignedIdentity.Value);
            }
            if (Optional.IsDefined(UserAssignedIdentityArmUri))
            {
                writer.WritePropertyName("userAssignedIdentityArmUrl"u8);
                writer.WriteStringValue(UserAssignedIdentityArmUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static DataProtectionIdentityDetails DeserializeDataProtectionIdentityDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> useSystemAssignedIdentity = default;
            Optional<Uri> userAssignedIdentityArmUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("useSystemAssignedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useSystemAssignedIdentity = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentityArmUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedIdentityArmUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new DataProtectionIdentityDetails(Optional.ToNullable(useSystemAssignedIdentity), userAssignedIdentityArmUrl.Value);
        }
    }
}
