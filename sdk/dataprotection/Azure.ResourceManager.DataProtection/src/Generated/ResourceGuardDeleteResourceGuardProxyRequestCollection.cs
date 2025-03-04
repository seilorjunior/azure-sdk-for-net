// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataProtection
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceGuardDeleteResourceGuardProxyRequestResource" /> and their operations.
    /// Each <see cref="ResourceGuardDeleteResourceGuardProxyRequestResource" /> in the collection will belong to the same instance of <see cref="ResourceGuardResource" />.
    /// To get a <see cref="ResourceGuardDeleteResourceGuardProxyRequestCollection" /> instance call the GetResourceGuardDeleteResourceGuardProxyRequests method from an instance of <see cref="ResourceGuardResource" />.
    /// </summary>
    public partial class ResourceGuardDeleteResourceGuardProxyRequestCollection : ArmCollection, IEnumerable<ResourceGuardDeleteResourceGuardProxyRequestResource>, IAsyncEnumerable<ResourceGuardDeleteResourceGuardProxyRequestResource>
    {
        private readonly ClientDiagnostics _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics;
        private readonly ResourceGuardsRestOperations _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardDeleteResourceGuardProxyRequestCollection"/> class for mocking. </summary>
        protected ResourceGuardDeleteResourceGuardProxyRequestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardDeleteResourceGuardProxyRequestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResourceGuardDeleteResourceGuardProxyRequestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtection", ResourceGuardDeleteResourceGuardProxyRequestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGuardDeleteResourceGuardProxyRequestResource.ResourceType, out string resourceGuardDeleteResourceGuardProxyRequestResourceGuardsApiVersion);
            _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient = new ResourceGuardsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGuardDeleteResourceGuardProxyRequestResourceGuardsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGuardResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGuardResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns collection of operation request objects for a critical operation protected by the given ResourceGuard resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/deleteResourceGuardProxyRequests/{requestName}
        /// Operation Id: ResourceGuards_GetDefaultDeleteResourceGuardProxyRequestsObject
        /// </summary>
        /// <param name="requestName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestName"/> is null. </exception>
        public virtual async Task<Response<ResourceGuardDeleteResourceGuardProxyRequestResource>> GetAsync(string requestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestName, nameof(requestName));

            using var scope = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardDeleteResourceGuardProxyRequestCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient.GetDefaultDeleteResourceGuardProxyRequestsObjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, requestName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardDeleteResourceGuardProxyRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns collection of operation request objects for a critical operation protected by the given ResourceGuard resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/deleteResourceGuardProxyRequests/{requestName}
        /// Operation Id: ResourceGuards_GetDefaultDeleteResourceGuardProxyRequestsObject
        /// </summary>
        /// <param name="requestName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestName"/> is null. </exception>
        public virtual Response<ResourceGuardDeleteResourceGuardProxyRequestResource> Get(string requestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestName, nameof(requestName));

            using var scope = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardDeleteResourceGuardProxyRequestCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient.GetDefaultDeleteResourceGuardProxyRequestsObject(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, requestName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardDeleteResourceGuardProxyRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns collection of operation request objects for a critical operation protected by the given ResourceGuard resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/deleteResourceGuardProxyRequests
        /// Operation Id: ResourceGuards_GetDeleteResourceGuardProxyRequestsObjects
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGuardDeleteResourceGuardProxyRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGuardDeleteResourceGuardProxyRequestResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceGuardDeleteResourceGuardProxyRequestResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardDeleteResourceGuardProxyRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient.GetDeleteResourceGuardProxyRequestsObjectsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGuardDeleteResourceGuardProxyRequestResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceGuardDeleteResourceGuardProxyRequestResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardDeleteResourceGuardProxyRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient.GetDeleteResourceGuardProxyRequestsObjectsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGuardDeleteResourceGuardProxyRequestResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Returns collection of operation request objects for a critical operation protected by the given ResourceGuard resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/deleteResourceGuardProxyRequests
        /// Operation Id: ResourceGuards_GetDeleteResourceGuardProxyRequestsObjects
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGuardDeleteResourceGuardProxyRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGuardDeleteResourceGuardProxyRequestResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ResourceGuardDeleteResourceGuardProxyRequestResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardDeleteResourceGuardProxyRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient.GetDeleteResourceGuardProxyRequestsObjects(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGuardDeleteResourceGuardProxyRequestResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceGuardDeleteResourceGuardProxyRequestResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardDeleteResourceGuardProxyRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient.GetDeleteResourceGuardProxyRequestsObjectsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGuardDeleteResourceGuardProxyRequestResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/deleteResourceGuardProxyRequests/{requestName}
        /// Operation Id: ResourceGuards_GetDefaultDeleteResourceGuardProxyRequestsObject
        /// </summary>
        /// <param name="requestName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string requestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestName, nameof(requestName));

            using var scope = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardDeleteResourceGuardProxyRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient.GetDefaultDeleteResourceGuardProxyRequestsObjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, requestName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/deleteResourceGuardProxyRequests/{requestName}
        /// Operation Id: ResourceGuards_GetDefaultDeleteResourceGuardProxyRequestsObject
        /// </summary>
        /// <param name="requestName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestName"/> is null. </exception>
        public virtual Response<bool> Exists(string requestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestName, nameof(requestName));

            using var scope = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardDeleteResourceGuardProxyRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceGuardDeleteResourceGuardProxyRequestResourceGuardsRestClient.GetDefaultDeleteResourceGuardProxyRequestsObject(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, requestName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGuardDeleteResourceGuardProxyRequestResource> IEnumerable<ResourceGuardDeleteResourceGuardProxyRequestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGuardDeleteResourceGuardProxyRequestResource> IAsyncEnumerable<ResourceGuardDeleteResourceGuardProxyRequestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
