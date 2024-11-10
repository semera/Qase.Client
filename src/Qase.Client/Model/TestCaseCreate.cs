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
    /// TestCaseCreate
    /// </summary>
    [DataContract(Name = "TestCaseCreate")]
    public partial class TestCaseCreate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestCaseCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseCreate" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="preconditions">preconditions.</param>
        /// <param name="postconditions">postconditions.</param>
        /// <param name="title">title (required).</param>
        /// <param name="severity">severity.</param>
        /// <param name="priority">priority.</param>
        /// <param name="behavior">behavior.</param>
        /// <param name="type">type.</param>
        /// <param name="layer">layer.</param>
        /// <param name="isFlaky">isFlaky.</param>
        /// <param name="authorId">authorId.</param>
        /// <param name="suiteId">suiteId.</param>
        /// <param name="milestoneId">milestoneId.</param>
        /// <param name="automation">automation.</param>
        /// <param name="status">status.</param>
        /// <param name="attachments">A list of Attachment hashes..</param>
        /// <param name="steps">steps.</param>
        /// <param name="tags">tags.</param>
        /// <param name="varParams">varParams.</param>
        /// <param name="customField">A map of custom fields values (id &#x3D;&gt; value).</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public TestCaseCreate(string description = default(string), string preconditions = default(string), string postconditions = default(string), string title = default(string), int severity = default(int), int priority = default(int), int behavior = default(int), int type = default(int), int layer = default(int), int isFlaky = default(int), int authorId = default(int), long suiteId = default(long), long milestoneId = default(long), int automation = default(int), int status = default(int), List<string> attachments = default(List<string>), List<TestStepCreate> steps = default(List<TestStepCreate>), List<string> tags = default(List<string>), Dictionary<string, List<string>> varParams = default(Dictionary<string, List<string>>), Dictionary<string, string> customField = default(Dictionary<string, string>), string createdAt = default(string), string updatedAt = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for TestCaseCreate and cannot be null");
            }
            this.Title = title;
            this.Description = description;
            this.Preconditions = preconditions;
            this.Postconditions = postconditions;
            this.Severity = severity;
            this.Priority = priority;
            this.Behavior = behavior;
            this.Type = type;
            this.Layer = layer;
            this.IsFlaky = isFlaky;
            this.AuthorId = authorId;
            this.SuiteId = suiteId;
            this.MilestoneId = milestoneId;
            this.Automation = automation;
            this.Status = status;
            this.Attachments = attachments;
            this.Steps = steps;
            this.Tags = tags;
            this.Params = varParams;
            this.CustomField = customField;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Preconditions
        /// </summary>
        [DataMember(Name = "preconditions", EmitDefaultValue = false)]
        public string Preconditions { get; set; }

        /// <summary>
        /// Gets or Sets Postconditions
        /// </summary>
        [DataMember(Name = "postconditions", EmitDefaultValue = false)]
        public string Postconditions { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", EmitDefaultValue = false)]
        public int Severity { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets Behavior
        /// </summary>
        [DataMember(Name = "behavior", EmitDefaultValue = false)]
        public int Behavior { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public int Type { get; set; }

        /// <summary>
        /// Gets or Sets Layer
        /// </summary>
        [DataMember(Name = "layer", EmitDefaultValue = false)]
        public int Layer { get; set; }

        /// <summary>
        /// Gets or Sets IsFlaky
        /// </summary>
        [DataMember(Name = "is_flaky", EmitDefaultValue = false)]
        public int IsFlaky { get; set; }

        /// <summary>
        /// Gets or Sets AuthorId
        /// </summary>
        [DataMember(Name = "author_id", EmitDefaultValue = false)]
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or Sets SuiteId
        /// </summary>
        [DataMember(Name = "suite_id", EmitDefaultValue = false)]
        public long SuiteId { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneId
        /// </summary>
        [DataMember(Name = "milestone_id", EmitDefaultValue = false)]
        public long MilestoneId { get; set; }

        /// <summary>
        /// Gets or Sets Automation
        /// </summary>
        [DataMember(Name = "automation", EmitDefaultValue = false)]
        public int Automation { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// A list of Attachment hashes.
        /// </summary>
        /// <value>A list of Attachment hashes.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", EmitDefaultValue = false)]
        public List<TestStepCreate> Steps { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name = "params", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Params { get; set; }

        /// <summary>
        /// A map of custom fields values (id &#x3D;&gt; value)
        /// </summary>
        /// <value>A map of custom fields values (id &#x3D;&gt; value)</value>
        [DataMember(Name = "custom_field", EmitDefaultValue = false)]
        public Dictionary<string, string> CustomField { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestCaseCreate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Preconditions: ").Append(Preconditions).Append("\n");
            sb.Append("  Postconditions: ").Append(Postconditions).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Behavior: ").Append(Behavior).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Layer: ").Append(Layer).Append("\n");
            sb.Append("  IsFlaky: ").Append(IsFlaky).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  SuiteId: ").Append(SuiteId).Append("\n");
            sb.Append("  MilestoneId: ").Append(MilestoneId).Append("\n");
            sb.Append("  Automation: ").Append(Automation).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
