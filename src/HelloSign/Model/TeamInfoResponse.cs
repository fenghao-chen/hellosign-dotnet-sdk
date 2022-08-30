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
using OpenAPIDateConverter = HelloSign.Client.OpenAPIDateConverter;

namespace HelloSign.Model
{
    /// <summary>
    /// TeamInfoResponse
    /// </summary>
    [DataContract(Name = "TeamInfoResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TeamInfoResponse : IOpenApiTyped, IEquatable<TeamInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInfoResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamInfoResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInfoResponse" /> class.
        /// </summary>
        /// <param name="teamId">The id of a team.</param>
        /// <param name="teamParent">teamParent.</param>
        /// <param name="name">The name of a team.</param>
        /// <param name="numMembers">Number of members within a team.</param>
        /// <param name="numSubTeams">Number of sub teams within a team.</param>
        public TeamInfoResponse(string teamId = default(string), TeamParentResponse teamParent = default(TeamParentResponse), string name = default(string), int numMembers = default(int), int numSubTeams = default(int))
        {
            
            this.TeamId = teamId;
            this.TeamParent = teamParent;
            this.Name = name;
            this.NumMembers = numMembers;
            this.NumSubTeams = numSubTeams;
        }

        /// <summary>
        /// The id of a team
        /// </summary>
        /// <value>The id of a team</value>
        [DataMember(Name = "team_id", EmitDefaultValue = true)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets TeamParent
        /// </summary>
        [DataMember(Name = "team_parent", EmitDefaultValue = true)]
        public TeamParentResponse TeamParent { get; set; }

        /// <summary>
        /// The name of a team
        /// </summary>
        /// <value>The name of a team</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Number of members within a team
        /// </summary>
        /// <value>Number of members within a team</value>
        [DataMember(Name = "num_members", EmitDefaultValue = true)]
        public int NumMembers { get; set; }

        /// <summary>
        /// Number of sub teams within a team
        /// </summary>
        /// <value>Number of sub teams within a team</value>
        [DataMember(Name = "num_sub_teams", EmitDefaultValue = true)]
        public int NumSubTeams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamInfoResponse {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  TeamParent: ").Append(TeamParent).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumMembers: ").Append(NumMembers).Append("\n");
            sb.Append("  NumSubTeams: ").Append(NumSubTeams).Append("\n");
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
            return this.Equals(input as TeamInfoResponse);
        }

        /// <summary>
        /// Returns true if TeamInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamInfoResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.TeamParent == input.TeamParent ||
                    (this.TeamParent != null &&
                    this.TeamParent.Equals(input.TeamParent))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumMembers == input.NumMembers ||
                    this.NumMembers.Equals(input.NumMembers)
                ) && 
                (
                    this.NumSubTeams == input.NumSubTeams ||
                    this.NumSubTeams.Equals(input.NumSubTeams)
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
                if (this.TeamId != null)
                {
                    hashCode = (hashCode * 59) + this.TeamId.GetHashCode();
                }
                if (this.TeamParent != null)
                {
                    hashCode = (hashCode * 59) + this.TeamParent.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NumMembers.GetHashCode();
                hashCode = (hashCode * 59) + this.NumSubTeams.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "team_id",
                Property = "TeamId",
                Type = "string",
                Value = TeamId,
            });
            types.Add(new OpenApiType(){
                Name = "team_parent",
                Property = "TeamParent",
                Type = "TeamParentResponse",
                Value = TeamParent,
            });
            types.Add(new OpenApiType(){
                Name = "name",
                Property = "Name",
                Type = "string",
                Value = Name,
            });
            types.Add(new OpenApiType(){
                Name = "num_members",
                Property = "NumMembers",
                Type = "int",
                Value = NumMembers,
            });
            types.Add(new OpenApiType(){
                Name = "num_sub_teams",
                Property = "NumSubTeams",
                Type = "int",
                Value = NumSubTeams,
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