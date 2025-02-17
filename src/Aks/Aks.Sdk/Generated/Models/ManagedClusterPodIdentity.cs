// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Details about the pod identity assigned to the Managed Cluster.
    /// </summary>
    public partial class ManagedClusterPodIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterPodIdentity class.
        /// </summary>
        public ManagedClusterPodIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterPodIdentity class.
        /// </summary>

        /// <param name="name">The name of the pod identity.
        /// </param>

        /// <param name="namespaceProperty">The namespace of the pod identity.
        /// </param>

        /// <param name="bindingSelector">The binding selector to use for the AzureIdentityBinding resource.
        /// </param>

        /// <param name="identity">The user assigned identity details.
        /// </param>

        /// <param name="provisioningState">The current provisioning state of the pod identity.
        /// Possible values include: 'Assigned', 'Canceled', 'Deleting', 'Failed',
        /// 'Succeeded', 'Updating'</param>

        /// <param name="provisioningInfo">
        /// </param>
        public ManagedClusterPodIdentity(string name, string namespaceProperty, UserAssignedIdentity identity, string bindingSelector = default(string), string provisioningState = default(string), ManagedClusterPodIdentityProvisioningInfo provisioningInfo = default(ManagedClusterPodIdentityProvisioningInfo))

        {
            this.Name = name;
            this.NamespaceProperty = namespaceProperty;
            this.BindingSelector = bindingSelector;
            this.Identity = identity;
            this.ProvisioningState = provisioningState;
            this.ProvisioningInfo = provisioningInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of the pod identity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets the namespace of the pod identity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty {get; set; }

        /// <summary>
        /// Gets or sets the binding selector to use for the AzureIdentityBinding
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "bindingSelector")]
        public string BindingSelector {get; set; }

        /// <summary>
        /// Gets or sets the user assigned identity details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public UserAssignedIdentity Identity {get; set; }

        /// <summary>
        /// Gets the current provisioning state of the pod identity. Possible values include: &#39;Assigned&#39;, &#39;Canceled&#39;, &#39;Deleting&#39;, &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Updating&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningInfo")]
        public ManagedClusterPodIdentityProvisioningInfo ProvisioningInfo {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.NamespaceProperty == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "NamespaceProperty");
            }
            if (this.Identity == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Identity");
            }






        }
    }
}