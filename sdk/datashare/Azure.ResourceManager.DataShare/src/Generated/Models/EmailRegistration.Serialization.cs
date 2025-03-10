// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class EmailRegistration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActivationCode))
            {
                writer.WritePropertyName("activationCode");
                writer.WriteStringValue(ActivationCode);
            }
            writer.WriteEndObject();
        }

        internal static EmailRegistration DeserializeEmailRegistration(JsonElement element)
        {
            Optional<string> activationCode = default;
            Optional<DateTimeOffset> activationExpirationDate = default;
            Optional<string> email = default;
            Optional<RegistrationStatus> registrationStatus = default;
            Optional<Guid> tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activationCode"))
                {
                    activationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activationExpirationDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    activationExpirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("email"))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    registrationStatus = new RegistrationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
            }
            return new EmailRegistration(activationCode.Value, Optional.ToNullable(activationExpirationDate), email.Value, Optional.ToNullable(registrationStatus), Optional.ToNullable(tenantId));
        }
    }
}
