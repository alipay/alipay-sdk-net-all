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
    /// AlipayOpenPublicMenuCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMenuCreateErrorResponseModel")]
    public partial class AlipayOpenPublicMenuCreateErrorResponseModel : IEquatable<AlipayOpenPublicMenuCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum ILLEGALBIZPARAMS for value: ILLEGAL_BIZ_PARAMS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_BIZ_PARAMS")]
            ILLEGALBIZPARAMS = 1,

            /// <summary>
            /// Enum BUTTONISEMPTY for value: BUTTON_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "BUTTON_IS_EMPTY")]
            BUTTONISEMPTY = 2,

            /// <summary>
            /// Enum ICONISEMPTY for value: ICON_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "ICON_IS_EMPTY")]
            ICONISEMPTY = 3,

            /// <summary>
            /// Enum ICONISINVALID for value: ICON_IS_INVALID
            /// </summary>
            [EnumMember(Value = "ICON_IS_INVALID")]
            ICONISINVALID = 4,

            /// <summary>
            /// Enum ILLEGALARGUMENTPARAMS for value: ILLEGAL_ARGUMENT_PARAMS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_ARGUMENT_PARAMS")]
            ILLEGALARGUMENTPARAMS = 5,

            /// <summary>
            /// Enum BUSINESSERROR for value: BUSINESS_ERROR
            /// </summary>
            [EnumMember(Value = "BUSINESS_ERROR")]
            BUSINESSERROR = 6,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 7,

            /// <summary>
            /// Enum MENUFORMATERROR for value: MENU_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "MENU_FORMAT_ERROR")]
            MENUFORMATERROR = 8,

            /// <summary>
            /// Enum ICONSIZEERROR for value: ICON_SIZE_ERROR
            /// </summary>
            [EnumMember(Value = "ICON_SIZE_ERROR")]
            ICONSIZEERROR = 9,

            /// <summary>
            /// Enum MENUCHATNUMBERLIMIT for value: MENU_CHAT_NUMBER_LIMIT
            /// </summary>
            [EnumMember(Value = "MENU_CHAT_NUMBER_LIMIT")]
            MENUCHATNUMBERLIMIT = 10,

            /// <summary>
            /// Enum BUTTONCOUNTLIMIT for value: BUTTON_COUNT_LIMIT
            /// </summary>
            [EnumMember(Value = "BUTTON_COUNT_LIMIT")]
            BUTTONCOUNTLIMIT = 11,

            /// <summary>
            /// Enum MENUTITLEEMPTY for value: MENU_TITLE_EMPTY
            /// </summary>
            [EnumMember(Value = "MENU_TITLE_EMPTY")]
            MENUTITLEEMPTY = 12,

            /// <summary>
            /// Enum ICONTOOLARGE for value: ICON_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "ICON_TOO_LARGE")]
            ICONTOOLARGE = 13,

            /// <summary>
            /// Enum MENUTITLEOUTOFLENGTH for value: MENU_TITLE_OUT_OF_LENGTH
            /// </summary>
            [EnumMember(Value = "MENU_TITLE_OUT_OF_LENGTH")]
            MENUTITLEOUTOFLENGTH = 14,

            /// <summary>
            /// Enum ICONTYPEINVALID for value: ICON_TYPE_INVALID
            /// </summary>
            [EnumMember(Value = "ICON_TYPE_INVALID")]
            ICONTYPEINVALID = 15,

            /// <summary>
            /// Enum MENUTYPENOTFOUND for value: MENU_TYPE_NOTFOUND
            /// </summary>
            [EnumMember(Value = "MENU_TYPE_NOTFOUND")]
            MENUTYPENOTFOUND = 16,

            /// <summary>
            /// Enum ACTIONPARAMISEMPTY for value: ACTION_PARAM_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "ACTION_PARAM_IS_EMPTY")]
            ACTIONPARAMISEMPTY = 17,

            /// <summary>
            /// Enum MENUAUTHNOTILLEGAL for value: MENU_AUTH_NOT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MENU_AUTH_NOT_ILLEGAL")]
            MENUAUTHNOTILLEGAL = 18,

            /// <summary>
            /// Enum MENUSECURITYFORBID for value: MENU_SECURITY_FORBID
            /// </summary>
            [EnumMember(Value = "MENU_SECURITY_FORBID")]
            MENUSECURITYFORBID = 19,

            /// <summary>
            /// Enum MENUSUBOUTOFNUM for value: MENU_SUB_OUT_OF_NUM
            /// </summary>
            [EnumMember(Value = "MENU_SUB_OUT_OF_NUM")]
            MENUSUBOUTOFNUM = 20,

            /// <summary>
            /// Enum APPNOAVAIABLE for value: APP_NO_AVAIABLE
            /// </summary>
            [EnumMember(Value = "APP_NO_AVAIABLE")]
            APPNOAVAIABLE = 21,

            /// <summary>
            /// Enum MENUHASEXIST for value: MENU_HAS_EXIST
            /// </summary>
            [EnumMember(Value = "MENU_HAS_EXIST")]
            MENUHASEXIST = 22,

            /// <summary>
            /// Enum EXTENSIONSTATUSINVALID for value: EXTENSION_STATUS_INVALID
            /// </summary>
            [EnumMember(Value = "EXTENSION_STATUS_INVALID")]
            EXTENSIONSTATUSINVALID = 23,

            /// <summary>
            /// Enum AUTHORIZENOTADMIT for value: AUTHORIZE_NOT_ADMIT
            /// </summary>
            [EnumMember(Value = "AUTHORIZE_NOT_ADMIT")]
            AUTHORIZENOTADMIT = 24

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMenuCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicMenuCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMenuCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicMenuCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicMenuCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicMenuCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicMenuCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMenuCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMenuCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMenuCreateErrorResponseModel input)
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
