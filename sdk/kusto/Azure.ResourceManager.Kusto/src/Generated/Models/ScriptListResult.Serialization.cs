// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class ScriptListResult
    {
        internal static ScriptListResult DeserializeScriptListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ScriptData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ScriptData> array = new List<ScriptData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptData.DeserializeScriptData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ScriptListResult(Optional.ToList(value));
        }
    }
}
