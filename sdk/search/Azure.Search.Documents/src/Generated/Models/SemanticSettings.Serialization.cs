// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SemanticSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultConfiguration))
            {
                writer.WritePropertyName("defaultConfiguration"u8);
                writer.WriteStringValue(DefaultConfiguration);
            }
            if (Optional.IsCollectionDefined(Configurations))
            {
                writer.WritePropertyName("configurations"u8);
                writer.WriteStartArray();
                foreach (var item in Configurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SemanticSettings DeserializeSemanticSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> defaultConfiguration = default;
            Optional<IList<SemanticConfiguration>> configurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultConfiguration"u8))
                {
                    defaultConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SemanticConfiguration> array = new List<SemanticConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SemanticConfiguration.DeserializeSemanticConfiguration(item));
                    }
                    configurations = array;
                    continue;
                }
            }
            return new SemanticSettings(defaultConfiguration.Value, Optional.ToList(configurations));
        }
    }
}
