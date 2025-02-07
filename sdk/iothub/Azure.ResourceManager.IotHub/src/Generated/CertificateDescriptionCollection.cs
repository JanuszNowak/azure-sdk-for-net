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

namespace Azure.ResourceManager.IotHub
{
    /// <summary>
    /// A class representing a collection of <see cref="CertificateDescriptionResource" /> and their operations.
    /// Each <see cref="CertificateDescriptionResource" /> in the collection will belong to the same instance of <see cref="IotHubDescriptionResource" />.
    /// To get a <see cref="CertificateDescriptionCollection" /> instance call the GetCertificateDescriptions method from an instance of <see cref="IotHubDescriptionResource" />.
    /// </summary>
    public partial class CertificateDescriptionCollection : ArmCollection, IEnumerable<CertificateDescriptionResource>, IAsyncEnumerable<CertificateDescriptionResource>
    {
        private readonly ClientDiagnostics _certificateDescriptionCertificatesClientDiagnostics;
        private readonly CertificatesRestOperations _certificateDescriptionCertificatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CertificateDescriptionCollection"/> class for mocking. </summary>
        protected CertificateDescriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CertificateDescriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CertificateDescriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _certificateDescriptionCertificatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotHub", CertificateDescriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CertificateDescriptionResource.ResourceType, out string certificateDescriptionCertificatesApiVersion);
            _certificateDescriptionCertificatesRestClient = new CertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, certificateDescriptionCertificatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IotHubDescriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IotHubDescriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds new or replaces existing certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the Certificate. Do not specify for creating a brand new certificate. Required to update an existing certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CertificateDescriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateName, CertificateDescriptionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _certificateDescriptionCertificatesClientDiagnostics.CreateScope("CertificateDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _certificateDescriptionCertificatesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new IotHubArmOperation<CertificateDescriptionResource>(Response.FromValue(new CertificateDescriptionResource(Client, response), response.GetRawResponse()));
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
        /// Adds new or replaces existing certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the Certificate. Do not specify for creating a brand new certificate. Required to update an existing certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CertificateDescriptionResource> CreateOrUpdate(WaitUntil waitUntil, string certificateName, CertificateDescriptionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _certificateDescriptionCertificatesClientDiagnostics.CreateScope("CertificateDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _certificateDescriptionCertificatesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, ifMatch, cancellationToken);
                var operation = new IotHubArmOperation<CertificateDescriptionResource>(Response.FromValue(new CertificateDescriptionResource(Client, response), response.GetRawResponse()));
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
        /// Returns the certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_Get
        /// </summary>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<CertificateDescriptionResource>> GetAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _certificateDescriptionCertificatesClientDiagnostics.CreateScope("CertificateDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _certificateDescriptionCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CertificateDescriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_Get
        /// </summary>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<CertificateDescriptionResource> Get(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _certificateDescriptionCertificatesClientDiagnostics.CreateScope("CertificateDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _certificateDescriptionCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CertificateDescriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of certificates.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates
        /// Operation Id: Certificates_ListByIotHub
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CertificateDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CertificateDescriptionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CertificateDescriptionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _certificateDescriptionCertificatesClientDiagnostics.CreateScope("CertificateDescriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _certificateDescriptionCertificatesRestClient.ListByIotHubAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CertificateDescriptionResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Returns the list of certificates.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates
        /// Operation Id: Certificates_ListByIotHub
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CertificateDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CertificateDescriptionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CertificateDescriptionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _certificateDescriptionCertificatesClientDiagnostics.CreateScope("CertificateDescriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _certificateDescriptionCertificatesRestClient.ListByIotHub(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CertificateDescriptionResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_Get
        /// </summary>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _certificateDescriptionCertificatesClientDiagnostics.CreateScope("CertificateDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _certificateDescriptionCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_Get
        /// </summary>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _certificateDescriptionCertificatesClientDiagnostics.CreateScope("CertificateDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _certificateDescriptionCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CertificateDescriptionResource> IEnumerable<CertificateDescriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CertificateDescriptionResource> IAsyncEnumerable<CertificateDescriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
