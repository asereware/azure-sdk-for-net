// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Azure.Core;
using Azure.Monitor.OpenTelemetry.Exporter.Internals;
using Azure.Monitor.OpenTelemetry.Exporter.Models;

namespace Azure.Monitor.OpenTelemetry.Exporter
{
    internal partial class ApplicationInsightsRestClient
    {
        /// <summary>
        /// This operation sends a sequence of telemetry events that will be monitored by Azure Monitor.
        /// </summary>
        /// <param name="body">The list of telemetry events to track.</param>
        /// <param name="cancellationToken">The cancellation token to use.</param>
        /// <returns></returns>
        internal async Task<HttpMessage> InternalTrackAsync(IEnumerable<TelemetryItem> body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            var message = CreateTrackRequest(body);

            try
            {
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                AzureMonitorExporterEventSource.Log.WriteError("FailedToSend", ex);
                if (ex.InnerException?.Source != "System.Net.Http")
                {
                    message?.Dispose();
                    throw;
                }
            }

            return message;
        }

        /// <summary>
        /// This operation sends a blob from persistent storage that will be monitored by Azure Monitor.
        /// </summary>
        /// <param name="body">Content of blob to track.</param>
        /// <param name="cancellationToken">The cancellation token to use.</param>
        /// <returns></returns>
        internal async Task<HttpMessage> InternalTrackAsync(ReadOnlyMemory<byte> body, CancellationToken cancellationToken = default)
        {
            var message = CreateTrackRequest(body);

            try
            {
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                AzureMonitorExporterEventSource.Log.WriteError("FailedToSend", ex);
                if (ex.InnerException?.Source != "System.Net.Http")
                {
                    message?.Dispose();
                    throw;
                }
            }

            return message;
        }

        internal HttpMessage CreateTrackRequest(IEnumerable<TelemetryItem> body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_host, false);
            uri.AppendRaw("/v2", false);
            uri.AppendPath("/track", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            using var content = new NDJsonWriter();
            foreach (var item in body)
            {
                content.JsonWriter.WriteObjectValue(item);
                content.WriteNewLine();
            }
            request.Content = RequestContent.Create(content.ToBytes());
            TelemetryDebugWriter.WriteTelemetry(content);
            return message;
        }

        internal HttpMessage CreateTrackRequest(ReadOnlyMemory<byte> body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_host, false);
            uri.AppendRaw("/v2", false);
            uri.AppendPath("/track", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            using var content = new NDJsonWriter();
            request.Content = RequestContent.Create(body);
            TelemetryDebugWriter.WriteTelemetry(content);
            return message;
        }
    }
}
