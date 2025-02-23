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
    /// IndirectAuthOrderFailedReason
    /// </summary>
    [DataContract(Name = "IndirectAuthOrderFailedReason")]
    public partial class IndirectAuthOrderFailedReason : IEquatable<IndirectAuthOrderFailedReason>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndirectAuthOrderFailedReason" /> class.
        /// </summary>
        /// <param name="failParam">审核失败字段.</param>
        /// <param name="failReason">描述申请单审核失败原因.</param>
        public IndirectAuthOrderFailedReason(string failParam = default(string), string failReason = default(string))
        {
            this.FailParam = failParam;
            this.FailReason = failReason;
        }

        /// <summary>
        /// 审核失败字段
        /// </summary>
        /// <value>审核失败字段</value>
        [DataMember(Name = "fail_param", EmitDefaultValue = false)]
        public string FailParam { get; set; }

        /// <summary>
        /// 描述申请单审核失败原因
        /// </summary>
        /// <value>描述申请单审核失败原因</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndirectAuthOrderFailedReason {\n");
            sb.Append("  FailParam: ").Append(FailParam).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
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
            return this.Equals(input as IndirectAuthOrderFailedReason);
        }

        /// <summary>
        /// Returns true if IndirectAuthOrderFailedReason instances are equal
        /// </summary>
        /// <param name="input">Instance of IndirectAuthOrderFailedReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndirectAuthOrderFailedReason input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailParam == input.FailParam ||
                    (this.FailParam != null &&
                    this.FailParam.Equals(input.FailParam))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
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
                if (this.FailParam != null)
                {
                    hashCode = (hashCode * 59) + this.FailParam.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
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
