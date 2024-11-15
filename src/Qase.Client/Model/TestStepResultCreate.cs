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
    /// TestStepResultCreate
    /// </summary>
    [DataContract(Name = "TestStepResultCreate")]
    public partial class TestStepResultCreate
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Passed for value: passed
            /// </summary>
            [EnumMember(Value = "passed")]
            Passed = 1,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 2,

            /// <summary>
            /// Enum Blocked for value: blocked
            /// </summary>
            [EnumMember(Value = "blocked")]
            Blocked = 3
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestStepResultCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestStepResultCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestStepResultCreate" /> class.
        /// </summary>
        /// <param name="position">position.</param>
        /// <param name="status">status (required).</param>
        /// <param name="comment">comment.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="action">action.</param>
        /// <param name="expectedResult">expectedResult.</param>
        /// <param name="data">data.</param>
        /// <param name="steps">Nested steps results may be passed here. Use same structure for them..</param>
        public TestStepResultCreate(int position = default(int), StatusEnum status = default(StatusEnum), string comment = default(string), List<string> attachments = default(List<string>), string action = default(string), string expectedResult = default(string), string data = default(string), List<Object> steps = default(List<Object>))
        {
            this.Status = status;
            this.Position = position;
            this.Comment = comment;
            this.Attachments = attachments;
            this.Action = action;
            this.ExpectedResult = expectedResult;
            this.Data = data;
            this.Steps = steps;
        }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [Obsolete]
        public int Position { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedResult
        /// </summary>
        [DataMember(Name = "expected_result", EmitDefaultValue = true)]
        public string ExpectedResult { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Nested steps results may be passed here. Use same structure for them.
        /// </summary>
        /// <value>Nested steps results may be passed here. Use same structure for them.</value>
        [DataMember(Name = "steps", EmitDefaultValue = false)]
        public List<Object> Steps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestStepResultCreate {\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ExpectedResult: ").Append(ExpectedResult).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
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
