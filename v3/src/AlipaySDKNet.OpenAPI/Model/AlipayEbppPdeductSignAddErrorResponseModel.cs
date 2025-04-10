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
    /// AlipayEbppPdeductSignAddErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppPdeductSignAddErrorResponseModel")]
    public partial class AlipayEbppPdeductSignAddErrorResponseModel : IEquatable<AlipayEbppPdeductSignAddErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum IsvArgumentsError for value: isv.arguments-error
            /// </summary>
            [EnumMember(Value = "isv.arguments-error")]
            IsvArgumentsError = 1,

            /// <summary>
            /// Enum IspUnknowError for value: isp.unknow-error
            /// </summary>
            [EnumMember(Value = "isp.unknow-error")]
            IspUnknowError = 2,

            /// <summary>
            /// Enum IsvChargeNoDirectDeduct for value: isv.charge-no-direct-deduct
            /// </summary>
            [EnumMember(Value = "isv.charge-no-direct-deduct")]
            IsvChargeNoDirectDeduct = 3,

            /// <summary>
            /// Enum IsvDeductUserNoAuth for value: isv.deduct-user-no-auth
            /// </summary>
            [EnumMember(Value = "isv.deduct-user-no-auth")]
            IsvDeductUserNoAuth = 4,

            /// <summary>
            /// Enum IsvDeductPaypasswordError for value: isv.deduct-paypassword-error
            /// </summary>
            [EnumMember(Value = "isv.deduct-paypassword-error")]
            IsvDeductPaypasswordError = 5,

            /// <summary>
            /// Enum IsvDeductBalanceIsNotPayment for value: isv.deduct-balance-is-not-payment
            /// </summary>
            [EnumMember(Value = "isv.deduct-balance-is-not-payment")]
            IsvDeductBalanceIsNotPayment = 6,

            /// <summary>
            /// Enum IsvDeductDeplicatedSelf for value: isv.deduct-deplicated-self
            /// </summary>
            [EnumMember(Value = "isv.deduct-deplicated-self")]
            IsvDeductDeplicatedSelf = 7,

            /// <summary>
            /// Enum IsvDeductSignNoExist for value: isv.deduct-sign-no-exist
            /// </summary>
            [EnumMember(Value = "isv.deduct-sign-no-exist")]
            IsvDeductSignNoExist = 8,

            /// <summary>
            /// Enum IsvDeductBillkeySignExit for value: isv.deduct-billkey-sign-exit
            /// </summary>
            [EnumMember(Value = "isv.deduct-billkey-sign-exit")]
            IsvDeductBillkeySignExit = 9,

            /// <summary>
            /// Enum IsvDeductNoAutherityByRealnamed for value: isv.deduct-no-autherity-by-realnamed
            /// </summary>
            [EnumMember(Value = "isv.deduct-no-autherity-by-realnamed")]
            IsvDeductNoAutherityByRealnamed = 10,

            /// <summary>
            /// Enum IsvDeductNoAutherityByQ for value: isv.deduct-no-autherity-by-q
            /// </summary>
            [EnumMember(Value = "isv.deduct-no-autherity-by-q")]
            IsvDeductNoAutherityByQ = 11

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductSignAddErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayEbppPdeductSignAddErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductSignAddErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayEbppPdeductSignAddErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayEbppPdeductSignAddErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayEbppPdeductSignAddErrorResponseModel {\n");
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
            return this.Equals(input as AlipayEbppPdeductSignAddErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppPdeductSignAddErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppPdeductSignAddErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppPdeductSignAddErrorResponseModel input)
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
