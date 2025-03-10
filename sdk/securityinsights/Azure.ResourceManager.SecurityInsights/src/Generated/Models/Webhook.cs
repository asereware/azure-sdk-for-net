// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Detail about the webhook object. </summary>
    public partial class Webhook
    {
        /// <summary> Initializes a new instance of Webhook. </summary>
        public Webhook()
        {
        }

        /// <summary> Initializes a new instance of Webhook. </summary>
        /// <param name="webhookId"> Unique identifier for the webhook. </param>
        /// <param name="webhookUri"> URL that gets invoked by the webhook. </param>
        /// <param name="webhookSecretUpdateTime"> Time when the webhook secret was updated. </param>
        /// <param name="rotateWebhookSecret"> A flag to instruct the backend service to rotate webhook secret. </param>
        internal Webhook(string webhookId, Uri webhookUri, string webhookSecretUpdateTime, bool? rotateWebhookSecret)
        {
            WebhookId = webhookId;
            WebhookUri = webhookUri;
            WebhookSecretUpdateTime = webhookSecretUpdateTime;
            RotateWebhookSecret = rotateWebhookSecret;
        }

        /// <summary> Unique identifier for the webhook. </summary>
        public string WebhookId { get; set; }
        /// <summary> URL that gets invoked by the webhook. </summary>
        public Uri WebhookUri { get; set; }
        /// <summary> Time when the webhook secret was updated. </summary>
        public string WebhookSecretUpdateTime { get; set; }
        /// <summary> A flag to instruct the backend service to rotate webhook secret. </summary>
        public bool? RotateWebhookSecret { get; set; }
    }
}
