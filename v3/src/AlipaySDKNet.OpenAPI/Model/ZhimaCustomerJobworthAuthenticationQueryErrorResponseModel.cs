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
    /// ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel")]
    public partial class ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel : IEquatable<ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum USERNOTAUTHORIZE for value: USER_NOT_AUTHORIZE
            /// </summary>
            [EnumMember(Value = "USER_NOT_AUTHORIZE")]
            USERNOTAUTHORIZE = 1,

            /// <summary>
            /// Enum TOKENINVALID for value: TOKEN_INVALID
            /// </summary>
            [EnumMember(Value = "TOKEN_INVALID")]
            TOKENINVALID = 2,

            /// <summary>
            /// Enum NOTOPENZM for value: NOT_OPEN_ZM
            /// </summary>
            [EnumMember(Value = "NOT_OPEN_ZM")]
            NOTOPENZM = 3,

            /// <summary>
            /// Enum USERNOTOPENJOBWORTH for value: USER_NOT_OPEN_JOBWORTH
            /// </summary>
            [EnumMember(Value = "USER_NOT_OPEN_JOBWORTH")]
            USERNOTOPENJOBWORTH = 4,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 5,

            /// <summary>
            /// Enum JOBWORTHBLACKLIST for value: JOB_WORTH_BLACK_LIST
            /// </summary>
            [EnumMember(Value = "JOB_WORTH_BLACK_LIST")]
            JOBWORTHBLACKLIST = 6,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 7,

            /// <summary>
            /// Enum MERCHANTINTERCEPT for value: MERCHANT_INTERCEPT
            /// </summary>
            [EnumMember(Value = "MERCHANT_INTERCEPT")]
            MERCHANTINTERCEPT = 8,

            /// <summary>
            /// Enum RISKINTERCEPT for value: RISK_INTERCEPT
            /// </summary>
            [EnumMember(Value = "RISK_INTERCEPT")]
            RISKINTERCEPT = 9,

            /// <summary>
            /// Enum OPENZMACCOUNTINTERCEPT for value: OPEN_ZM_ACCOUNT_INTERCEPT
            /// </summary>
            [EnumMember(Value = "OPEN_ZM_ACCOUNT_INTERCEPT")]
            OPENZMACCOUNTINTERCEPT = 10,

            /// <summary>
            /// Enum CARDNONOTMATCH for value: CARD_NO_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "CARD_NO_NOT_MATCH")]
            CARDNONOTMATCH = 11,

            /// <summary>
            /// Enum MOBILENONOTMATCH for value: MOBILE_NO_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "MOBILE_NO_NOT_MATCH")]
            MOBILENONOTMATCH = 12,

            /// <summary>
            /// Enum USERNAMENOTMATCH for value: USER_NAME_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "USER_NAME_NOT_MATCH")]
            USERNAMENOTMATCH = 13,

            /// <summary>
            /// Enum WRONGOUTAGREEMENTNOINTERCEPT for value: WRONG_OUT_AGREEMENT_NO_INTERCEPT
            /// </summary>
            [EnumMember(Value = "WRONG_OUT_AGREEMENT_NO_INTERCEPT")]
            WRONGOUTAGREEMENTNOINTERCEPT = 14,

            /// <summary>
            /// Enum TOKENNOTMATCHIDENTITYTYPE for value: TOKEN_NOT_MATCH_IDENTITY_TYPE
            /// </summary>
            [EnumMember(Value = "TOKEN_NOT_MATCH_IDENTITY_TYPE")]
            TOKENNOTMATCHIDENTITYTYPE = 15,

            /// <summary>
            /// Enum PARAMERROR for value: PARAM_ERROR
            /// </summary>
            [EnumMember(Value = "PARAM_ERROR")]
            PARAMERROR = 16

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel and cannot be null");
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
            sb.Append("class ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel {\n");
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
            return this.Equals(input as ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCustomerJobworthAuthenticationQueryErrorResponseModel input)
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
