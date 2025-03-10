// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The reference to the key vault key. </summary>
    public partial class IntegrationAccountKeyVaultKeyReference
    {
        /// <summary> Initializes a new instance of IntegrationAccountKeyVaultKeyReference. </summary>
        /// <param name="keyName"> The private key name in key vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public IntegrationAccountKeyVaultKeyReference(string keyName)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            KeyName = keyName;
        }

        /// <summary> Initializes a new instance of IntegrationAccountKeyVaultKeyReference. </summary>
        /// <param name="keyName"> The private key name in key vault. </param>
        /// <param name="keyVersion"> The private key version in key vault. </param>
        /// <param name="resourceId"> The resource id. </param>
        /// <param name="resourceName"> The resource name. </param>
        /// <param name="resourceType"> The resource type. </param>
        internal IntegrationAccountKeyVaultKeyReference(string keyName, string keyVersion, ResourceIdentifier resourceId, string resourceName, ResourceType? resourceType)
        {
            KeyName = keyName;
            KeyVersion = keyVersion;
            ResourceId = resourceId;
            ResourceName = resourceName;
            ResourceType = resourceType;
        }

        /// <summary> The private key name in key vault. </summary>
        public string KeyName { get; set; }
        /// <summary> The private key version in key vault. </summary>
        public string KeyVersion { get; set; }
        /// <summary> The resource id. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The resource name. </summary>
        public string ResourceName { get; }
        /// <summary> The resource type. </summary>
        public ResourceType? ResourceType { get; }
    }
}
