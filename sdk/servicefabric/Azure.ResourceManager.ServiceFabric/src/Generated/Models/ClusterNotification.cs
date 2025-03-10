// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the notification channel for cluster events. </summary>
    public partial class ClusterNotification
    {
        /// <summary> Initializes a new instance of ClusterNotification. </summary>
        /// <param name="isEnabled"> Indicates if the notification is enabled. </param>
        /// <param name="notificationCategory"> The category of notification. </param>
        /// <param name="notificationLevel"> The level of notification. </param>
        /// <param name="notificationTargets"> List of targets that subscribe to the notification. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationTargets"/> is null. </exception>
        public ClusterNotification(bool isEnabled, ClusterNotificationCategory notificationCategory, ClusterNotificationLevel notificationLevel, IEnumerable<ClusterNotificationTarget> notificationTargets)
        {
            if (notificationTargets == null)
            {
                throw new ArgumentNullException(nameof(notificationTargets));
            }

            IsEnabled = isEnabled;
            NotificationCategory = notificationCategory;
            NotificationLevel = notificationLevel;
            NotificationTargets = notificationTargets.ToList();
        }

        /// <summary> Initializes a new instance of ClusterNotification. </summary>
        /// <param name="isEnabled"> Indicates if the notification is enabled. </param>
        /// <param name="notificationCategory"> The category of notification. </param>
        /// <param name="notificationLevel"> The level of notification. </param>
        /// <param name="notificationTargets"> List of targets that subscribe to the notification. </param>
        internal ClusterNotification(bool isEnabled, ClusterNotificationCategory notificationCategory, ClusterNotificationLevel notificationLevel, IList<ClusterNotificationTarget> notificationTargets)
        {
            IsEnabled = isEnabled;
            NotificationCategory = notificationCategory;
            NotificationLevel = notificationLevel;
            NotificationTargets = notificationTargets;
        }

        /// <summary> Indicates if the notification is enabled. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> The category of notification. </summary>
        public ClusterNotificationCategory NotificationCategory { get; set; }
        /// <summary> The level of notification. </summary>
        public ClusterNotificationLevel NotificationLevel { get; set; }
        /// <summary> List of targets that subscribe to the notification. </summary>
        public IList<ClusterNotificationTarget> NotificationTargets { get; }
    }
}
