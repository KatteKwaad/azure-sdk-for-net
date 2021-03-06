// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Represents an index definition in Azure Search, which describes the
    /// fields and search behavior of an index.
    /// </summary>
    public partial class Index
    {
        /// <summary>
        /// Initializes a new instance of the Index class.
        /// </summary>
        public Index() { }

        /// <summary>
        /// Initializes a new instance of the Index class.
        /// </summary>
        public Index(string name, IList<Field> fields, IList<ScoringProfile> scoringProfiles = default(IList<ScoringProfile>), string defaultScoringProfile = default(string), CorsOptions corsOptions = default(CorsOptions), IList<Suggester> suggesters = default(IList<Suggester>), IList<Analyzer> analyzers = default(IList<Analyzer>), IList<Tokenizer> tokenizers = default(IList<Tokenizer>), IList<TokenFilter> tokenFilters = default(IList<TokenFilter>), IList<CharFilter> charFilters = default(IList<CharFilter>), string eTag = default(string))
        {
            Name = name;
            Fields = fields;
            ScoringProfiles = scoringProfiles;
            DefaultScoringProfile = defaultScoringProfile;
            CorsOptions = corsOptions;
            Suggesters = suggesters;
            Analyzers = analyzers;
            Tokenizers = tokenizers;
            TokenFilters = tokenFilters;
            CharFilters = charFilters;
            ETag = eTag;
        }

        /// <summary>
        /// Gets or sets the name of the index.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the fields of the index.
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public IList<Field> Fields { get; set; }

        /// <summary>
        /// Gets or sets the scoring profiles for the index.
        /// </summary>
        [JsonProperty(PropertyName = "scoringProfiles")]
        public IList<ScoringProfile> ScoringProfiles { get; set; }

        /// <summary>
        /// Gets or sets the name of the scoring profile to use if none is
        /// specified in the query. If this property is not set and no
        /// scoring profile is specified in the query, then default scoring
        /// (tf-idf) will be used.
        /// </summary>
        [JsonProperty(PropertyName = "defaultScoringProfile")]
        public string DefaultScoringProfile { get; set; }

        /// <summary>
        /// Gets or sets options to control Cross-Origin Resource Sharing
        /// (CORS) for the index.
        /// </summary>
        [JsonProperty(PropertyName = "corsOptions")]
        public CorsOptions CorsOptions { get; set; }

        /// <summary>
        /// Gets or sets the suggesters for the index.
        /// </summary>
        [JsonProperty(PropertyName = "suggesters")]
        public IList<Suggester> Suggesters { get; set; }

        /// <summary>
        /// Gets or sets the analyzers for the index.
        /// </summary>
        [JsonProperty(PropertyName = "analyzers")]
        public IList<Analyzer> Analyzers { get; set; }

        /// <summary>
        /// Gets or sets the tokenizers for the index.
        /// </summary>
        [JsonProperty(PropertyName = "tokenizers")]
        public IList<Tokenizer> Tokenizers { get; set; }

        /// <summary>
        /// Gets or sets the token filters for the index.
        /// </summary>
        [JsonProperty(PropertyName = "tokenFilters")]
        public IList<TokenFilter> TokenFilters { get; set; }

        /// <summary>
        /// Gets or sets the character filters for the index.
        /// </summary>
        [JsonProperty(PropertyName = "charFilters")]
        public IList<CharFilter> CharFilters { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the index.
        /// </summary>
        [JsonProperty(PropertyName = "@odata.etag")]
        public string ETag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Fields == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Fields");
            }
            if (this.Fields != null)
            {
                foreach (var element in this.Fields)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.ScoringProfiles != null)
            {
                foreach (var element1 in this.ScoringProfiles)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.CorsOptions != null)
            {
                this.CorsOptions.Validate();
            }
            if (this.Suggesters != null)
            {
                foreach (var element2 in this.Suggesters)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (this.Analyzers != null)
            {
                foreach (var element3 in this.Analyzers)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (this.Tokenizers != null)
            {
                foreach (var element4 in this.Tokenizers)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
            if (this.TokenFilters != null)
            {
                foreach (var element5 in this.TokenFilters)
                {
                    if (element5 != null)
                    {
                        element5.Validate();
                    }
                }
            }
            if (this.CharFilters != null)
            {
                foreach (var element6 in this.CharFilters)
                {
                    if (element6 != null)
                    {
                        element6.Validate();
                    }
                }
            }
        }
    }
}
