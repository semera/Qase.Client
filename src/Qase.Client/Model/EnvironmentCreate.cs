/*
 * Qase.io TestOps API v1
 *
 * Qase TestOps API v1 Specification.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@qase.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Qase.Client.Client.OpenAPIDateConverter;

namespace Qase.Client.Model
{
    /// <summary>
    /// EnvironmentCreate
    /// </summary>
    [DataContract(Name = "EnvironmentCreate")]
    public partial class EnvironmentCreate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnvironmentCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentCreate" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="description">description.</param>
        /// <param name="slug">slug (required).</param>
        /// <param name="host">host.</param>
        public EnvironmentCreate(string title = default(string), string description = default(string), string slug = default(string), string host = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for EnvironmentCreate and cannot be null");
            }
            this.Title = title;
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new ArgumentNullException("slug is a required property for EnvironmentCreate and cannot be null");
            }
            this.Slug = slug;
            this.Description = description;
            this.Host = host;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnvironmentCreate {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

    }

}