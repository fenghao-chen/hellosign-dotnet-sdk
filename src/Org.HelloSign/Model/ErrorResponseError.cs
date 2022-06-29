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
    /// Contains information about an error that occurred.
    /// </summary>
    [DataContract(Name = "ErrorResponseError")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class ErrorResponseError : IOpenApiTyped, IEquatable<ErrorResponseError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorResponseError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        /// <param name="errorMsg">Message describing an error. (required).</param>
        /// <param name="errorPath">Path at which an error occurred..</param>
        /// <param name="errorName">Name of the error. (required).</param>
        public ErrorResponseError(string errorMsg = default(string), string errorPath = default(string), string errorName = default(string))
        {
            
            // to ensure "errorMsg" is required (not null)
            if (errorMsg == null)
            {
                throw new ArgumentNullException("errorMsg is a required property for ErrorResponseError and cannot be null");
            }
            this.ErrorMsg = errorMsg;
            // to ensure "errorName" is required (not null)
            if (errorName == null)
            {
                throw new ArgumentNullException("errorName is a required property for ErrorResponseError and cannot be null");
            }
            this.ErrorName = errorName;
            this.ErrorPath = errorPath;
        }

        /// <summary>
        /// Message describing an error.
        /// </summary>
        /// <value>Message describing an error.</value>
        [DataMember(Name = "error_msg", IsRequired = true, EmitDefaultValue = true)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Name of the error.
        /// </summary>
        /// <value>Name of the error.</value>
        [DataMember(Name = "error_name", IsRequired = true, EmitDefaultValue = true)]
        public string ErrorName { get; set; }

        /// <summary>
        /// Path at which an error occurred.
        /// </summary>
        /// <value>Path at which an error occurred.</value>
        [DataMember(Name = "error_path", EmitDefaultValue = true)]
        public string ErrorPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorResponseError {\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  ErrorName: ").Append(ErrorName).Append("\n");
            sb.Append("  ErrorPath: ").Append(ErrorPath).Append("\n");
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
            return this.Equals(input as ErrorResponseError);
        }

        /// <summary>
        /// Returns true if ErrorResponseError instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorResponseError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorResponseError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
                ) && 
                (
                    this.ErrorName == input.ErrorName ||
                    (this.ErrorName != null &&
                    this.ErrorName.Equals(input.ErrorName))
                ) && 
                (
                    this.ErrorPath == input.ErrorPath ||
                    (this.ErrorPath != null &&
                    this.ErrorPath.Equals(input.ErrorPath))
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
                if (this.ErrorMsg != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMsg.GetHashCode();
                }
                if (this.ErrorName != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorName.GetHashCode();
                }
                if (this.ErrorPath != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorPath.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "error_msg",
                Property = "ErrorMsg",
                Type = "string",
                Value = ErrorMsg,
            });
            types.Add(new OpenApiType(){
                Name = "error_name",
                Property = "ErrorName",
                Type = "string",
                Value = ErrorName,
            });
            types.Add(new OpenApiType(){
                Name = "error_path",
                Property = "ErrorPath",
                Type = "string",
                Value = ErrorPath,
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
