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

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A Class representing a Budget along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BudgetResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBudgetResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetBudget method.
    /// </summary>
    public partial class BudgetResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BudgetResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string budgetName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Consumption/budgets/{budgetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _budgetClientDiagnostics;
        private readonly BudgetsRestOperations _budgetRestClient;
        private readonly BudgetData _data;

        /// <summary> Initializes a new instance of the <see cref="BudgetResource"/> class for mocking. </summary>
        protected BudgetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BudgetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BudgetResource(ArmClient client, BudgetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BudgetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BudgetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _budgetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string budgetApiVersion);
            _budgetRestClient = new BudgetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, budgetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Consumption/budgets";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BudgetData Data
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
        /// Gets the budget for the scope by budget name.
        /// Request Path: /{scope}/providers/Microsoft.Consumption/budgets/{budgetName}
        /// Operation Id: Budgets_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BudgetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _budgetClientDiagnostics.CreateScope("BudgetResource.Get");
            scope.Start();
            try
            {
                var response = await _budgetRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BudgetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the budget for the scope by budget name.
        /// Request Path: /{scope}/providers/Microsoft.Consumption/budgets/{budgetName}
        /// Operation Id: Budgets_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BudgetResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _budgetClientDiagnostics.CreateScope("BudgetResource.Get");
            scope.Start();
            try
            {
                var response = _budgetRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BudgetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete a budget.
        /// Request Path: /{scope}/providers/Microsoft.Consumption/budgets/{budgetName}
        /// Operation Id: Budgets_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _budgetClientDiagnostics.CreateScope("BudgetResource.Delete");
            scope.Start();
            try
            {
                var response = await _budgetRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ConsumptionArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete a budget.
        /// Request Path: /{scope}/providers/Microsoft.Consumption/budgets/{budgetName}
        /// Operation Id: Budgets_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _budgetClientDiagnostics.CreateScope("BudgetResource.Delete");
            scope.Start();
            try
            {
                var response = _budgetRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new ConsumptionArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create or update a budget. You can optionally provide an eTag if desired as a form of concurrency control. To obtain the latest eTag for a given budget, perform a get operation prior to your put operation.
        /// Request Path: /{scope}/providers/Microsoft.Consumption/budgets/{budgetName}
        /// Operation Id: Budgets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create Budget operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BudgetResource>> UpdateAsync(WaitUntil waitUntil, BudgetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _budgetClientDiagnostics.CreateScope("BudgetResource.Update");
            scope.Start();
            try
            {
                var response = await _budgetRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConsumptionArmOperation<BudgetResource>(Response.FromValue(new BudgetResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create or update a budget. You can optionally provide an eTag if desired as a form of concurrency control. To obtain the latest eTag for a given budget, perform a get operation prior to your put operation.
        /// Request Path: /{scope}/providers/Microsoft.Consumption/budgets/{budgetName}
        /// Operation Id: Budgets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create Budget operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BudgetResource> Update(WaitUntil waitUntil, BudgetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _budgetClientDiagnostics.CreateScope("BudgetResource.Update");
            scope.Start();
            try
            {
                var response = _budgetRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new ConsumptionArmOperation<BudgetResource>(Response.FromValue(new BudgetResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
