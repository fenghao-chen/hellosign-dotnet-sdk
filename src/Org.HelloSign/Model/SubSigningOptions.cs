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
    /// This allows the requester to specify the types allowed for creating a signature.  **Note**: If &#x60;signing_options&#x60; are not defined in the request, the allowed types will default to those specified in the account settings.
    /// </summary>
    [DataContract(Name = "SubSigningOptions")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SubSigningOptions : IOpenApiTyped, IEquatable<SubSigningOptions>, IValidatableObject
    {
        /// <summary>
        /// The default type shown (limited to the listed types)
        /// </summary>
        /// <value>The default type shown (limited to the listed types)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DefaultTypeEnum
        {
            /// <summary>
            /// Enum Draw for value: draw
            /// </summary>
            [EnumMember(Value = "draw")]
            Draw = 1,

            /// <summary>
            /// Enum Phone for value: phone
            /// </summary>
            [EnumMember(Value = "phone")]
            Phone = 2,

            /// <summary>
            /// Enum Type for value: type
            /// </summary>
            [EnumMember(Value = "type")]
            Type = 3,

            /// <summary>
            /// Enum Upload for value: upload
            /// </summary>
            [EnumMember(Value = "upload")]
            Upload = 4

        }


        /// <summary>
        /// The default type shown (limited to the listed types)
        /// </summary>
        /// <value>The default type shown (limited to the listed types)</value>
        [DataMember(Name = "default_type", IsRequired = true, EmitDefaultValue = true)]
        public DefaultTypeEnum DefaultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubSigningOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubSigningOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubSigningOptions" /> class.
        /// </summary>
        /// <param name="defaultType">The default type shown (limited to the listed types) (required).</param>
        /// <param name="draw">Allows drawing the signature (default to false).</param>
        /// <param name="phone">Allows using a smartphone to email the signature (default to false).</param>
        /// <param name="type">Allows typing the signature (default to false).</param>
        /// <param name="upload">Allows uploading the signature (default to false).</param>
        public SubSigningOptions(DefaultTypeEnum defaultType = default(DefaultTypeEnum), bool draw = false, bool phone = false, bool type = false, bool upload = false)
        {
            
            this.DefaultType = defaultType;
            this.Draw = draw;
            this.Phone = phone;
            this.Type = type;
            this.Upload = upload;
        }

        /// <summary>
        /// Allows drawing the signature
        /// </summary>
        /// <value>Allows drawing the signature</value>
        [DataMember(Name = "draw", EmitDefaultValue = true)]
        public bool Draw { get; set; }

        /// <summary>
        /// Allows using a smartphone to email the signature
        /// </summary>
        /// <value>Allows using a smartphone to email the signature</value>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public bool Phone { get; set; }

        /// <summary>
        /// Allows typing the signature
        /// </summary>
        /// <value>Allows typing the signature</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public bool Type { get; set; }

        /// <summary>
        /// Allows uploading the signature
        /// </summary>
        /// <value>Allows uploading the signature</value>
        [DataMember(Name = "upload", EmitDefaultValue = true)]
        public bool Upload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubSigningOptions {\n");
            sb.Append("  DefaultType: ").Append(DefaultType).Append("\n");
            sb.Append("  Draw: ").Append(Draw).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Upload: ").Append(Upload).Append("\n");
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
            return this.Equals(input as SubSigningOptions);
        }

        /// <summary>
        /// Returns true if SubSigningOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SubSigningOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubSigningOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DefaultType == input.DefaultType ||
                    this.DefaultType.Equals(input.DefaultType)
                ) && 
                (
                    this.Draw == input.Draw ||
                    this.Draw.Equals(input.Draw)
                ) && 
                (
                    this.Phone == input.Phone ||
                    this.Phone.Equals(input.Phone)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Upload == input.Upload ||
                    this.Upload.Equals(input.Upload)
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
                hashCode = (hashCode * 59) + this.DefaultType.GetHashCode();
                hashCode = (hashCode * 59) + this.Draw.GetHashCode();
                hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Upload.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "default_type",
                Property = "DefaultType",
                Type = "string",
                Value = DefaultType,
            });
            types.Add(new OpenApiType(){
                Name = "draw",
                Property = "Draw",
                Type = "bool",
                Value = Draw,
            });
            types.Add(new OpenApiType(){
                Name = "phone",
                Property = "Phone",
                Type = "bool",
                Value = Phone,
            });
            types.Add(new OpenApiType(){
                Name = "type",
                Property = "Type",
                Type = "bool",
                Value = Type,
            });
            types.Add(new OpenApiType(){
                Name = "upload",
                Property = "Upload",
                Type = "bool",
                Value = Upload,
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
