// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HardwareSecurityModules;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    internal partial class DedicatedHsmListResult
    {
        internal static DedicatedHsmListResult DeserializeDedicatedHsmListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DedicatedHsmData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DedicatedHsmData> array = new List<DedicatedHsmData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DedicatedHsmData.DeserializeDedicatedHsmData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DedicatedHsmListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
