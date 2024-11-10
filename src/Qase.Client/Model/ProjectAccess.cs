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
    /// ProjectAccess
    /// </summary>
    [DataContract(Name = "ProjectAccess")]
    public partial class ProjectAccess
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAccess" /> class.
        /// </summary>
        /// <param name="memberId">Team member id title..</param>
        public ProjectAccess(long memberId = default(long))
        {
            this.MemberId = memberId;
        }

        /// <summary>
        /// Team member id title.
        /// </summary>
        /// <value>Team member id title.</value>
        [DataMember(Name = "member_id", EmitDefaultValue = false)]
        public long MemberId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectAccess {\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
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