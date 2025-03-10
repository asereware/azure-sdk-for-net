// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class LocalUserNotAllowed : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("allowlistValues");
            writer.WriteStartArray();
            foreach (var item in AllowlistValues)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("isEnabled");
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType);
            writer.WriteEndObject();
        }

        internal static LocalUserNotAllowed DeserializeLocalUserNotAllowed(JsonElement element)
        {
            IList<string> allowlistValues = default;
            Optional<ValueType> valueType = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            bool isEnabled = default;
            string ruleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowlistValues"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowlistValues = array;
                    continue;
                }
                if (property.NameEquals("valueType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valueType = new ValueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = property.Value.GetString();
                    continue;
                }
            }
            return new LocalUserNotAllowed(displayName.Value, description.Value, isEnabled, ruleType, Optional.ToNullable(valueType), allowlistValues);
        }
    }
}
