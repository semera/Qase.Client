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
    /// SystemField
    /// </summary>
    [DataContract(Name = "SystemField")]
    public partial class SystemField
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemField" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="slug">slug.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="entity">entity.</param>
        /// <param name="type">type.</param>
        /// <param name="options">options.</param>
        public SystemField(string title = default(string), string slug = default(string), string defaultValue = default(string), bool isRequired = default(bool), long entity = default(long), long type = default(long), List<SystemFieldOption> options = default(List<SystemFieldOption>))
        {
            this.Title = title;
            this.Slug = slug;
            this.DefaultValue = defaultValue;
            this.IsRequired = isRequired;
            this.Entity = entity;
            this.Type = type;
            this.Options = options;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name = "default_value", EmitDefaultValue = true)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name = "is_required", EmitDefaultValue = true)]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public long Entity { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public long Type { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public List<SystemFieldOption> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemField {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
