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
    /// Contains information about your team and its members
    /// </summary>
    [DataContract(Name = "TeamResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TeamResponse : IOpenApiTyped, IEquatable<TeamResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamResponse" /> class.
        /// </summary>
        /// <param name="name">The name of your Team.</param>
        /// <param name="accounts">accounts.</param>
        /// <param name="invitedAccounts">A list of all Accounts that have an outstanding invitation to join your Team. Note that this response is a subset of the response parameters found in &#x60;GET /account&#x60;..</param>
        public TeamResponse(string name = default(string), List<AccountResponse> accounts = default(List<AccountResponse>), List<AccountResponse> invitedAccounts = default(List<AccountResponse>))
        {
            
            this.Name = name;
            this.Accounts = accounts;
            this.InvitedAccounts = invitedAccounts;
        }

        /// <summary>
        /// The name of your Team
        /// </summary>
        /// <value>The name of your Team</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name = "accounts", EmitDefaultValue = true)]
        public List<AccountResponse> Accounts { get; set; }

        /// <summary>
        /// A list of all Accounts that have an outstanding invitation to join your Team. Note that this response is a subset of the response parameters found in &#x60;GET /account&#x60;.
        /// </summary>
        /// <value>A list of all Accounts that have an outstanding invitation to join your Team. Note that this response is a subset of the response parameters found in &#x60;GET /account&#x60;.</value>
        [DataMember(Name = "invited_accounts", EmitDefaultValue = true)]
        public List<AccountResponse> InvitedAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  InvitedAccounts: ").Append(InvitedAccounts).Append("\n");
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
            return this.Equals(input as TeamResponse);
        }

        /// <summary>
        /// Returns true if TeamResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.InvitedAccounts == input.InvitedAccounts ||
                    this.InvitedAccounts != null &&
                    input.InvitedAccounts != null &&
                    this.InvitedAccounts.SequenceEqual(input.InvitedAccounts)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
                }
                if (this.InvitedAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.InvitedAccounts.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "name",
                Property = "Name",
                Type = "string",
                Value = Name,
            });
            types.Add(new OpenApiType(){
                Name = "accounts",
                Property = "Accounts",
                Type = "List<AccountResponse>",
                Value = Accounts,
            });
            types.Add(new OpenApiType(){
                Name = "invited_accounts",
                Property = "InvitedAccounts",
                Type = "List<AccountResponse>",
                Value = InvitedAccounts,
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
