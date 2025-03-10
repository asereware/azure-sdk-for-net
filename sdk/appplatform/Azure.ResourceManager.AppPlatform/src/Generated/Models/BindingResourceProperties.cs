// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Binding resource properties payload. </summary>
    public partial class BindingResourceProperties
    {
        /// <summary> Initializes a new instance of BindingResourceProperties. </summary>
        public BindingResourceProperties()
        {
            BindingParameters = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of BindingResourceProperties. </summary>
        /// <param name="resourceName"> The name of the bound resource. </param>
        /// <param name="resourceType"> The standard Azure resource type of the bound resource. </param>
        /// <param name="resourceId"> The Azure resource id of the bound resource. </param>
        /// <param name="key"> The key of the bound resource. </param>
        /// <param name="bindingParameters"> Binding parameters of the Binding resource. </param>
        /// <param name="generatedProperties"> The generated Spring Boot property file for this binding. The secret will be deducted. </param>
        /// <param name="createdAt"> Creation time of the Binding resource. </param>
        /// <param name="updatedAt"> Update time of the Binding resource. </param>
        internal BindingResourceProperties(string resourceName, ResourceType? resourceType, ResourceIdentifier resourceId, string key, IDictionary<string, BinaryData> bindingParameters, string generatedProperties, string createdAt, string updatedAt)
        {
            ResourceName = resourceName;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Key = key;
            BindingParameters = bindingParameters;
            GeneratedProperties = generatedProperties;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        /// <summary> The name of the bound resource. </summary>
        public string ResourceName { get; }
        /// <summary> The standard Azure resource type of the bound resource. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The Azure resource id of the bound resource. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The key of the bound resource. </summary>
        public string Key { get; set; }
        /// <summary> Binding parameters of the Binding resource. </summary>
        public IDictionary<string, BinaryData> BindingParameters { get; }
        /// <summary> The generated Spring Boot property file for this binding. The secret will be deducted. </summary>
        public string GeneratedProperties { get; }
        /// <summary> Creation time of the Binding resource. </summary>
        public string CreatedAt { get; }
        /// <summary> Update time of the Binding resource. </summary>
        public string UpdatedAt { get; }
    }
}
