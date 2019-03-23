// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of registration definition inside registration assignment.
    /// </summary>
    public partial class RegistrationAssignmentPropertiesRegistrationDefinitionProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RegistrationAssignmentPropertiesRegistrationDefinitionProperties
        /// class.
        /// </summary>
        public RegistrationAssignmentPropertiesRegistrationDefinitionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RegistrationAssignmentPropertiesRegistrationDefinitionProperties
        /// class.
        /// </summary>
        /// <param name="description">Description of the registration
        /// definition.</param>
        /// <param name="authorizations">Authorization tuple containing
        /// principal id of the user/security group or service principal and id
        /// of the build-in role.</param>
        /// <param name="registrationDefinitionName">Name of the registration
        /// definition.</param>
        /// <param name="provisioningState">Current state of the registration
        /// definition. Possible values include: 'NotSpecified', 'Accepted',
        /// 'Running', 'Ready', 'Creating', 'Created', 'Deleting', 'Deleted',
        /// 'Canceled', 'Failed', 'Succeeded', 'Updating'</param>
        /// <param name="manageeTenantId">Id of the home tenant.</param>
        /// <param name="manageeTenantName">Name of the home tenant.</param>
        /// <param name="managedByTenantId">Id of the managedBy tenant.</param>
        /// <param name="managedByTenantName">Name of the managedBy
        /// tenant.</param>
        public RegistrationAssignmentPropertiesRegistrationDefinitionProperties(string description = default(string), IList<Authorization> authorizations = default(IList<Authorization>), string registrationDefinitionName = default(string), ProvisioningState? provisioningState = default(ProvisioningState?), string manageeTenantId = default(string), string manageeTenantName = default(string), string managedByTenantId = default(string), string managedByTenantName = default(string))
        {
            Description = description;
            Authorizations = authorizations;
            RegistrationDefinitionName = registrationDefinitionName;
            ProvisioningState = provisioningState;
            ManageeTenantId = manageeTenantId;
            ManageeTenantName = manageeTenantName;
            ManagedByTenantId = managedByTenantId;
            ManagedByTenantName = managedByTenantName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the registration definition.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets authorization tuple containing principal id of the
        /// user/security group or service principal and id of the build-in
        /// role.
        /// </summary>
        [JsonProperty(PropertyName = "authorizations")]
        public IList<Authorization> Authorizations { get; set; }

        /// <summary>
        /// Gets or sets name of the registration definition.
        /// </summary>
        [JsonProperty(PropertyName = "registrationDefinitionName")]
        public string RegistrationDefinitionName { get; set; }

        /// <summary>
        /// Gets or sets current state of the registration definition. Possible
        /// values include: 'NotSpecified', 'Accepted', 'Running', 'Ready',
        /// 'Creating', 'Created', 'Deleting', 'Deleted', 'Canceled', 'Failed',
        /// 'Succeeded', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets id of the home tenant.
        /// </summary>
        [JsonProperty(PropertyName = "manageeTenantId")]
        public string ManageeTenantId { get; set; }

        /// <summary>
        /// Gets or sets name of the home tenant.
        /// </summary>
        [JsonProperty(PropertyName = "manageeTenantName")]
        public string ManageeTenantName { get; set; }

        /// <summary>
        /// Gets or sets id of the managedBy tenant.
        /// </summary>
        [JsonProperty(PropertyName = "managedByTenantId")]
        public string ManagedByTenantId { get; set; }

        /// <summary>
        /// Gets or sets name of the managedBy tenant.
        /// </summary>
        [JsonProperty(PropertyName = "managedByTenantName")]
        public string ManagedByTenantName { get; set; }

    }
}
