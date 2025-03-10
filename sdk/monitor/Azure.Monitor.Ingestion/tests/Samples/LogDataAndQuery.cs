﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Monitor.Query;
using Azure.Monitor.Query.Models;

namespace Azure.Monitor.Ingestion.Tests.Samples
{
    public partial class IngestionSamples: SamplesBase<MonitorIngestionTestEnvironment>
    {
        public void SetUpClient()
        {
            #region Snippet:CreateLogsIngestionClient
            var dataCollectionEndpoint = new Uri("...");
            var credential = new DefaultAzureCredential();
            var client = new LogsIngestionClient(dataCollectionEndpoint, credential);
            #endregion
        }

        public void LogData()
        {
            #region Snippet:UploadCustomLogs
            var dataCollectionEndpoint = new Uri("...");
            var dataCollectionRuleImmutableId = "...";
            var streamName = "...";

            TokenCredential credential = new DefaultAzureCredential();
#if SNIPPET
#else
            dataCollectionEndpoint = new Uri(TestEnvironment.DCREndpoint);
            credential = TestEnvironment.Credential;
#endif
            LogsIngestionClient client = new(dataCollectionEndpoint, credential);

            DateTimeOffset currentTime = DateTimeOffset.UtcNow;

            // Use BinaryData to serialize instances of an anonymous type into JSON
            BinaryData data = BinaryData.FromObjectAsJson(
                new[] {
                    new
                    {
                        Time = currentTime,
                        Computer = "Computer1",
                        AdditionalContext = new
                        {
                            InstanceName = "user1",
                            TimeZone = "Pacific Time",
                            Level = 4,
                            CounterName = "AppMetric1",
                            CounterValue = 15.3
                        }
                    },
                    new
                    {
                        Time = currentTime,
                        Computer = "Computer2",
                        AdditionalContext = new
                        {
                            InstanceName = "user2",
                            TimeZone = "Central Time",
                            Level = 3,
                            CounterName = "AppMetric1",
                            CounterValue = 23.5
                        }
                    },
                });

            // Upload our logs
            Response response = client.Upload(dataCollectionRuleImmutableId, streamName, RequestContent.Create(data));
            #endregion
        }

        public void QueryData()
        {
            #region Snippet:VerifyLogs
            var workspaceId = "...";
            var tableName = "...";

            TokenCredential credential = new DefaultAzureCredential();
#if SNIPPET
#else
            credential = TestEnvironment.Credential;
#endif

            LogsQueryClient logsQueryClient = new(credential);
            LogsBatchQuery batch = new();
            string query = tableName + " | count;";
            string countQueryId = batch.AddWorkspaceQuery(
                workspaceId,
                query,
                new QueryTimeRange(TimeSpan.FromDays(1)));

            Response<LogsBatchQueryResultCollection> queryResponse = logsQueryClient.QueryBatch(batch);

            Console.WriteLine("Table entry count: " + queryResponse.Value.GetResult<int>(countQueryId).Single());
            #endregion
        }
    }
}
