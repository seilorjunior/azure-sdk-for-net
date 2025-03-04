// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataProtection
{
    /// <summary>
    /// A Class representing a ResourceGuardUpdateProtectedItemRequest along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ResourceGuardUpdateProtectedItemRequestResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetResourceGuardUpdateProtectedItemRequestResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGuardResource" /> using the GetResourceGuardUpdateProtectedItemRequest method.
    /// </summary>
    public partial class ResourceGuardUpdateProtectedItemRequestResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGuardUpdateProtectedItemRequestResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceGuardsName, string requestName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/updateProtectedItemRequests/{requestName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceGuardUpdateProtectedItemRequestResourceGuardsClientDiagnostics;
        private readonly ResourceGuardsRestOperations _resourceGuardUpdateProtectedItemRequestResourceGuardsRestClient;
        private readonly DppBaseResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardUpdateProtectedItemRequestResource"/> class for mocking. </summary>
        protected ResourceGuardUpdateProtectedItemRequestResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceGuardUpdateProtectedItemRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceGuardUpdateProtectedItemRequestResource(ArmClient client, DppBaseResourceData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardUpdateProtectedItemRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGuardUpdateProtectedItemRequestResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGuardUpdateProtectedItemRequestResourceGuardsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtection", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceGuardUpdateProtectedItemRequestResourceGuardsApiVersion);
            _resourceGuardUpdateProtectedItemRequestResourceGuardsRestClient = new ResourceGuardsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGuardUpdateProtectedItemRequestResourceGuardsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataProtection/resourceGuards/updateProtectedItemRequests";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DppBaseResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns collection of operation request objects for a critical operation protected by the given ResourceGuard resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/updateProtectedItemRequests/{requestName}
        /// Operation Id: ResourceGuards_GetDefaultUpdateProtectedItemRequestsObject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGuardUpdateProtectedItemRequestResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGuardUpdateProtectedItemRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardUpdateProtectedItemRequestResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceGuardUpdateProtectedItemRequestResourceGuardsRestClient.GetDefaultUpdateProtectedItemRequestsObjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardUpdateProtectedItemRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns collection of operation request objects for a critical operation protected by the given ResourceGuard resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/updateProtectedItemRequests/{requestName}
        /// Operation Id: ResourceGuards_GetDefaultUpdateProtectedItemRequestsObject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGuardUpdateProtectedItemRequestResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGuardUpdateProtectedItemRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardUpdateProtectedItemRequestResource.Get");
            scope.Start();
            try
            {
                var response = _resourceGuardUpdateProtectedItemRequestResourceGuardsRestClient.GetDefaultUpdateProtectedItemRequestsObject(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardUpdateProtectedItemRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
