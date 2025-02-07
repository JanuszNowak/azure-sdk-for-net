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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceTagResource" /> and their operations.
    /// Each <see cref="ServiceTagResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get a <see cref="ServiceTagCollection" /> instance call the GetServiceTags method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ServiceTagCollection : ArmCollection, IEnumerable<ServiceTagResource>, IAsyncEnumerable<ServiceTagResource>
    {
        private readonly ClientDiagnostics _serviceTagTagClientDiagnostics;
        private readonly TagRestOperations _serviceTagTagRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceTagCollection"/> class for mocking. </summary>
        protected ServiceTagCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceTagCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceTagCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceTagTagClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceTagResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceTagResource.ResourceType, out string serviceTagTagApiVersion);
            _serviceTagTagRestClient = new TagRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceTagTagApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a tag.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}
        /// Operation Id: Tag_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="tagCreateUpdateParameters"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> or <paramref name="tagCreateUpdateParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceTagResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tagId, TagCreateUpdateParameters tagCreateUpdateParameters, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));
            Argument.AssertNotNull(tagCreateUpdateParameters, nameof(tagCreateUpdateParameters));

            using var scope = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceTagTagRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, tagCreateUpdateParameters, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceTagResource>(Response.FromValue(new ServiceTagResource(Client, response), response.GetRawResponse()));
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
        /// Creates a tag.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}
        /// Operation Id: Tag_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="tagCreateUpdateParameters"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> or <paramref name="tagCreateUpdateParameters"/> is null. </exception>
        public virtual ArmOperation<ServiceTagResource> CreateOrUpdate(WaitUntil waitUntil, string tagId, TagCreateUpdateParameters tagCreateUpdateParameters, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));
            Argument.AssertNotNull(tagCreateUpdateParameters, nameof(tagCreateUpdateParameters));

            using var scope = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceTagTagRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, tagCreateUpdateParameters, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceTagResource>(Response.FromValue(new ServiceTagResource(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Gets the details of the tag specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}
        /// Operation Id: Tag_Get
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<Response<ServiceTagResource>> GetAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceTagTagRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the tag specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}
        /// Operation Id: Tag_Get
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual Response<ServiceTagResource> Get(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceTagTagRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceTagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of tags defined within a service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags
        /// Operation Id: Tag_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="scope"> Scope like &apos;apis&apos;, &apos;products&apos; or &apos;apis/{apiId}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceTagResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceTagResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, string scope = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceTagResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = await _serviceTagTagRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, scope, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceTagResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceTagResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = await _serviceTagTagRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, scope, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceTagResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists a collection of tags defined within a service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags
        /// Operation Id: Tag_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="scope"> Scope like &apos;apis&apos;, &apos;products&apos; or &apos;apis/{apiId}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceTagResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceTagResource> GetAll(string filter = null, int? top = null, int? skip = null, string scope = null, CancellationToken cancellationToken = default)
        {
            Page<ServiceTagResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = _serviceTagTagRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, scope, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceTagResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            Page<ServiceTagResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = _serviceTagTagRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, scope, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceTagResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}
        /// Operation Id: Tag_Get
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope0 = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.Exists");
            scope0.Start();
            try
            {
                var response = await _serviceTagTagRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}
        /// Operation Id: Tag_Get
        /// </summary>
        /// <param name="tagId"> Tag identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagId"/> is null. </exception>
        public virtual Response<bool> Exists(string tagId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagId, nameof(tagId));

            using var scope0 = _serviceTagTagClientDiagnostics.CreateScope("ServiceTagCollection.Exists");
            scope0.Start();
            try
            {
                var response = _serviceTagTagRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tagId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceTagResource> IEnumerable<ServiceTagResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceTagResource> IAsyncEnumerable<ServiceTagResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
