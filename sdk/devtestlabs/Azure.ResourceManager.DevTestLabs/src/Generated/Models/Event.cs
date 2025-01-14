// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> An event to be notified for. </summary>
    public partial class Event
    {
        /// <summary> Initializes a new instance of Event. </summary>
        public Event()
        {
        }

        /// <summary> Initializes a new instance of Event. </summary>
        /// <param name="eventName"> The event type for which this notification is enabled (i.e. AutoShutdown, Cost). </param>
        internal Event(NotificationChannelEventType? eventName)
        {
            EventName = eventName;
        }

        /// <summary> The event type for which this notification is enabled (i.e. AutoShutdown, Cost). </summary>
        public NotificationChannelEventType? EventName { get; set; }
    }
}
