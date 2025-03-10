// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary> A class representing the AppBuilderResource data model. </summary>
    public partial class AppBuilderResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of AppBuilderResourceData. </summary>
        public AppBuilderResourceData()
        {
        }

        /// <summary> Initializes a new instance of AppBuilderResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Property of the Builder resource. </param>
        internal AppBuilderResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppBuilderProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Property of the Builder resource. </summary>
        public AppBuilderProperties Properties { get; set; }
    }
}
