// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Full endpoint url of an event subscription. </summary>
    public partial class EventSubscriptionFullUri
    {
        /// <summary> Initializes a new instance of EventSubscriptionFullUri. </summary>
        internal EventSubscriptionFullUri()
        {
        }

        /// <summary> Initializes a new instance of EventSubscriptionFullUri. </summary>
        /// <param name="endpointUri"> The URL that represents the endpoint of the destination of an event subscription. </param>
        internal EventSubscriptionFullUri(Uri endpointUri)
        {
            EndpointUri = endpointUri;
        }

        /// <summary> The URL that represents the endpoint of the destination of an event subscription. </summary>
        public Uri EndpointUri { get; }
    }
}
