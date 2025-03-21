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
    /// AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel")]
    public partial class AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel : IEquatable<AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 1,

            /// <summary>
            /// Enum BUTTONISEMPTY for value: BUTTON_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "BUTTON_IS_EMPTY")]
            BUTTONISEMPTY = 2,

            /// <summary>
            /// Enum BUTTONCOUNTLIMIT for value: BUTTON_COUNT_LIMIT
            /// </summary>
            [EnumMember(Value = "BUTTON_COUNT_LIMIT")]
            BUTTONCOUNTLIMIT = 3,

            /// <summary>
            /// Enum MENUTITLEEMPTY for value: MENU_TITLE_EMPTY
            /// </summary>
            [EnumMember(Value = "MENU_TITLE_EMPTY")]
            MENUTITLEEMPTY = 4,

            /// <summary>
            /// Enum MENUTITLEOUTOFLENGTH for value: MENU_TITLE_OUT_OF_LENGTH
            /// </summary>
            [EnumMember(Value = "MENU_TITLE_OUT_OF_LENGTH")]
            MENUTITLEOUTOFLENGTH = 5,

            /// <summary>
            /// Enum MENUTYPENOTFOUND for value: MENU_TYPE_NOTFOUND
            /// </summary>
            [EnumMember(Value = "MENU_TYPE_NOTFOUND")]
            MENUTYPENOTFOUND = 6,

            /// <summary>
            /// Enum MENUSUBOUTOFNUM for value: MENU_SUB_OUT_OF_NUM
            /// </summary>
            [EnumMember(Value = "MENU_SUB_OUT_OF_NUM")]
            MENUSUBOUTOFNUM = 7,

            /// <summary>
            /// Enum ICONISEMPTY for value: ICON_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "ICON_IS_EMPTY")]
            ICONISEMPTY = 8,

            /// <summary>
            /// Enum ACTIONPARAMISEMPTY for value: ACTION_PARAM_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "ACTION_PARAM_IS_EMPTY")]
            ACTIONPARAMISEMPTY = 9,

            /// <summary>
            /// Enum ICONISINVALID for value: ICON_IS_INVALID
            /// </summary>
            [EnumMember(Value = "ICON_IS_INVALID")]
            ICONISINVALID = 10,

            /// <summary>
            /// Enum ICONSIZEERROR for value: ICON_SIZE_ERROR
            /// </summary>
            [EnumMember(Value = "ICON_SIZE_ERROR")]
            ICONSIZEERROR = 11,

            /// <summary>
            /// Enum ICONTOOLARGE for value: ICON_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "ICON_TOO_LARGE")]
            ICONTOOLARGE = 12,

            /// <summary>
            /// Enum ICONTYPEINVALID for value: ICON_TYPE_INVALID
            /// </summary>
            [EnumMember(Value = "ICON_TYPE_INVALID")]
            ICONTYPEINVALID = 13,

            /// <summary>
            /// Enum LABELRULESISEMPTY for value: LABEL_RULES_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_RULES_IS_EMPTY")]
            LABELRULESISEMPTY = 14,

            /// <summary>
            /// Enum RULECOUNTINVALID for value: RULE_COUNT_INVALID
            /// </summary>
            [EnumMember(Value = "RULE_COUNT_INVALID")]
            RULECOUNTINVALID = 15,

            /// <summary>
            /// Enum LABELIDISEMPTY for value: LABEL_ID_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_ID_IS_EMPTY")]
            LABELIDISEMPTY = 16,

            /// <summary>
            /// Enum LABELVALUEISEMPTY for value: LABEL_VALUE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_VALUE_IS_EMPTY")]
            LABELVALUEISEMPTY = 17,

            /// <summary>
            /// Enum LABELVALUEINVALID for value: LABEL_VALUE_INVALID
            /// </summary>
            [EnumMember(Value = "LABEL_VALUE_INVALID")]
            LABELVALUEINVALID = 18,

            /// <summary>
            /// Enum LABELNOTEXISTS for value: LABEL_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "LABEL_NOT_EXISTS")]
            LABELNOTEXISTS = 19,

            /// <summary>
            /// Enum MENUSECURITYFORBID for value: MENU_SECURITY_FORBID
            /// </summary>
            [EnumMember(Value = "MENU_SECURITY_FORBID")]
            MENUSECURITYFORBID = 20,

            /// <summary>
            /// Enum LABELISREUSED for value: LABEL_IS_REUSED
            /// </summary>
            [EnumMember(Value = "LABEL_IS_REUSED")]
            LABELISREUSED = 21,

            /// <summary>
            /// Enum OPERATORISEMPTY for value: OPERATOR_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "OPERATOR_IS_EMPTY")]
            OPERATORISEMPTY = 22,

            /// <summary>
            /// Enum OPERATORISINVALID for value: OPERATOR_IS_INVALID
            /// </summary>
            [EnumMember(Value = "OPERATOR_IS_INVALID")]
            OPERATORISINVALID = 23,

            /// <summary>
            /// Enum GROUPIDISINVALID for value: GROUP_ID_IS_INVALID
            /// </summary>
            [EnumMember(Value = "GROUP_ID_IS_INVALID")]
            GROUPIDISINVALID = 24,

            /// <summary>
            /// Enum GROUPNOTREADY for value: GROUP_NOT_READY
            /// </summary>
            [EnumMember(Value = "GROUP_NOT_READY")]
            GROUPNOTREADY = 25,

            /// <summary>
            /// Enum GROUPNOTEXISTED for value: GROUP_NOT_EXISTED
            /// </summary>
            [EnumMember(Value = "GROUP_NOT_EXISTED")]
            GROUPNOTEXISTED = 26,

            /// <summary>
            /// Enum NOTSUPPORTGROUP for value: NOT_SUPPORT_GROUP
            /// </summary>
            [EnumMember(Value = "NOT_SUPPORT_GROUP")]
            NOTSUPPORTGROUP = 27,

            /// <summary>
            /// Enum MENUNUMBERLIMIT for value: MENU_NUMBER_LIMIT
            /// </summary>
            [EnumMember(Value = "MENU_NUMBER_LIMIT")]
            MENUNUMBERLIMIT = 28,

            /// <summary>
            /// Enum ICONNOTSUPPORTSUBMENU for value: ICON_NOT_SUPPORT_SUB_MENU
            /// </summary>
            [EnumMember(Value = "ICON_NOT_SUPPORT_SUB_MENU")]
            ICONNOTSUPPORTSUBMENU = 29,

            /// <summary>
            /// Enum SECURITYCHECKFAILED for value: SECURITY_CHECK_FAILED
            /// </summary>
            [EnumMember(Value = "SECURITY_CHECK_FAILED")]
            SECURITYCHECKFAILED = 30,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 31,

            /// <summary>
            /// Enum AUTHORIZENOTADMIT for value: AUTHORIZE_NOT_ADMIT
            /// </summary>
            [EnumMember(Value = "AUTHORIZE_NOT_ADMIT")]
            AUTHORIZENOTADMIT = 32

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicPersonalizedMenuCreateErrorResponseModel input)
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
