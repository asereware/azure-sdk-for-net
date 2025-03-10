// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a container registry. </summary>
    public partial class ContainerRegistryPatch
    {
        /// <summary> Initializes a new instance of ContainerRegistryPatch. </summary>
        public ContainerRegistryPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The identity of the container registry. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The tags for the container registry. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The SKU of the container registry. </summary>
        public ContainerRegistrySku Sku { get; set; }
        /// <summary> The value that indicates whether the admin user is enabled. </summary>
        public bool? IsAdminUserEnabled { get; set; }
        /// <summary> The network rule set for a container registry. </summary>
        public ContainerRegistryNetworkRuleSet NetworkRuleSet { get; set; }
        /// <summary> The policies for a container registry. </summary>
        public ContainerRegistryPolicies Policies { get; set; }
        /// <summary> The encryption settings of container registry. </summary>
        public ContainerRegistryEncryption Encryption { get; set; }
        /// <summary> Enable a single data endpoint per region for serving data. </summary>
        public bool? IsDataEndpointEnabled { get; set; }
        /// <summary> Whether or not public network access is allowed for the container registry. </summary>
        public ContainerRegistryPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Whether to allow trusted Azure services to access a network restricted registry. </summary>
        public ContainerRegistryNetworkRuleBypassOption? NetworkRuleBypassOptions { get; set; }
        /// <summary> Enables registry-wide pull from unauthenticated clients. </summary>
        public bool? IsAnonymousPullEnabled { get; set; }
    }
}
