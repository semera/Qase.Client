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
    /// Plan
    /// </summary>
    [DataContract(Name = "Plan")]
    public partial class Plan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="casesCount">casesCount.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="created">Deprecated, use the &#x60;created_at&#x60; property instead..</param>
        /// <param name="updated">Deprecated, use the &#x60;updated_at&#x60; property instead..</param>
        public Plan(long id = default(long), string title = default(string), string description = default(string), int casesCount = default(int), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string created = default(string), string updated = default(string))
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.CasesCount = casesCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Created = created;
            this.Updated = updated;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CasesCount
        /// </summary>
        [DataMember(Name = "cases_count", EmitDefaultValue = false)]
        public int CasesCount { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /*
        <example>2021-12-30T19:23:59Z</example>
        */
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /*
        <example>2021-12-30T19:23:59Z</example>
        */
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Deprecated, use the &#x60;created_at&#x60; property instead.
        /// </summary>
        /// <value>Deprecated, use the &#x60;created_at&#x60; property instead.</value>
        /*
        <example>2021-12-30 19:23:59</example>
        */
        [DataMember(Name = "created", EmitDefaultValue = false)]
        [Obsolete]
        public string Created { get; set; }

        /// <summary>
        /// Deprecated, use the &#x60;updated_at&#x60; property instead.
        /// </summary>
        /// <value>Deprecated, use the &#x60;updated_at&#x60; property instead.</value>
        /*
        <example>2021-12-30 19:23:59</example>
        */
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        [Obsolete]
        public string Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Plan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CasesCount: ").Append(CasesCount).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
