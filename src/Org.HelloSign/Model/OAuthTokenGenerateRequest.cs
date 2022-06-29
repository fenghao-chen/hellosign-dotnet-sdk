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
    /// OAuthTokenGenerateRequest
    /// </summary>
    [DataContract(Name = "OAuthTokenGenerateRequest")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class OAuthTokenGenerateRequest : IOpenApiTyped, IEquatable<OAuthTokenGenerateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenGenerateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthTokenGenerateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenGenerateRequest" /> class.
        /// </summary>
        /// <param name="clientId">The client id of the app requesting authorization. (required).</param>
        /// <param name="clientSecret">The secret token of your app. (required).</param>
        /// <param name="code">The code passed to your callback when the user granted access. (required).</param>
        /// <param name="grantType">When generating a new token use &#x60;authorization_code&#x60;. (required) (default to &quot;authorization_code&quot;).</param>
        /// <param name="state">Same as the state you specified earlier. (required).</param>
        public OAuthTokenGenerateRequest(string clientId = default(string), string clientSecret = default(string), string code = default(string), string grantType = "authorization_code", string state = default(string))
        {
            
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new ArgumentNullException("clientId is a required property for OAuthTokenGenerateRequest and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "clientSecret" is required (not null)
            if (clientSecret == null)
            {
                throw new ArgumentNullException("clientSecret is a required property for OAuthTokenGenerateRequest and cannot be null");
            }
            this.ClientSecret = clientSecret;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for OAuthTokenGenerateRequest and cannot be null");
            }
            this.Code = code;
            // to ensure "grantType" is required (not null)
            if (grantType == null)
            {
                throw new ArgumentNullException("grantType is a required property for OAuthTokenGenerateRequest and cannot be null");
            }
            this.GrantType = grantType;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for OAuthTokenGenerateRequest and cannot be null");
            }
            this.State = state;
        }

        /// <summary>
        /// The client id of the app requesting authorization.
        /// </summary>
        /// <value>The client id of the app requesting authorization.</value>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// The secret token of your app.
        /// </summary>
        /// <value>The secret token of your app.</value>
        [DataMember(Name = "client_secret", IsRequired = true, EmitDefaultValue = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The code passed to your callback when the user granted access.
        /// </summary>
        /// <value>The code passed to your callback when the user granted access.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// When generating a new token use &#x60;authorization_code&#x60;.
        /// </summary>
        /// <value>When generating a new token use &#x60;authorization_code&#x60;.</value>
        [DataMember(Name = "grant_type", IsRequired = true, EmitDefaultValue = true)]
        public string GrantType { get; set; }

        /// <summary>
        /// Same as the state you specified earlier.
        /// </summary>
        /// <value>Same as the state you specified earlier.</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthTokenGenerateRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as OAuthTokenGenerateRequest);
        }

        /// <summary>
        /// Returns true if OAuthTokenGenerateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthTokenGenerateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthTokenGenerateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.GrantType == input.GrantType ||
                    (this.GrantType != null &&
                    this.GrantType.Equals(input.GrantType))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.GrantType != null)
                {
                    hashCode = (hashCode * 59) + this.GrantType.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "client_id",
                Property = "ClientId",
                Type = "string",
                Value = ClientId,
            });
            types.Add(new OpenApiType(){
                Name = "client_secret",
                Property = "ClientSecret",
                Type = "string",
                Value = ClientSecret,
            });
            types.Add(new OpenApiType(){
                Name = "code",
                Property = "Code",
                Type = "string",
                Value = Code,
            });
            types.Add(new OpenApiType(){
                Name = "grant_type",
                Property = "GrantType",
                Type = "string",
                Value = GrantType,
            });
            types.Add(new OpenApiType(){
                Name = "state",
                Property = "State",
                Type = "string",
                Value = State,
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
