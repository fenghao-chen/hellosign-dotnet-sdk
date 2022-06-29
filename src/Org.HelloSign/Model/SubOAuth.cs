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
    /// OAuth related parameters.
    /// </summary>
    [DataContract(Name = "SubOAuth")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SubOAuth : IOpenApiTyped, IEquatable<SubOAuth>, IValidatableObject
    {
        /// <summary>
        /// Defines Scopes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopesEnum
        {
            /// <summary>
            /// Enum RequestSignature for value: request_signature
            /// </summary>
            [EnumMember(Value = "request_signature")]
            RequestSignature = 1,

            /// <summary>
            /// Enum BasicAccountInfo for value: basic_account_info
            /// </summary>
            [EnumMember(Value = "basic_account_info")]
            BasicAccountInfo = 2,

            /// <summary>
            /// Enum AccountAccess for value: account_access
            /// </summary>
            [EnumMember(Value = "account_access")]
            AccountAccess = 3,

            /// <summary>
            /// Enum SignatureRequestAccess for value: signature_request_access
            /// </summary>
            [EnumMember(Value = "signature_request_access")]
            SignatureRequestAccess = 4,

            /// <summary>
            /// Enum TemplateAccess for value: template_access
            /// </summary>
            [EnumMember(Value = "template_access")]
            TemplateAccess = 5,

            /// <summary>
            /// Enum TeamAccess for value: team_access
            /// </summary>
            [EnumMember(Value = "team_access")]
            TeamAccess = 6,

            /// <summary>
            /// Enum ApiAppAccess for value: api_app_access
            /// </summary>
            [EnumMember(Value = "api_app_access")]
            ApiAppAccess = 7,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 8

        }



        /// <summary>
        /// A list of [OAuth scopes](/api/reference/tag/OAuth) to be granted to the app. (Required if &#x60;oauth[callback_url]&#x60; is provided).
        /// </summary>
        /// <value>A list of [OAuth scopes](/api/reference/tag/OAuth) to be granted to the app. (Required if &#x60;oauth[callback_url]&#x60; is provided).</value>
        [DataMember(Name = "scopes", EmitDefaultValue = true)]
        public List<ScopesEnum> Scopes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubOAuth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubOAuth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubOAuth" /> class.
        /// </summary>
        /// <param name="callbackUrl">The callback URL to be used for OAuth flows. (Required if &#x60;oauth[scopes]&#x60; is provided).</param>
        /// <param name="scopes">A list of [OAuth scopes](/api/reference/tag/OAuth) to be granted to the app. (Required if &#x60;oauth[callback_url]&#x60; is provided)..</param>
        public SubOAuth(string callbackUrl = default(string), List<ScopesEnum> scopes = default(List<ScopesEnum>))
        {
            
            this.CallbackUrl = callbackUrl;
            this.Scopes = scopes;
        }

        /// <summary>
        /// The callback URL to be used for OAuth flows. (Required if &#x60;oauth[scopes]&#x60; is provided)
        /// </summary>
        /// <value>The callback URL to be used for OAuth flows. (Required if &#x60;oauth[scopes]&#x60; is provided)</value>
        [DataMember(Name = "callback_url", EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubOAuth {\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
            return this.Equals(input as SubOAuth);
        }

        /// <summary>
        /// Returns true if SubOAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of SubOAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubOAuth input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    this.Scopes.SequenceEqual(input.Scopes)
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
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Scopes.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "callback_url",
                Property = "CallbackUrl",
                Type = "string",
                Value = CallbackUrl,
            });
            types.Add(new OpenApiType(){
                Name = "scopes",
                Property = "Scopes",
                Type = "List<string>",
                Value = Scopes,
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