/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-19
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
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// AlipayOpenMiniVersionBuildQueryErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniVersionBuildQueryErrorResponseModel")]
    public partial class AlipayOpenMiniVersionBuildQueryErrorResponseModel : IEquatable<AlipayOpenMiniVersionBuildQueryErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 1,

            /// <summary>
            /// Enum APPVERSIONISBLANK for value: APP_VERSION_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_VERSION_IS_BLANK")]
            APPVERSIONISBLANK = 2,

            /// <summary>
            /// Enum CODETEMPLATENOTEXIST for value: CODE_TEMPLATE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "CODE_TEMPLATE_NOT_EXIST")]
            CODETEMPLATENOTEXIST = 3,

            /// <summary>
            /// Enum NOAUTHRELATION for value: NO_AUTH_RELATION
            /// </summary>
            [EnumMember(Value = "NO_AUTH_RELATION")]
            NOAUTHRELATION = 4,

            /// <summary>
            /// Enum APPLICATIONTYPENOTMINIAPP for value: APPLICATION_TYPE_NOT_MINIAPP
            /// </summary>
            [EnumMember(Value = "APPLICATION_TYPE_NOT_MINIAPP")]
            APPLICATIONTYPENOTMINIAPP = 5,

            /// <summary>
            /// Enum MINIAPPNOTONLINE for value: MINI_APP_NOT_ONLINE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NOT_ONLINE")]
            MINIAPPNOTONLINE = 6,

            /// <summary>
            /// Enum ISVAPPIDISBLANK for value: ISV_APP_ID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "ISV_APP_ID_IS_BLANK")]
            ISVAPPIDISBLANK = 7,

            /// <summary>
            /// Enum BUILDVERSIONNOTEXISTED for value: BUILD_VERSION_NOT_EXISTED
            /// </summary>
            [EnumMember(Value = "BUILD_VERSION_NOT_EXISTED")]
            BUILDVERSIONNOTEXISTED = 8,

            /// <summary>
            /// Enum BUNDLEIDNOTEXIST for value: BUNDLE_ID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_NOT_EXIST")]
            BUNDLEIDNOTEXIST = 9,

            /// <summary>
            /// Enum APPLICATIONTYPEILLEGAL for value: APPLICATION_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "APPLICATION_TYPE_ILLEGAL")]
            APPLICATIONTYPEILLEGAL = 10,

            /// <summary>
            /// Enum NOTEMPLATEINSTANTIATERELATION for value: NO_TEMPLATE_INSTANTIATE_RELATION
            /// </summary>
            [EnumMember(Value = "NO_TEMPLATE_INSTANTIATE_RELATION")]
            NOTEMPLATEINSTANTIATERELATION = 11,

            /// <summary>
            /// Enum PACKAGEIDISBLANK for value: PACKAGE_ID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "PACKAGE_ID_IS_BLANK")]
            PACKAGEIDISBLANK = 12,

            /// <summary>
            /// Enum POLLINGBUILDINGERROR for value: POLLING_BUILDING_ERROR
            /// </summary>
            [EnumMember(Value = "POLLING_BUILDING_ERROR")]
            POLLINGBUILDINGERROR = 13,

            /// <summary>
            /// Enum POLLINGBUILDVERSIONNOTEXIST for value: POLLING_BUILD_VERSION_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "POLLING_BUILD_VERSION_NOT_EXIST")]
            POLLINGBUILDVERSIONNOTEXIST = 14

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionBuildQueryErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniVersionBuildQueryErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionBuildQueryErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniVersionBuildQueryErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniVersionBuildQueryErrorResponseModel and cannot be null");
            // }
            this.Message = message;
            this.Links = links;
        }

        /// <summary>
        /// 解决方案链接
        /// </summary>
        /// <value>解决方案链接</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public string Links { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>错误描述</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniVersionBuildQueryErrorResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniVersionBuildQueryErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniVersionBuildQueryErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniVersionBuildQueryErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniVersionBuildQueryErrorResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                return hashCode;
            }
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
