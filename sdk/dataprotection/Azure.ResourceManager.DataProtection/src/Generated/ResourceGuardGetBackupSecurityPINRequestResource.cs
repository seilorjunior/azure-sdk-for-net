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
    /// A Class representing a ResourceGuardGetBackupSecurityPINRequest along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ResourceGuardGetBackupSecurityPINRequestResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetResourceGuardGetBackupSecurityPINRequestResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGuardResource" /> using the GetResourceGuardGetBackupSecurityPINRequest method.
    /// </summary>
    public partial class ResourceGuardGetBackupSecurityPINRequestResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGuardGetBackupSecurityPINRequestResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceGuardsName, string requestName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/getBackupSecurityPINRequests/{requestName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceGuardGetBackupSecurityPINRequestResourceGuardsClientDiagnostics;
        private readonly ResourceGuardsRestOperations _resourceGuardGetBackupSecurityPINRequestResourceGuardsRestClient;
        private readonly DppBaseResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardGetBackupSecurityPINRequestResource"/> class for mocking. </summary>
        protected ResourceGuardGetBackupSecurityPINRequestResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceGuardGetBackupSecurityPINRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceGuardGetBackupSecurityPINRequestResource(ArmClient client, DppBaseResourceData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardGetBackupSecurityPINRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGuardGetBackupSecurityPINRequestResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGuardGetBackupSecurityPINRequestResourceGuardsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtection", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceGuardGetBackupSecurityPINRequestResourceGuardsApiVersion);
            _resourceGuardGetBackupSecurityPINRequestResourceGuardsRestClient = new ResourceGuardsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGuardGetBackupSecurityPINRequestResourceGuardsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataProtection/resourceGuards/getBackupSecurityPINRequests";

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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/getBackupSecurityPINRequests/{requestName}
        /// Operation Id: ResourceGuards_GetDefaultBackupSecurityPINRequestsObject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGuardGetBackupSecurityPINRequestResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGuardGetBackupSecurityPINRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardGetBackupSecurityPINRequestResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceGuardGetBackupSecurityPINRequestResourceGuardsRestClient.GetDefaultBackupSecurityPINRequestsObjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardGetBackupSecurityPINRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns collection of operation request objects for a critical operation protected by the given ResourceGuard resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}/getBackupSecurityPINRequests/{requestName}
        /// Operation Id: ResourceGuards_GetDefaultBackupSecurityPINRequestsObject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGuardGetBackupSecurityPINRequestResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGuardGetBackupSecurityPINRequestResourceGuardsClientDiagnostics.CreateScope("ResourceGuardGetBackupSecurityPINRequestResource.Get");
            scope.Start();
            try
            {
                var response = _resourceGuardGetBackupSecurityPINRequestResourceGuardsRestClient.GetDefaultBackupSecurityPINRequestsObject(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardGetBackupSecurityPINRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
