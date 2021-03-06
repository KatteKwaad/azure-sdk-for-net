// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The resource link properties.
    /// </summary>
    public partial class ResourceLinkProperties
    {
        /// <summary>
        /// Initializes a new instance of the ResourceLinkProperties class.
        /// </summary>
        public ResourceLinkProperties() { }

        /// <summary>
        /// Initializes a new instance of the ResourceLinkProperties class.
        /// </summary>
        /// <param name="targetId">The fully qualified target resource Id. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite.</param>
        /// <param name="sourceId">The fully qualified source resource Id. </param>
        /// <param name="notes">The resource link notes.</param>
        public ResourceLinkProperties(string targetId, string sourceId = default(string), string notes = default(string))
        {
            SourceId = sourceId;
            TargetId = targetId;
            Notes = notes;
        }

        /// <summary>
        /// Gets the fully qualified source resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; private set; }

        /// <summary>
        /// Gets or sets the fully qualified target resource Id. For example,
        /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite.
        /// </summary>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or sets the resource link notes.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetId");
            }
        }
    }
}
