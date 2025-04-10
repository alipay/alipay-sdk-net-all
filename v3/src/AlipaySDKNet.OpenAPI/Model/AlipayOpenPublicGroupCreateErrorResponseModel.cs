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
    /// AlipayOpenPublicGroupCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicGroupCreateErrorResponseModel")]
    public partial class AlipayOpenPublicGroupCreateErrorResponseModel : IEquatable<AlipayOpenPublicGroupCreateErrorResponseModel>, IValidatableObject
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
            /// Enum GROUPCROWDTOOSMALL for value: GROUP_CROWD_TOO_SMALL
            /// </summary>
            [EnumMember(Value = "GROUP_CROWD_TOO_SMALL")]
            GROUPCROWDTOOSMALL = 2,

            /// <summary>
            /// Enum GROUPNAMEISEMPTY for value: GROUP_NAME_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "GROUP_NAME_IS_EMPTY")]
            GROUPNAMEISEMPTY = 3,

            /// <summary>
            /// Enum GROUPNAMETOOLONG for value: GROUP_NAME_TOO_LONG
            /// </summary>
            [EnumMember(Value = "GROUP_NAME_TOO_LONG")]
            GROUPNAMETOOLONG = 4,

            /// <summary>
            /// Enum GROUPNAMEISINVALID for value: GROUP_NAME_IS_INVALID
            /// </summary>
            [EnumMember(Value = "GROUP_NAME_IS_INVALID")]
            GROUPNAMEISINVALID = 5,

            /// <summary>
            /// Enum GROUPNAMEEXISTED for value: GROUP_NAME_EXISTED
            /// </summary>
            [EnumMember(Value = "GROUP_NAME_EXISTED")]
            GROUPNAMEEXISTED = 6,

            /// <summary>
            /// Enum LABELISREUSED for value: LABEL_IS_REUSED
            /// </summary>
            [EnumMember(Value = "LABEL_IS_REUSED")]
            LABELISREUSED = 7,

            /// <summary>
            /// Enum LABELIDISEMPTY for value: LABEL_ID_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_ID_IS_EMPTY")]
            LABELIDISEMPTY = 8,

            /// <summary>
            /// Enum OPERATORISEMPTY for value: OPERATOR_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "OPERATOR_IS_EMPTY")]
            OPERATORISEMPTY = 9,

            /// <summary>
            /// Enum OPERATORISINVALID for value: OPERATOR_IS_INVALID
            /// </summary>
            [EnumMember(Value = "OPERATOR_IS_INVALID")]
            OPERATORISINVALID = 10,

            /// <summary>
            /// Enum LABELVALUEISEMPTY for value: LABEL_VALUE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_VALUE_IS_EMPTY")]
            LABELVALUEISEMPTY = 11,

            /// <summary>
            /// Enum LABELVALUEINVALID for value: LABEL_VALUE_INVALID
            /// </summary>
            [EnumMember(Value = "LABEL_VALUE_INVALID")]
            LABELVALUEINVALID = 12,

            /// <summary>
            /// Enum LABELNOTEXISTS for value: LABEL_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "LABEL_NOT_EXISTS")]
            LABELNOTEXISTS = 13

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicGroupCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicGroupCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicGroupCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicGroupCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicGroupCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicGroupCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicGroupCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicGroupCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicGroupCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicGroupCreateErrorResponseModel input)
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
