/*
 * HelloSign API
 *
 * HelloSign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.HelloSign.Client.OpenAPIDateConverter;

namespace Org.HelloSign.Model
{
    /// <summary>
    /// Contains information about the report request.
    /// </summary>
    [DataContract(Name = "ReportResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class ReportResponse : IOpenApiTyped, IEquatable<ReportResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines ReportType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportTypeEnum
        {
            /// <summary>
            /// Enum UserActivity for value: user_activity
            /// </summary>
            [EnumMember(Value = "user_activity")]
            UserActivity = 1,

            /// <summary>
            /// Enum DocumentStatus for value: document_status
            /// </summary>
            [EnumMember(Value = "document_status")]
            DocumentStatus = 2

        }



        /// <summary>
        /// The type(s) of the report you are requesting. Allowed values are \&quot;user_activity\&quot; and \&quot;document_status\&quot;. User activity reports contain list of all users and their activity during the specified date range. Document status report contain a list of signature requests created in the specified time range (and their status).
        /// </summary>
        /// <value>The type(s) of the report you are requesting. Allowed values are \&quot;user_activity\&quot; and \&quot;document_status\&quot;. User activity reports contain list of all users and their activity during the specified date range. Document status report contain a list of signature requests created in the specified time range (and their status).</value>
        [DataMember(Name = "report_type", EmitDefaultValue = true)]
        public List<ReportTypeEnum> ReportType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportResponse" /> class.
        /// </summary>
        /// <param name="success">A message indicating the requested operation&#39;s success.</param>
        /// <param name="startDate">The (inclusive) start date for the report data in MM/DD/YYYY format..</param>
        /// <param name="endDate">The (inclusive) end date for the report data in MM/DD/YYYY format..</param>
        /// <param name="reportType">The type(s) of the report you are requesting. Allowed values are \&quot;user_activity\&quot; and \&quot;document_status\&quot;. User activity reports contain list of all users and their activity during the specified date range. Document status report contain a list of signature requests created in the specified time range (and their status)..</param>
        public ReportResponse(string success = default(string), string startDate = default(string), string endDate = default(string), List<ReportTypeEnum> reportType = default(List<ReportTypeEnum>))
        {
            
            this.Success = success;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ReportType = reportType;
        }

        /// <summary>
        /// A message indicating the requested operation&#39;s success
        /// </summary>
        /// <value>A message indicating the requested operation&#39;s success</value>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public string Success { get; set; }

        /// <summary>
        /// The (inclusive) start date for the report data in MM/DD/YYYY format.
        /// </summary>
        /// <value>The (inclusive) start date for the report data in MM/DD/YYYY format.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        public string StartDate { get; set; }

        /// <summary>
        /// The (inclusive) end date for the report data in MM/DD/YYYY format.
        /// </summary>
        /// <value>The (inclusive) end date for the report data in MM/DD/YYYY format.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReportResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
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

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReportResponse);
        }

        /// <summary>
        /// Returns true if ReportResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ReportType == input.ReportType ||
                    this.ReportType.SequenceEqual(input.ReportType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Success != null)
                {
                    hashCode = (hashCode * 59) + this.Success.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReportType.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "success",
                Property = "Success",
                Type = "string",
                Value = Success,
            });
            types.Add(new OpenApiType(){
                Name = "start_date",
                Property = "StartDate",
                Type = "string",
                Value = StartDate,
            });
            types.Add(new OpenApiType(){
                Name = "end_date",
                Property = "EndDate",
                Type = "string",
                Value = EndDate,
            });
            types.Add(new OpenApiType(){
                Name = "report_type",
                Property = "ReportType",
                Type = "List<string>",
                Value = ReportType,
            });

            return types;
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
