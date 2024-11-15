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
    /// ProjectCounts
    /// </summary>
    [DataContract(Name = "Project_counts")]
    public partial class ProjectCounts
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCounts" /> class.
        /// </summary>
        /// <param name="cases">cases.</param>
        /// <param name="suites">suites.</param>
        /// <param name="milestones">milestones.</param>
        /// <param name="runs">runs.</param>
        /// <param name="defects">defects.</param>
        public ProjectCounts(int cases = default(int), int suites = default(int), int milestones = default(int), ProjectCountsRuns runs = default(ProjectCountsRuns), ProjectCountsDefects defects = default(ProjectCountsDefects))
        {
            this.Cases = cases;
            this.Suites = suites;
            this.Milestones = milestones;
            this.Runs = runs;
            this.Defects = defects;
        }

        /// <summary>
        /// Gets or Sets Cases
        /// </summary>
        [DataMember(Name = "cases", EmitDefaultValue = false)]
        public int Cases { get; set; }

        /// <summary>
        /// Gets or Sets Suites
        /// </summary>
        [DataMember(Name = "suites", EmitDefaultValue = false)]
        public int Suites { get; set; }

        /// <summary>
        /// Gets or Sets Milestones
        /// </summary>
        [DataMember(Name = "milestones", EmitDefaultValue = false)]
        public int Milestones { get; set; }

        /// <summary>
        /// Gets or Sets Runs
        /// </summary>
        [DataMember(Name = "runs", EmitDefaultValue = false)]
        public ProjectCountsRuns Runs { get; set; }

        /// <summary>
        /// Gets or Sets Defects
        /// </summary>
        [DataMember(Name = "defects", EmitDefaultValue = false)]
        public ProjectCountsDefects Defects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectCounts {\n");
            sb.Append("  Cases: ").Append(Cases).Append("\n");
            sb.Append("  Suites: ").Append(Suites).Append("\n");
            sb.Append("  Milestones: ").Append(Milestones).Append("\n");
            sb.Append("  Runs: ").Append(Runs).Append("\n");
            sb.Append("  Defects: ").Append(Defects).Append("\n");
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
