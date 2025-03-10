// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class ClusterPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TrustedExternalTenants))
            {
                writer.WritePropertyName("trustedExternalTenants");
                writer.WriteStartArray();
                foreach (var item in TrustedExternalTenants)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OptimizedAutoscale))
            {
                writer.WritePropertyName("optimizedAutoscale");
                writer.WriteObjectValue(OptimizedAutoscale);
            }
            if (Optional.IsDefined(EnableDiskEncryption))
            {
                writer.WritePropertyName("enableDiskEncryption");
                writer.WriteBooleanValue(EnableDiskEncryption.Value);
            }
            if (Optional.IsDefined(EnableStreamingIngest))
            {
                writer.WritePropertyName("enableStreamingIngest");
                writer.WriteBooleanValue(EnableStreamingIngest.Value);
            }
            if (Optional.IsDefined(VirtualNetworkConfiguration))
            {
                writer.WritePropertyName("virtualNetworkConfiguration");
                writer.WriteObjectValue(VirtualNetworkConfiguration);
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties");
                writer.WriteObjectValue(KeyVaultProperties);
            }
            if (Optional.IsDefined(EnablePurge))
            {
                writer.WritePropertyName("enablePurge");
                writer.WriteBooleanValue(EnablePurge.Value);
            }
            if (Optional.IsDefined(EnableDoubleEncryption))
            {
                writer.WritePropertyName("enableDoubleEncryption");
                writer.WriteBooleanValue(EnableDoubleEncryption.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AllowedIPRangeList))
            {
                writer.WritePropertyName("allowedIpRangeList");
                writer.WriteStartArray();
                foreach (var item in AllowedIPRangeList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EngineType))
            {
                writer.WritePropertyName("engineType");
                writer.WriteStringValue(EngineType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AcceptedAudiences))
            {
                writer.WritePropertyName("acceptedAudiences");
                writer.WriteStartArray();
                foreach (var item in AcceptedAudiences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableAutoStop))
            {
                writer.WritePropertyName("enableAutoStop");
                writer.WriteBooleanValue(EnableAutoStop.Value);
            }
            if (Optional.IsDefined(RestrictOutboundNetworkAccess))
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess");
                writer.WriteStringValue(RestrictOutboundNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AllowedFqdnList))
            {
                writer.WritePropertyName("allowedFqdnList");
                writer.WriteStartArray();
                foreach (var item in AllowedFqdnList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicIPType))
            {
                writer.WritePropertyName("publicIPType");
                writer.WriteStringValue(PublicIPType.Value.ToString());
            }
            if (Optional.IsDefined(VirtualClusterGraduationProperties))
            {
                writer.WritePropertyName("virtualClusterGraduationProperties");
                writer.WriteStringValue(VirtualClusterGraduationProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ClusterPatch DeserializeClusterPatch(JsonElement element)
        {
            Optional<AzureSku> sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<State> state = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<Uri> uri = default;
            Optional<Uri> dataIngestionUri = default;
            Optional<string> stateReason = default;
            Optional<IList<TrustedExternalTenant>> trustedExternalTenants = default;
            Optional<OptimizedAutoscale> optimizedAutoscale = default;
            Optional<bool> enableDiskEncryption = default;
            Optional<bool> enableStreamingIngest = default;
            Optional<VirtualNetworkConfiguration> virtualNetworkConfiguration = default;
            Optional<KeyVaultProperties> keyVaultProperties = default;
            Optional<bool> enablePurge = default;
            Optional<LanguageExtensionsList> languageExtensions = default;
            Optional<bool> enableDoubleEncryption = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Optional<IList<string>> allowedIPRangeList = default;
            Optional<EngineType> engineType = default;
            Optional<IList<AcceptedAudiences>> acceptedAudiences = default;
            Optional<bool> enableAutoStop = default;
            Optional<ClusterNetworkAccessFlag> restrictOutboundNetworkAccess = default;
            Optional<IList<string>> allowedFqdnList = default;
            Optional<PublicIPType> publicIPType = default;
            Optional<string> virtualClusterGraduationProperties = default;
            Optional<IReadOnlyList<KustoPrivateEndpointConnectionData>> privateEndpointConnections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = AzureSku.DeserializeAzureSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new State(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                uri = null;
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataIngestionUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                dataIngestionUri = null;
                                continue;
                            }
                            dataIngestionUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stateReason"))
                        {
                            stateReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("trustedExternalTenants"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<TrustedExternalTenant> array = new List<TrustedExternalTenant>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrustedExternalTenant.DeserializeTrustedExternalTenant(item));
                            }
                            trustedExternalTenants = array;
                            continue;
                        }
                        if (property0.NameEquals("optimizedAutoscale"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            optimizedAutoscale = OptimizedAutoscale.DeserializeOptimizedAutoscale(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableDiskEncryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableDiskEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableStreamingIngest"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableStreamingIngest = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualNetworkConfiguration = VirtualNetworkConfiguration.DeserializeVirtualNetworkConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("keyVaultProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            keyVaultProperties = KeyVaultProperties.DeserializeKeyVaultProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enablePurge"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enablePurge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("languageExtensions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            languageExtensions = LanguageExtensionsList.DeserializeLanguageExtensionsList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableDoubleEncryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableDoubleEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowedIpRangeList"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            allowedIPRangeList = array;
                            continue;
                        }
                        if (property0.NameEquals("engineType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            engineType = new EngineType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("acceptedAudiences"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AcceptedAudiences> array = new List<AcceptedAudiences>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.AcceptedAudiences.DeserializeAcceptedAudiences(item));
                            }
                            acceptedAudiences = array;
                            continue;
                        }
                        if (property0.NameEquals("enableAutoStop"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableAutoStop = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("restrictOutboundNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            restrictOutboundNetworkAccess = new ClusterNetworkAccessFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowedFqdnList"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            allowedFqdnList = array;
                            continue;
                        }
                        if (property0.NameEquals("publicIPType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicIPType = new PublicIPType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualClusterGraduationProperties"))
                        {
                            virtualClusterGraduationProperties = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<KustoPrivateEndpointConnectionData> array = new List<KustoPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KustoPrivateEndpointConnectionData.DeserializeKustoPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ClusterPatch(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, identity, Optional.ToNullable(state), Optional.ToNullable(provisioningState), uri.Value, dataIngestionUri.Value, stateReason.Value, Optional.ToList(trustedExternalTenants), optimizedAutoscale.Value, Optional.ToNullable(enableDiskEncryption), Optional.ToNullable(enableStreamingIngest), virtualNetworkConfiguration.Value, keyVaultProperties.Value, Optional.ToNullable(enablePurge), languageExtensions.Value, Optional.ToNullable(enableDoubleEncryption), Optional.ToNullable(publicNetworkAccess), Optional.ToList(allowedIPRangeList), Optional.ToNullable(engineType), Optional.ToList(acceptedAudiences), Optional.ToNullable(enableAutoStop), Optional.ToNullable(restrictOutboundNetworkAccess), Optional.ToList(allowedFqdnList), Optional.ToNullable(publicIPType), virtualClusterGraduationProperties.Value, Optional.ToList(privateEndpointConnections));
        }
    }
}
