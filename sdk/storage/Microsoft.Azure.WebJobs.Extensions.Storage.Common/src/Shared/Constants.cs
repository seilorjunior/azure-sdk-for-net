// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Azure.WebJobs.Extensions.Storage.Common
{
    internal static class Constants
    {
        public const string DateTimeFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffK";
        public const string TargetBasedScalingEnabled = "TARGET_BASED_SCALING_ENABLED";
        public const string DynamicConcurrencyEnabled = "DYNAMIC_CONCURRENCY_ENABLED";
        public const string TargetStorageQueueMetric = "TARGET_STORAGEQUEUE_METRIC";
        public const int DefaultTargetStorageQueueMetric = 16;
    }
}
