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
    /// Calls SignatureRequestSend in controller
    /// </summary>
    [DataContract(Name = "SignatureRequestCreateEmbeddedRequest")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SignatureRequestCreateEmbeddedRequest : IOpenApiTyped, IEquatable<SignatureRequestCreateEmbeddedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestCreateEmbeddedRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureRequestCreateEmbeddedRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestCreateEmbeddedRequest" /> class.
        /// </summary>
        /// <param name="file">Use &#x60;file[]&#x60; to indicate the uploaded file(s) to send for signature.  This endpoint requires either **file** or **file_url[]**, but not both..</param>
        /// <param name="fileUrl">Use &#x60;file_url[]&#x60; to have HelloSign download the file(s) to send for signature.  This endpoint requires either **file** or **file_url[]**, but not both..</param>
        /// <param name="allowDecline">Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;. (default to false).</param>
        /// <param name="allowReassign">Allows signers to reassign their signature requests to other signers if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.  **Note**: Only available for Premium plan. (default to false).</param>
        /// <param name="attachments">A list describing the attachments.</param>
        /// <param name="ccEmailAddresses">The email addresses that should be CCed..</param>
        /// <param name="clientId">Client id of the app you&#39;re using to create this embedded signature request. Used for security purposes. (required).</param>
        /// <param name="customFields">When used together with merge fields, &#x60;custom_fields&#x60; allows users to add pre-filled data to their signature requests.  Pre-filled data can be used with \&quot;send-once\&quot; signature requests by adding merge fields with &#x60;form_fields_per_document&#x60; or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with &#x60;custom_fields&#x60; together in one API call.  For using pre-filled on repeatable signature requests, merge fields are added to templates in the HelloSign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing &#x60;custom_fields&#x60; on subsequent signature requests referencing that template..</param>
        /// <param name="fieldOptions">fieldOptions.</param>
        /// <param name="formFieldGroups">Group information for fields defined in &#x60;form_fields_per_document&#x60;. String-indexed JSON array with &#x60;group_label&#x60; and &#x60;requirement&#x60; keys. &#x60;form_fields_per_document&#x60; must contain fields referencing a group defined in &#x60;form_field_groups&#x60;..</param>
        /// <param name="formFieldRules">Conditional Logic rules for fields defined in &#x60;form_fields_per_document&#x60;..</param>
        /// <param name="formFieldsPerDocument">The fields that should appear on the document, expressed as an array of objects.  **NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.  * Text Field use &#x60;SubFormFieldsPerDocumentText&#x60; * Dropdown Field use &#x60;SubFormFieldsPerDocumentDropdown&#x60; * Hyperlink Field use &#x60;SubFormFieldsPerDocumentHyperlink&#x60; * Checkbox Field use &#x60;SubFormFieldsPerDocumentCheckbox&#x60; * Radio Field use &#x60;SubFormFieldsPerDocumentRadio&#x60; * Signature Field use &#x60;SubFormFieldsPerDocumentSignature&#x60; * Date Signed Field use &#x60;SubFormFieldsPerDocumentDateSigned&#x60; * Initials Field use &#x60;SubFormFieldsPerDocumentInitials&#x60; * Text Merge Field use &#x60;SubFormFieldsPerDocumentTextMerge&#x60; * Checkbox Merge Field use &#x60;SubFormFieldsPerDocumentCheckboxMerge&#x60;.</param>
        /// <param name="hideTextTags">Enables automatic Text Tag removal when set to true.  **NOTE**: Removing text tags this way can cause unwanted clipping. We recommend leaving this setting on &#x60;false&#x60; and instead hiding your text tags using white text or a similar approach. See the [Text Tags Walkthrough](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) for more information. (default to false).</param>
        /// <param name="message">The custom message in the email that will be sent to the signers..</param>
        /// <param name="metadata">Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.  Each request can include up to 10 metadata keys, with key names up to 40 characters long and values up to 1000 characters long..</param>
        /// <param name="signers">Add Signers to your Signature Request. (required).</param>
        /// <param name="signingOptions">signingOptions.</param>
        /// <param name="subject">The subject in the email that will be sent to the signers..</param>
        /// <param name="testMode">Whether this is a test, the signature request will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. (default to false).</param>
        /// <param name="title">The title you want to assign to the SignatureRequest..</param>
        /// <param name="useTextTags">Send with a value of &#x60;true&#x60; if you wish to enable [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) parsing in your document. Defaults to disabled, or &#x60;false&#x60;. (default to false).</param>
        public SignatureRequestCreateEmbeddedRequest(List<System.IO.Stream> file = default(List<System.IO.Stream>), List<string> fileUrl = default(List<string>), bool allowDecline = false, bool allowReassign = false, List<SubAttachment> attachments = default(List<SubAttachment>), List<string> ccEmailAddresses = default(List<string>), string clientId = default(string), List<SubCustomField> customFields = default(List<SubCustomField>), SubFieldOptions fieldOptions = default(SubFieldOptions), List<SubFormFieldGroup> formFieldGroups = default(List<SubFormFieldGroup>), List<SubFormFieldRule> formFieldRules = default(List<SubFormFieldRule>), List<SubFormFieldsPerDocumentBase> formFieldsPerDocument = default(List<SubFormFieldsPerDocumentBase>), bool hideTextTags = false, string message = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), List<SubSignatureRequestSigner> signers = default(List<SubSignatureRequestSigner>), SubSigningOptions signingOptions = default(SubSigningOptions), string subject = default(string), bool testMode = false, string title = default(string), bool useTextTags = false)
        {
            
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new ArgumentNullException("clientId is a required property for SignatureRequestCreateEmbeddedRequest and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "signers" is required (not null)
            if (signers == null)
            {
                throw new ArgumentNullException("signers is a required property for SignatureRequestCreateEmbeddedRequest and cannot be null");
            }
            this.Signers = signers;
            this.File = file;
            this.FileUrl = fileUrl;
            this.AllowDecline = allowDecline;
            this.AllowReassign = allowReassign;
            this.Attachments = attachments;
            this.CcEmailAddresses = ccEmailAddresses;
            this.CustomFields = customFields;
            this.FieldOptions = fieldOptions;
            this.FormFieldGroups = formFieldGroups;
            this.FormFieldRules = formFieldRules;
            this.FormFieldsPerDocument = formFieldsPerDocument;
            this.HideTextTags = hideTextTags;
            this.Message = message;
            this.Metadata = metadata;
            this.SigningOptions = signingOptions;
            this.Subject = subject;
            this.TestMode = testMode;
            this.Title = title;
            this.UseTextTags = useTextTags;
        }

        /// <summary>
        /// Client id of the app you&#39;re using to create this embedded signature request. Used for security purposes.
        /// </summary>
        /// <value>Client id of the app you&#39;re using to create this embedded signature request. Used for security purposes.</value>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Add Signers to your Signature Request.
        /// </summary>
        /// <value>Add Signers to your Signature Request.</value>
        [DataMember(Name = "signers", IsRequired = true, EmitDefaultValue = true)]
        public List<SubSignatureRequestSigner> Signers { get; set; }

        /// <summary>
        /// Use &#x60;file[]&#x60; to indicate the uploaded file(s) to send for signature.  This endpoint requires either **file** or **file_url[]**, but not both.
        /// </summary>
        /// <value>Use &#x60;file[]&#x60; to indicate the uploaded file(s) to send for signature.  This endpoint requires either **file** or **file_url[]**, but not both.</value>
        [DataMember(Name = "file", EmitDefaultValue = true)]
        public List<System.IO.Stream> File { get; set; }

        /// <summary>
        /// Use &#x60;file_url[]&#x60; to have HelloSign download the file(s) to send for signature.  This endpoint requires either **file** or **file_url[]**, but not both.
        /// </summary>
        /// <value>Use &#x60;file_url[]&#x60; to have HelloSign download the file(s) to send for signature.  This endpoint requires either **file** or **file_url[]**, but not both.</value>
        [DataMember(Name = "file_url", EmitDefaultValue = true)]
        public List<string> FileUrl { get; set; }

        /// <summary>
        /// Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "allow_decline", EmitDefaultValue = true)]
        public bool AllowDecline { get; set; }

        /// <summary>
        /// Allows signers to reassign their signature requests to other signers if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.  **Note**: Only available for Premium plan.
        /// </summary>
        /// <value>Allows signers to reassign their signature requests to other signers if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.  **Note**: Only available for Premium plan.</value>
        [DataMember(Name = "allow_reassign", EmitDefaultValue = true)]
        public bool AllowReassign { get; set; }

        /// <summary>
        /// A list describing the attachments
        /// </summary>
        /// <value>A list describing the attachments</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<SubAttachment> Attachments { get; set; }

        /// <summary>
        /// The email addresses that should be CCed.
        /// </summary>
        /// <value>The email addresses that should be CCed.</value>
        [DataMember(Name = "cc_email_addresses", EmitDefaultValue = true)]
        public List<string> CcEmailAddresses { get; set; }

        /// <summary>
        /// When used together with merge fields, &#x60;custom_fields&#x60; allows users to add pre-filled data to their signature requests.  Pre-filled data can be used with \&quot;send-once\&quot; signature requests by adding merge fields with &#x60;form_fields_per_document&#x60; or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with &#x60;custom_fields&#x60; together in one API call.  For using pre-filled on repeatable signature requests, merge fields are added to templates in the HelloSign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing &#x60;custom_fields&#x60; on subsequent signature requests referencing that template.
        /// </summary>
        /// <value>When used together with merge fields, &#x60;custom_fields&#x60; allows users to add pre-filled data to their signature requests.  Pre-filled data can be used with \&quot;send-once\&quot; signature requests by adding merge fields with &#x60;form_fields_per_document&#x60; or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with &#x60;custom_fields&#x60; together in one API call.  For using pre-filled on repeatable signature requests, merge fields are added to templates in the HelloSign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing &#x60;custom_fields&#x60; on subsequent signature requests referencing that template.</value>
        [DataMember(Name = "custom_fields", EmitDefaultValue = true)]
        public List<SubCustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets FieldOptions
        /// </summary>
        [DataMember(Name = "field_options", EmitDefaultValue = true)]
        public SubFieldOptions FieldOptions { get; set; }

        /// <summary>
        /// Group information for fields defined in &#x60;form_fields_per_document&#x60;. String-indexed JSON array with &#x60;group_label&#x60; and &#x60;requirement&#x60; keys. &#x60;form_fields_per_document&#x60; must contain fields referencing a group defined in &#x60;form_field_groups&#x60;.
        /// </summary>
        /// <value>Group information for fields defined in &#x60;form_fields_per_document&#x60;. String-indexed JSON array with &#x60;group_label&#x60; and &#x60;requirement&#x60; keys. &#x60;form_fields_per_document&#x60; must contain fields referencing a group defined in &#x60;form_field_groups&#x60;.</value>
        [DataMember(Name = "form_field_groups", EmitDefaultValue = true)]
        public List<SubFormFieldGroup> FormFieldGroups { get; set; }

        /// <summary>
        /// Conditional Logic rules for fields defined in &#x60;form_fields_per_document&#x60;.
        /// </summary>
        /// <value>Conditional Logic rules for fields defined in &#x60;form_fields_per_document&#x60;.</value>
        [DataMember(Name = "form_field_rules", EmitDefaultValue = true)]
        public List<SubFormFieldRule> FormFieldRules { get; set; }

        /// <summary>
        /// The fields that should appear on the document, expressed as an array of objects.  **NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.  * Text Field use &#x60;SubFormFieldsPerDocumentText&#x60; * Dropdown Field use &#x60;SubFormFieldsPerDocumentDropdown&#x60; * Hyperlink Field use &#x60;SubFormFieldsPerDocumentHyperlink&#x60; * Checkbox Field use &#x60;SubFormFieldsPerDocumentCheckbox&#x60; * Radio Field use &#x60;SubFormFieldsPerDocumentRadio&#x60; * Signature Field use &#x60;SubFormFieldsPerDocumentSignature&#x60; * Date Signed Field use &#x60;SubFormFieldsPerDocumentDateSigned&#x60; * Initials Field use &#x60;SubFormFieldsPerDocumentInitials&#x60; * Text Merge Field use &#x60;SubFormFieldsPerDocumentTextMerge&#x60; * Checkbox Merge Field use &#x60;SubFormFieldsPerDocumentCheckboxMerge&#x60;
        /// </summary>
        /// <value>The fields that should appear on the document, expressed as an array of objects.  **NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.  * Text Field use &#x60;SubFormFieldsPerDocumentText&#x60; * Dropdown Field use &#x60;SubFormFieldsPerDocumentDropdown&#x60; * Hyperlink Field use &#x60;SubFormFieldsPerDocumentHyperlink&#x60; * Checkbox Field use &#x60;SubFormFieldsPerDocumentCheckbox&#x60; * Radio Field use &#x60;SubFormFieldsPerDocumentRadio&#x60; * Signature Field use &#x60;SubFormFieldsPerDocumentSignature&#x60; * Date Signed Field use &#x60;SubFormFieldsPerDocumentDateSigned&#x60; * Initials Field use &#x60;SubFormFieldsPerDocumentInitials&#x60; * Text Merge Field use &#x60;SubFormFieldsPerDocumentTextMerge&#x60; * Checkbox Merge Field use &#x60;SubFormFieldsPerDocumentCheckboxMerge&#x60;</value>
        [DataMember(Name = "form_fields_per_document", EmitDefaultValue = true)]
        public List<SubFormFieldsPerDocumentBase> FormFieldsPerDocument { get; set; }

        /// <summary>
        /// Enables automatic Text Tag removal when set to true.  **NOTE**: Removing text tags this way can cause unwanted clipping. We recommend leaving this setting on &#x60;false&#x60; and instead hiding your text tags using white text or a similar approach. See the [Text Tags Walkthrough](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) for more information.
        /// </summary>
        /// <value>Enables automatic Text Tag removal when set to true.  **NOTE**: Removing text tags this way can cause unwanted clipping. We recommend leaving this setting on &#x60;false&#x60; and instead hiding your text tags using white text or a similar approach. See the [Text Tags Walkthrough](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) for more information.</value>
        [DataMember(Name = "hide_text_tags", EmitDefaultValue = true)]
        public bool HideTextTags { get; set; }

        /// <summary>
        /// The custom message in the email that will be sent to the signers.
        /// </summary>
        /// <value>The custom message in the email that will be sent to the signers.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.  Each request can include up to 10 metadata keys, with key names up to 40 characters long and values up to 1000 characters long.
        /// </summary>
        /// <value>Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.  Each request can include up to 10 metadata keys, with key names up to 40 characters long and values up to 1000 characters long.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets SigningOptions
        /// </summary>
        [DataMember(Name = "signing_options", EmitDefaultValue = true)]
        public SubSigningOptions SigningOptions { get; set; }

        /// <summary>
        /// The subject in the email that will be sent to the signers.
        /// </summary>
        /// <value>The subject in the email that will be sent to the signers.</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Whether this is a test, the signature request will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>Whether this is a test, the signature request will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "test_mode", EmitDefaultValue = true)]
        public bool TestMode { get; set; }

        /// <summary>
        /// The title you want to assign to the SignatureRequest.
        /// </summary>
        /// <value>The title you want to assign to the SignatureRequest.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Send with a value of &#x60;true&#x60; if you wish to enable [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) parsing in your document. Defaults to disabled, or &#x60;false&#x60;.
        /// </summary>
        /// <value>Send with a value of &#x60;true&#x60; if you wish to enable [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) parsing in your document. Defaults to disabled, or &#x60;false&#x60;.</value>
        [DataMember(Name = "use_text_tags", EmitDefaultValue = true)]
        public bool UseTextTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureRequestCreateEmbeddedRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Signers: ").Append(Signers).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  AllowDecline: ").Append(AllowDecline).Append("\n");
            sb.Append("  AllowReassign: ").Append(AllowReassign).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  CcEmailAddresses: ").Append(CcEmailAddresses).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  FieldOptions: ").Append(FieldOptions).Append("\n");
            sb.Append("  FormFieldGroups: ").Append(FormFieldGroups).Append("\n");
            sb.Append("  FormFieldRules: ").Append(FormFieldRules).Append("\n");
            sb.Append("  FormFieldsPerDocument: ").Append(FormFieldsPerDocument).Append("\n");
            sb.Append("  HideTextTags: ").Append(HideTextTags).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SigningOptions: ").Append(SigningOptions).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UseTextTags: ").Append(UseTextTags).Append("\n");
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
            return this.Equals(input as SignatureRequestCreateEmbeddedRequest);
        }

        /// <summary>
        /// Returns true if SignatureRequestCreateEmbeddedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureRequestCreateEmbeddedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureRequestCreateEmbeddedRequest input)
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
                    this.Signers == input.Signers ||
                    this.Signers != null &&
                    input.Signers != null &&
                    this.Signers.SequenceEqual(input.Signers)
                ) && 
                (
                    this.File == input.File ||
                    this.File != null &&
                    input.File != null &&
                    this.File.SequenceEqual(input.File)
                ) && 
                (
                    this.FileUrl == input.FileUrl ||
                    this.FileUrl != null &&
                    input.FileUrl != null &&
                    this.FileUrl.SequenceEqual(input.FileUrl)
                ) && 
                (
                    this.AllowDecline == input.AllowDecline ||
                    this.AllowDecline.Equals(input.AllowDecline)
                ) && 
                (
                    this.AllowReassign == input.AllowReassign ||
                    this.AllowReassign.Equals(input.AllowReassign)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.CcEmailAddresses == input.CcEmailAddresses ||
                    this.CcEmailAddresses != null &&
                    input.CcEmailAddresses != null &&
                    this.CcEmailAddresses.SequenceEqual(input.CcEmailAddresses)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.FieldOptions == input.FieldOptions ||
                    (this.FieldOptions != null &&
                    this.FieldOptions.Equals(input.FieldOptions))
                ) && 
                (
                    this.FormFieldGroups == input.FormFieldGroups ||
                    this.FormFieldGroups != null &&
                    input.FormFieldGroups != null &&
                    this.FormFieldGroups.SequenceEqual(input.FormFieldGroups)
                ) && 
                (
                    this.FormFieldRules == input.FormFieldRules ||
                    this.FormFieldRules != null &&
                    input.FormFieldRules != null &&
                    this.FormFieldRules.SequenceEqual(input.FormFieldRules)
                ) && 
                (
                    this.FormFieldsPerDocument == input.FormFieldsPerDocument ||
                    this.FormFieldsPerDocument != null &&
                    input.FormFieldsPerDocument != null &&
                    this.FormFieldsPerDocument.SequenceEqual(input.FormFieldsPerDocument)
                ) && 
                (
                    this.HideTextTags == input.HideTextTags ||
                    this.HideTextTags.Equals(input.HideTextTags)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.SigningOptions == input.SigningOptions ||
                    (this.SigningOptions != null &&
                    this.SigningOptions.Equals(input.SigningOptions))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TestMode == input.TestMode ||
                    this.TestMode.Equals(input.TestMode)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.UseTextTags == input.UseTextTags ||
                    this.UseTextTags.Equals(input.UseTextTags)
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
                if (this.Signers != null)
                {
                    hashCode = (hashCode * 59) + this.Signers.GetHashCode();
                }
                if (this.File != null)
                {
                    hashCode = (hashCode * 59) + this.File.GetHashCode();
                }
                if (this.FileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowDecline.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowReassign.GetHashCode();
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.CcEmailAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.CcEmailAddresses.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.FieldOptions != null)
                {
                    hashCode = (hashCode * 59) + this.FieldOptions.GetHashCode();
                }
                if (this.FormFieldGroups != null)
                {
                    hashCode = (hashCode * 59) + this.FormFieldGroups.GetHashCode();
                }
                if (this.FormFieldRules != null)
                {
                    hashCode = (hashCode * 59) + this.FormFieldRules.GetHashCode();
                }
                if (this.FormFieldsPerDocument != null)
                {
                    hashCode = (hashCode * 59) + this.FormFieldsPerDocument.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HideTextTags.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.SigningOptions != null)
                {
                    hashCode = (hashCode * 59) + this.SigningOptions.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TestMode.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseTextTags.GetHashCode();
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
                Name = "signers",
                Property = "Signers",
                Type = "List<SubSignatureRequestSigner>",
                Value = Signers,
            });
            types.Add(new OpenApiType(){
                Name = "file",
                Property = "File",
                Type = "List<System.IO.Stream>",
                Value = File,
            });
            types.Add(new OpenApiType(){
                Name = "file_url",
                Property = "FileUrl",
                Type = "List<string>",
                Value = FileUrl,
            });
            types.Add(new OpenApiType(){
                Name = "allow_decline",
                Property = "AllowDecline",
                Type = "bool",
                Value = AllowDecline,
            });
            types.Add(new OpenApiType(){
                Name = "allow_reassign",
                Property = "AllowReassign",
                Type = "bool",
                Value = AllowReassign,
            });
            types.Add(new OpenApiType(){
                Name = "attachments",
                Property = "Attachments",
                Type = "List<SubAttachment>",
                Value = Attachments,
            });
            types.Add(new OpenApiType(){
                Name = "cc_email_addresses",
                Property = "CcEmailAddresses",
                Type = "List<string>",
                Value = CcEmailAddresses,
            });
            types.Add(new OpenApiType(){
                Name = "custom_fields",
                Property = "CustomFields",
                Type = "List<SubCustomField>",
                Value = CustomFields,
            });
            types.Add(new OpenApiType(){
                Name = "field_options",
                Property = "FieldOptions",
                Type = "SubFieldOptions",
                Value = FieldOptions,
            });
            types.Add(new OpenApiType(){
                Name = "form_field_groups",
                Property = "FormFieldGroups",
                Type = "List<SubFormFieldGroup>",
                Value = FormFieldGroups,
            });
            types.Add(new OpenApiType(){
                Name = "form_field_rules",
                Property = "FormFieldRules",
                Type = "List<SubFormFieldRule>",
                Value = FormFieldRules,
            });
            types.Add(new OpenApiType(){
                Name = "form_fields_per_document",
                Property = "FormFieldsPerDocument",
                Type = "List<SubFormFieldsPerDocumentBase>",
                Value = FormFieldsPerDocument,
            });
            types.Add(new OpenApiType(){
                Name = "hide_text_tags",
                Property = "HideTextTags",
                Type = "bool",
                Value = HideTextTags,
            });
            types.Add(new OpenApiType(){
                Name = "message",
                Property = "Message",
                Type = "string",
                Value = Message,
            });
            types.Add(new OpenApiType(){
                Name = "metadata",
                Property = "Metadata",
                Type = "Dictionary<string, Object>",
                Value = Metadata,
            });
            types.Add(new OpenApiType(){
                Name = "signing_options",
                Property = "SigningOptions",
                Type = "SubSigningOptions",
                Value = SigningOptions,
            });
            types.Add(new OpenApiType(){
                Name = "subject",
                Property = "Subject",
                Type = "string",
                Value = Subject,
            });
            types.Add(new OpenApiType(){
                Name = "test_mode",
                Property = "TestMode",
                Type = "bool",
                Value = TestMode,
            });
            types.Add(new OpenApiType(){
                Name = "title",
                Property = "Title",
                Type = "string",
                Value = Title,
            });
            types.Add(new OpenApiType(){
                Name = "use_text_tags",
                Property = "UseTextTags",
                Type = "bool",
                Value = UseTextTags,
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
            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 5000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 5000.", new [] { "Message" });
            }

            // Subject (string) maxLength
            if (this.Subject != null && this.Subject.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Subject, length must be less than 255.", new [] { "Subject" });
            }

            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 255.", new [] { "Title" });
            }

            yield break;
        }
    }

}
