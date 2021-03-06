// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;
    using Microsoft.Azure.KeyVault.WebKey;

    /// <summary>
    /// The key import parameters
    /// </summary>
    public partial class KeyImportParameters
    {
        /// <summary>
        /// Initializes a new instance of the KeyImportParameters class.
        /// </summary>
        public KeyImportParameters() { }

        /// <summary>
        /// Initializes a new instance of the KeyImportParameters class.
        /// </summary>
        /// <param name="key">The Json web key</param>
        /// <param name="hsm">Whether to import as a hardware key (HSM) or
        /// software key</param>
        /// <param name="keyAttributes">The key management attributes</param>
        /// <param name="tags">Application-specific metadata in the form of
        /// key-value pairs</param>
        public KeyImportParameters(JsonWebKey key, bool? hsm = default(bool?), KeyAttributes keyAttributes = default(KeyAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Hsm = hsm;
            Key = key;
            KeyAttributes = keyAttributes;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets whether to import as a hardware key (HSM) or software
        /// key
        /// </summary>
        [JsonProperty(PropertyName = "Hsm")]
        public bool? Hsm { get; set; }

        /// <summary>
        /// Gets or sets the Json web key
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public JsonWebKey Key { get; set; }

        /// <summary>
        /// Gets or sets the key management attributes
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public KeyAttributes KeyAttributes { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of
        /// key-value pairs
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Key == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Key");
            }
        }
    }
}
