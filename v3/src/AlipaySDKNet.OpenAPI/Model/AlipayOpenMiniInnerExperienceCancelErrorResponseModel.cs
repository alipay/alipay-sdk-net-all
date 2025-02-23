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
    /// AlipayOpenMiniInnerExperienceCancelErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerExperienceCancelErrorResponseModel")]
    public partial class AlipayOpenMiniInnerExperienceCancelErrorResponseModel : IEquatable<AlipayOpenMiniInnerExperienceCancelErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum INNERAPPIDISBLANK for value: INNER_APP_ID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "INNER_APP_ID_IS_BLANK")]
            INNERAPPIDISBLANK = 1,

            /// <summary>
            /// Enum INNERVERSIONISBLANK for value: INNER_VERSION_IS_BLANK
            /// </summary>
            [EnumMember(Value = "INNER_VERSION_IS_BLANK")]
            INNERVERSIONISBLANK = 2,

            /// <summary>
            /// Enum INNERAPPORIGINISBLANK for value: INNER_APP_ORIGIN_IS_BLANK
            /// </summary>
            [EnumMember(Value = "INNER_APP_ORIGIN_IS_BLANK")]
            INNERAPPORIGINISBLANK = 3,

            /// <summary>
            /// Enum INNERAPPORIGINNOTEXIT for value: INNER_APP_ORIGIN_NOT_EXIT
            /// </summary>
            [EnumMember(Value = "INNER_APP_ORIGIN_NOT_EXIT")]
            INNERAPPORIGINNOTEXIT = 4,

            /// <summary>
            /// Enum APPIDNOTEXIST for value: APPID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APPID_NOT_EXIST")]
            APPIDNOTEXIST = 5,

            /// <summary>
            /// Enum NOTTINYAPP for value: NOT_TINYAPP
            /// </summary>
            [EnumMember(Value = "NOT_TINYAPP")]
            NOTTINYAPP = 6

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerExperienceCancelErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniInnerExperienceCancelErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerExperienceCancelErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniInnerExperienceCancelErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniInnerExperienceCancelErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniInnerExperienceCancelErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniInnerExperienceCancelErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerExperienceCancelErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerExperienceCancelErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerExperienceCancelErrorResponseModel input)
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
