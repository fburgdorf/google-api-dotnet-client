// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.41.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Policy Troubleshooter API Version v1beta
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://cloud.google.com/iam/'>Policy Troubleshooter API</a>
 *      <tr><th>API Version<td>v1beta
 *      <tr><th>API Rev<td>20190929 (1732)
 *      <tr><th>API Docs
 *          <td><a href='https://cloud.google.com/iam/'>
 *              https://cloud.google.com/iam/</a>
 *      <tr><th>Discovery Name<td>policytroubleshooter
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Policy Troubleshooter API can be found at
 * <a href='https://cloud.google.com/iam/'>https://cloud.google.com/iam/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.PolicyTroubleshooter.v1beta
{
    /// <summary>The PolicyTroubleshooter Service.</summary>
    public class PolicyTroubleshooterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PolicyTroubleshooterService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PolicyTroubleshooterService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            iam = new IamResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "policytroubleshooter"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            get { return BaseUriOverride ?? "https://policytroubleshooter.googleapis.com/"; }
        #else
            get { return "https://policytroubleshooter.googleapis.com/"; }
        #endif
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://policytroubleshooter.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Policy Troubleshooter API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Policy Troubleshooter API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        private readonly IamResource iam;

        /// <summary>Gets the Iam resource.</summary>
        public virtual IamResource Iam
        {
            get { return iam; }
        }
    }

    ///<summary>A base abstract class for PolicyTroubleshooter requests.</summary>
    public abstract class PolicyTroubleshooterBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new PolicyTroubleshooterBaseServiceRequest instance.</summary>
        protected PolicyTroubleshooterBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes PolicyTroubleshooter parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "iam" collection of methods.</summary>
    public class IamResource
    {
        private const string Resource = "iam";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IamResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Perform a check on whether a member is granted a permission on a resource and how that grant/deny
        /// is determined accordinga to the resource's effective IAM policy interpretation.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual TroubleshootRequest Troubleshoot(Google.Apis.PolicyTroubleshooter.v1beta.Data.GoogleCloudPolicytroubleshooterV1betaTroubleshootIamPolicyRequest body)
        {
            return new TroubleshootRequest(service, body);
        }

        /// <summary>Perform a check on whether a member is granted a permission on a resource and how that grant/deny
        /// is determined accordinga to the resource's effective IAM policy interpretation.</summary>
        public class TroubleshootRequest : PolicyTroubleshooterBaseServiceRequest<Google.Apis.PolicyTroubleshooter.v1beta.Data.GoogleCloudPolicytroubleshooterV1betaTroubleshootIamPolicyResponse>
        {
            /// <summary>Constructs a new Troubleshoot request.</summary>
            public TroubleshootRequest(Google.Apis.Services.IClientService service, Google.Apis.PolicyTroubleshooter.v1beta.Data.GoogleCloudPolicytroubleshooterV1betaTroubleshootIamPolicyRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PolicyTroubleshooter.v1beta.Data.GoogleCloudPolicytroubleshooterV1betaTroubleshootIamPolicyRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "troubleshoot"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1beta/iam:troubleshoot"; }
            }

            /// <summary>Initializes Troubleshoot parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.PolicyTroubleshooter.v1beta.Data
{    

    /// <summary>AccessTuple defines information required for checking an access attempt. In other words, this is the
    /// tuple given to `CheckAccess`.</summary>
    public class GoogleCloudPolicytroubleshooterV1betaAccessTuple : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A full resource name according to https://cloud.google.com/apis/design/resource_names.
        /// This is the full resource name of the resource that access is checked against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; } 

        /// <summary>Required. The Cloud IAM permission under which defines the kind of access being explained. Example:
        /// "resourcemanager.projects.get" would explain if and why the principal has the resourcemanager.projects.get
        /// permission on the resource specified in full_resource_name declared in this structure. See
        /// https://cloud.google.com/iam/docs/testing-permissions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; } 

        /// <summary>Required. The principal on behalf of who the access is explained for. The format is one of the
        /// principal's email addresses associated with its gaia account. It must be an account that can appear as an
        /// actor. For example groups are not supported. Currently, service accounts, users are supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Binding Explanation.</summary>
    public class GoogleCloudPolicytroubleshooterV1betaBindingExplanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>REQUIRED: Access decision for this binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual string Access { get; set; } 

        /// <summary>The condition which needs to be satisfied in order for this binding to grant the role to the
        /// principal. See https://cloud.google.com/iam/docs/conditions-base</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; } 

        /// <summary>For each member in the binding, provides information whether or not the principal from the request
        /// is included in the member by which the CheckResult is keyed. May indicate that the caller has no access to
        /// this information. example key: 'group:cloud-iam-assist-eng@google.com' example value '{NOT_GRANTED,
        /// HIGH}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IDictionary<string,GoogleCloudPolicytroubleshooterV1betaBindingExplanationAnnotatedMembership> Memberships { get; set; } 

        /// <summary>Bubbles up role_permission level relavance to BindingExplanation object. If role permission is
        /// NORMAL, then binding relevance is NORMAL. If role permission is HIGH, then binding relevance is
        /// HIGH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; } 

        /// <summary>The role that this binding grants in the policy. for example "roles/compute.serviceAgent"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>Whether the role of this binding contains the checked permission</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolePermission")]
        public virtual string RolePermission { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("rolePermissionRelevance")]
        public virtual string RolePermissionRelevance { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GoogleCloudPolicytroubleshooterV1betaBindingExplanationAnnotatedMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An explained IAM policy combines the raw policy in the context of the resource which it is attached to
    /// along with detailed evaluation on the evaluation parameters provided through the request.</summary>
    public class GoogleCloudPolicytroubleshooterV1betaExplainedPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access decision for this section of the resource's effective policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual string Access { get; set; } 

        /// <summary>Detailed binding evaluation explanations provide information about how each binding contributes to
        /// the principal's access or the lack thereof.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindingExplanations")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicytroubleshooterV1betaBindingExplanation> BindingExplanations { get; set; } 

        /// <summary>Resource that this section of the effective policy attaches to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; } 

        /// <summary>The IAM policy attached to the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; } 

        /// <summary>Relevance of this Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>TroubleshootIamPolicyRequest is used in TroubleshootIamPolicy</summary>
    public class GoogleCloudPolicytroubleshooterV1betaTroubleshootIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("accessTuple")]
        public virtual GoogleCloudPolicytroubleshooterV1betaAccessTuple AccessTuple { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>TroubleshootIamPolicyResponse is used in TroubleshootIamPolicy.</summary>
    public class GoogleCloudPolicytroubleshooterV1betaTroubleshootIamPolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reflects whether the probed access was granted, denied or ultimately could not be decided from the
        /// caller's point of view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual string Access { get; set; } 

        /// <summary>List of explained policies. Each explanation corresponds to one policy along the ancestry
        /// path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainedPolicies")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicytroubleshooterV1betaExplainedPolicy> ExplainedPolicies { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies the audit configuration for a service. The configuration determines which permission types
    /// are logged, and what identities, if any, are exempted from logging. An AuditConfig must have one or more
    /// AuditLogConfigs.
    ///
    /// If there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is
    /// used for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted.
    ///
    /// Example Policy with multiple AuditConfigs:
    ///
    /// { "audit_configs": [ { "service": "allServices" "audit_log_configs": [ { "log_type": "DATA_READ",
    /// "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE", }, { "log_type": "ADMIN_READ", }
    /// ] }, { "service": "sampleservice.googleapis.com" "audit_log_configs": [ { "log_type": "DATA_READ", }, {
    /// "log_type": "DATA_WRITE", "exempted_members": [ "user:aliya@example.com" ] } ] } ] }
    ///
    /// For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ logging. It also exempts
    /// jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.</summary>
    public class GoogleIamV1AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditLogConfig> AuditLogConfigs { get; set; } 

        /// <summary>Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Provides the configuration for logging a type of permissions. Example:
    ///
    /// { "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, {
    /// "log_type": "DATA_WRITE", } ] }
    ///
    /// This enables 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ
    /// logging.</summary>
    public class GoogleIamV1AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the identities that do not cause logging for this type of permission. Follows the same
        /// format of Binding.members.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; } 

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Associates `members` with a `role`.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The condition that is associated with this binding. NOTE: An unsatisfied condition will not allow
        /// user access via current binding. Different bindings, including their conditions, are examined
        /// independently.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; } 

        /// <summary>Specifies the identities requesting access for a Cloud Platform resource. `members` can have the
        /// following values:
        ///
        /// * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a Google
        /// account.
        ///
        /// * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated with a Google
        /// account or a service account.
        ///
        /// * `user:{emailid}`: An email address that represents a specific Google account. For example,
        /// `alice@example.com` .
        ///
        /// * `serviceAccount:{emailid}`: An email address that represents a service account. For example, `my-other-
        /// app@appspot.gserviceaccount.com`.
        ///
        /// * `group:{emailid}`: An email address that represents a Google group. For example, `admins@example.com`.
        ///
        /// * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that domain. For example,
        /// `google.com` or `example.com`.
        ///
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; } 

        /// <summary>Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or
        /// `roles/owner`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines an Identity and Access Management (IAM) policy. It is used to specify access control policies
    /// for Cloud Platform resources.
    ///
    /// A `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members
    /// can be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list
    /// of permissions (defined by IAM or configured by users). A `binding` can optionally specify a `condition`, which
    /// is a logic expression that further constrains the role binding based on attributes about the request and/or
    /// target resource.
    ///
    /// **JSON Example**
    ///
    /// { "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": ["user:eve@example.com"], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// < timestamp('2020-10-01T00:00:00.000Z')", } } ] }
    ///
    /// **YAML Example**
    ///
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com - serviceAccount:my-
    /// project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin - members: -
    /// user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable access
    /// description: Does not grant access after Sep 2020 expression: request.time <
    /// timestamp('2020-10-01T00:00:00.000Z')
    ///
    /// For a description of IAM and its features, see the [IAM developer's
    /// guide](https://cloud.google.com/iam/docs).</summary>
    public class GoogleIamV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditConfig> AuditConfigs { get; set; } 

        /// <summary>Associates a list of `members` to a `role`. Optionally may specify a `condition` that determines
        /// when binding is in effect. `bindings` with no members will result in an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleIamV1Binding> Bindings { get; set; } 

        /// <summary>`etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of
        /// a policy from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy.
        ///
        /// If no `etag` is provided in the call to `setIamPolicy`, then the existing policy is overwritten. Due to
        /// blind-set semantics of an etag-less policy, 'setIamPolicy' will not fail even if either of incoming or
        /// stored policy does not meet the version requirements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Specifies the format of the policy.
        ///
        /// Valid values are 0, 1, and 3. Requests specifying an invalid value will be rejected.
        ///
        /// Operations affecting conditional bindings must specify version 3. This can be either setting a conditional
        /// policy, modifying a conditional binding, or removing a conditional binding from the stored conditional
        /// policy. Operations on non-conditional policies may specify any valid value or leave the field unset.
        ///
        /// If no etag is provided in the call to `setIamPolicy`, any version compliance checks on the incoming and/or
        /// stored policy is skipped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; } 

    }    

    /// <summary>Represents an expression text. Example:
    ///
    /// title: "User account presence" description: "Determines whether the request has a user account" expression:
    /// "size(request.user) > 0"</summary>
    public class GoogleTypeExpr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An optional description of the expression. This is a longer text which describes the expression,
        /// e.g. when hovered over it in a UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Textual representation of an expression in Common Expression Language syntax.
        ///
        /// The application context of the containing message determines which well-known feature set of CEL is
        /// supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; } 

        /// <summary>An optional string indicating the location of the expression for error reporting, e.g. a file name
        /// and a position in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>An optional title for the expression, i.e. a short string describing its purpose. This can be used
        /// e.g. in UIs which allow to enter the expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
