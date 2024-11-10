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
    /// SharedStepContent
    /// </summary>
    [DataContract(Name = "SharedStepContent")]
    public partial class SharedStepContent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepContent" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="hash">hash.</param>
        /// <param name="action">action.</param>
        /// <param name="expectedResult">expectedResult.</param>
        /// <param name="attachments">attachments.</param>
        public SharedStepContent(string data = default(string), string hash = default(string), string action = default(string), string expectedResult = default(string), List<AttachmentHash> attachments = default(List<AttachmentHash>))
        {
            this.Data = data;
            this.Hash = hash;
            this.Action = action;
            this.ExpectedResult = expectedResult;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        [Obsolete]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedResult
        /// </summary>
        [DataMember(Name = "expected_result", EmitDefaultValue = false)]
        public string ExpectedResult { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<AttachmentHash> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharedStepContent {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ExpectedResult: ").Append(ExpectedResult).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
