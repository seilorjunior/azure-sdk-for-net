// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Azure.WebJobs.EventHubs
{
    internal static class Constants
    {
        //public const string DefaultConnectionStringName = "ServiceBus";
        //public const string DefaultConnectionSettingStringName = "AzureWebJobsServiceBus";
        //public const string DynamicSku = "Dynamic";
        //public const string AzureWebsiteSku = "WEBSITE_SKU";
        public const string TargetBasedScalingEnabled = "TARGET_BASED_SCALING_ENABLED";
        public const string DynamicConcurrencyEnabled = "DYNAMIC_CONCURRENCY_ENABLED";
        public const string TargetEventHubsMetric = "TARGET_EVENTHUBS_METRIC";
        public const int DefaultTargetEventHubsMetric = 16;//needs to check
    }
}
