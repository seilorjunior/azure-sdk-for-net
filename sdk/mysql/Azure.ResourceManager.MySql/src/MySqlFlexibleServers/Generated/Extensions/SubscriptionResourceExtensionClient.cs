// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _mySqlFlexibleServerServersClientDiagnostics;
        private ServersRestOperations _mySqlFlexibleServerServersRestClient;
        private ClientDiagnostics _locationBasedCapabilitiesClientDiagnostics;
        private LocationBasedCapabilitiesRestOperations _locationBasedCapabilitiesRestClient;
        private ClientDiagnostics _checkVirtualNetworkSubnetUsageClientDiagnostics;
        private CheckVirtualNetworkSubnetUsageRestOperations _checkVirtualNetworkSubnetUsageRestClient;
        private ClientDiagnostics _checkNameAvailabilityClientDiagnostics;
        private CheckNameAvailabilityRestOperations _checkNameAvailabilityRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics MySqlFlexibleServerServersClientDiagnostics => _mySqlFlexibleServerServersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", MySqlFlexibleServerResource.ResourceType.Namespace, Diagnostics);
        private ServersRestOperations MySqlFlexibleServerServersRestClient => _mySqlFlexibleServerServersRestClient ??= new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MySqlFlexibleServerResource.ResourceType));
        private ClientDiagnostics LocationBasedCapabilitiesClientDiagnostics => _locationBasedCapabilitiesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationBasedCapabilitiesRestOperations LocationBasedCapabilitiesRestClient => _locationBasedCapabilitiesRestClient ??= new LocationBasedCapabilitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckVirtualNetworkSubnetUsageClientDiagnostics => _checkVirtualNetworkSubnetUsageClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckVirtualNetworkSubnetUsageRestOperations CheckVirtualNetworkSubnetUsageRestClient => _checkVirtualNetworkSubnetUsageRestClient ??= new CheckVirtualNetworkSubnetUsageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckNameAvailabilityClientDiagnostics => _checkNameAvailabilityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityRestOperations CheckNameAvailabilityRestClient => _checkNameAvailabilityRestClient ??= new CheckNameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/flexibleServers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServerResource> GetMySqlFlexibleServersAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MySqlFlexibleServerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MySqlFlexibleServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMySqlFlexibleServers");
                scope.Start();
                try
                {
                    var response = await MySqlFlexibleServerServersRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlFlexibleServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MySqlFlexibleServerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = MySqlFlexibleServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMySqlFlexibleServers");
                scope.Start();
                try
                {
                    var response = await MySqlFlexibleServerServersRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlFlexibleServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/flexibleServers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServerResource> GetMySqlFlexibleServers(CancellationToken cancellationToken = default)
        {
            Page<MySqlFlexibleServerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MySqlFlexibleServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMySqlFlexibleServers");
                scope.Start();
                try
                {
                    var response = MySqlFlexibleServerServersRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlFlexibleServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MySqlFlexibleServerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = MySqlFlexibleServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMySqlFlexibleServers");
                scope.Start();
                try
                {
                    var response = MySqlFlexibleServerServersRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlFlexibleServerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilities
        /// Operation Id: LocationBasedCapabilities_List
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerCapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServerCapabilityProperties> GetLocationBasedCapabilitiesAsync(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            async Task<Page<MySqlFlexibleServerCapabilityProperties>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LocationBasedCapabilitiesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLocationBasedCapabilities");
                scope.Start();
                try
                {
                    var response = await LocationBasedCapabilitiesRestClient.ListAsync(Id.SubscriptionId, locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MySqlFlexibleServerCapabilityProperties>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = LocationBasedCapabilitiesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLocationBasedCapabilities");
                scope.Start();
                try
                {
                    var response = await LocationBasedCapabilitiesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilities
        /// Operation Id: LocationBasedCapabilities_List
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerCapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServerCapabilityProperties> GetLocationBasedCapabilities(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            Page<MySqlFlexibleServerCapabilityProperties> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LocationBasedCapabilitiesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLocationBasedCapabilities");
                scope.Start();
                try
                {
                    var response = LocationBasedCapabilitiesRestClient.List(Id.SubscriptionId, locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MySqlFlexibleServerCapabilityProperties> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = LocationBasedCapabilitiesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLocationBasedCapabilities");
                scope.Start();
                try
                {
                    var response = LocationBasedCapabilitiesRestClient.ListNextPage(nextLink, Id.SubscriptionId, locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkVirtualNetworkSubnetUsage
        /// Operation Id: CheckVirtualNetworkSubnetUsage_Execute
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="mySqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>> ExecuteCheckVirtualNetworkSubnetUsageAsync(AzureLocation locationName, MySqlFlexibleServerVirtualNetworkSubnetUsageParameter mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            using var scope = CheckVirtualNetworkSubnetUsageClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ExecuteCheckVirtualNetworkSubnetUsage");
            scope.Start();
            try
            {
                var response = await CheckVirtualNetworkSubnetUsageRestClient.ExecuteAsync(Id.SubscriptionId, locationName, mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkVirtualNetworkSubnetUsage
        /// Operation Id: CheckVirtualNetworkSubnetUsage_Execute
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="mySqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlFlexibleServerVirtualNetworkSubnetUsageResult> ExecuteCheckVirtualNetworkSubnetUsage(AzureLocation locationName, MySqlFlexibleServerVirtualNetworkSubnetUsageParameter mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            using var scope = CheckVirtualNetworkSubnetUsageClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ExecuteCheckVirtualNetworkSubnetUsage");
            scope.Start();
            try
            {
                var response = CheckVirtualNetworkSubnetUsageRestClient.Execute(Id.SubscriptionId, locationName, mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of name for server
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if server name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlFlexibleServerNameAvailabilityResult>> CheckMySqlFlexibleServerNameAvailabilityAsync(AzureLocation locationName, MySqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMySqlFlexibleServerNameAvailability");
            scope.Start();
            try
            {
                var response = await CheckNameAvailabilityRestClient.ExecuteAsync(Id.SubscriptionId, locationName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of name for server
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if server name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlFlexibleServerNameAvailabilityResult> CheckMySqlFlexibleServerNameAvailability(AzureLocation locationName, MySqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMySqlFlexibleServerNameAvailability");
            scope.Start();
            try
            {
                var response = CheckNameAvailabilityRestClient.Execute(Id.SubscriptionId, locationName, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
