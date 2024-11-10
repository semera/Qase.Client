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
    /// ResultCreate
    /// </summary>
    [DataContract(Name = "ResultCreate")]
    public partial class ResultCreate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResultCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultCreate" /> class.
        /// </summary>
        /// <param name="caseId">caseId.</param>
        /// <param name="varCase">varCase.</param>
        /// <param name="status">Can have the following values &#x60;passed&#x60;, &#x60;failed&#x60;, &#x60;blocked&#x60;, &#x60;skipped&#x60;, &#x60;invalid&#x60; + custom statuses (required).</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="time">time.</param>
        /// <param name="timeMs">timeMs.</param>
        /// <param name="defect">defect.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="stacktrace">stacktrace.</param>
        /// <param name="comment">comment.</param>
        /// <param name="param">A map of parameters (name &#x3D;&gt; value).</param>
        /// <param name="paramGroups">List parameter groups by name only. Add their values in the &#39;param&#39; field.</param>
        /// <param name="steps">steps.</param>
        /// <param name="authorId">authorId.</param>
        public ResultCreate(long caseId = default(long), ResultCreateCase varCase = default(ResultCreateCase), string status = default(string), int? startTime = default(int?), long? time = default(long?), long? timeMs = default(long?), bool? defect = default(bool?), List<string> attachments = default(List<string>), string stacktrace = default(string), string comment = default(string), Dictionary<string, string> param = default(Dictionary<string, string>), List<List<string>> paramGroups = default(List<List<string>>), List<TestStepResultCreate> steps = default(List<TestStepResultCreate>), long? authorId = default(long?))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for ResultCreate and cannot be null");
            }
            this.Status = status;
            this.CaseId = caseId;
            this.Case = varCase;
            this.StartTime = startTime;
            this.Time = time;
            this.TimeMs = timeMs;
            this.Defect = defect;
            this.Attachments = attachments;
            this.Stacktrace = stacktrace;
            this.Comment = comment;
            this.Param = param;
            this.ParamGroups = paramGroups;
            this.Steps = steps;
            this.AuthorId = authorId;
        }

        /// <summary>
        /// Gets or Sets CaseId
        /// </summary>
        [DataMember(Name = "case_id", EmitDefaultValue = false)]
        public long CaseId { get; set; }

        /// <summary>
        /// Gets or Sets Case
        /// </summary>
        [DataMember(Name = "case", EmitDefaultValue = false)]
        public ResultCreateCase Case { get; set; }

        /// <summary>
        /// Can have the following values &#x60;passed&#x60;, &#x60;failed&#x60;, &#x60;blocked&#x60;, &#x60;skipped&#x60;, &#x60;invalid&#x60; + custom statuses
        /// </summary>
        /// <value>Can have the following values &#x60;passed&#x60;, &#x60;failed&#x60;, &#x60;blocked&#x60;, &#x60;skipped&#x60;, &#x60;invalid&#x60; + custom statuses</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "start_time", EmitDefaultValue = true)]
        public int? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = true)]
        public long? Time { get; set; }

        /// <summary>
        /// Gets or Sets TimeMs
        /// </summary>
        [DataMember(Name = "time_ms", EmitDefaultValue = true)]
        public long? TimeMs { get; set; }

        /// <summary>
        /// Gets or Sets Defect
        /// </summary>
        [DataMember(Name = "defect", EmitDefaultValue = true)]
        public bool? Defect { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Stacktrace
        /// </summary>
        [DataMember(Name = "stacktrace", EmitDefaultValue = true)]
        public string Stacktrace { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// A map of parameters (name &#x3D;&gt; value)
        /// </summary>
        /// <value>A map of parameters (name &#x3D;&gt; value)</value>
        [DataMember(Name = "param", EmitDefaultValue = true)]
        public Dictionary<string, string> Param { get; set; }

        /// <summary>
        /// List parameter groups by name only. Add their values in the &#39;param&#39; field
        /// </summary>
        /// <value>List parameter groups by name only. Add their values in the &#39;param&#39; field</value>
        [DataMember(Name = "param_groups", EmitDefaultValue = true)]
        public List<List<string>> ParamGroups { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", EmitDefaultValue = true)]
        public List<TestStepResultCreate> Steps { get; set; }

        /// <summary>
        /// Gets or Sets AuthorId
        /// </summary>
        [DataMember(Name = "author_id", EmitDefaultValue = true)]
        public long? AuthorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResultCreate {\n");
            sb.Append("  CaseId: ").Append(CaseId).Append("\n");
            sb.Append("  Case: ").Append(Case).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  TimeMs: ").Append(TimeMs).Append("\n");
            sb.Append("  Defect: ").Append(Defect).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Stacktrace: ").Append(Stacktrace).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Param: ").Append(Param).Append("\n");
            sb.Append("  ParamGroups: ").Append(ParamGroups).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
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
