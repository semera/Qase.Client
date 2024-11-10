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
    /// AuthorListResponseAllOfResult
    /// </summary>
    [DataContract(Name = "AuthorListResponse_allOf_result")]
    public partial class AuthorListResponseAllOfResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorListResponseAllOfResult" /> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="filtered">filtered.</param>
        /// <param name="count">count.</param>
        /// <param name="entities">entities.</param>
        public AuthorListResponseAllOfResult(int total = default(int), int filtered = default(int), int count = default(int), List<Author> entities = default(List<Author>))
        {
            this.Total = total;
            this.Filtered = filtered;
            this.Count = count;
            this.Entities = entities;
        }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Filtered
        /// </summary>
        [DataMember(Name = "filtered", EmitDefaultValue = false)]
        public int Filtered { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name = "entities", EmitDefaultValue = false)]
        public List<Author> Entities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorListResponseAllOfResult {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Filtered: ").Append(Filtered).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
