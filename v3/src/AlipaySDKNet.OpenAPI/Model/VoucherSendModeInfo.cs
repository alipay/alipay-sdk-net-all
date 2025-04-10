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
    /// VoucherSendModeInfo
    /// </summary>
    [DataContract(Name = "VoucherSendModeInfo")]
    public partial class VoucherSendModeInfo : IEquatable<VoucherSendModeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherSendModeInfo" /> class.
        /// </summary>
        /// <param name="voucherPackageModeInfo">voucherPackageModeInfo.</param>
        /// <param name="voucherSaleModeInfo">voucherSaleModeInfo.</param>
        /// <param name="voucherSendMode">券发放模式。.</param>
        /// <param name="voucherSendRuleInfo">voucherSendRuleInfo.</param>
        public VoucherSendModeInfo(VoucherPackageModeInfo voucherPackageModeInfo = default(VoucherPackageModeInfo), VoucherSaleModeInfo voucherSaleModeInfo = default(VoucherSaleModeInfo), string voucherSendMode = default(string), VoucherSendRuleInfo voucherSendRuleInfo = default(VoucherSendRuleInfo))
        {
            this.VoucherPackageModeInfo = voucherPackageModeInfo;
            this.VoucherSaleModeInfo = voucherSaleModeInfo;
            this.VoucherSendMode = voucherSendMode;
            this.VoucherSendRuleInfo = voucherSendRuleInfo;
        }

        /// <summary>
        /// Gets or Sets VoucherPackageModeInfo
        /// </summary>
        [DataMember(Name = "voucher_package_mode_info", EmitDefaultValue = false)]
        public VoucherPackageModeInfo VoucherPackageModeInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherSaleModeInfo
        /// </summary>
        [DataMember(Name = "voucher_sale_mode_info", EmitDefaultValue = false)]
        public VoucherSaleModeInfo VoucherSaleModeInfo { get; set; }

        /// <summary>
        /// 券发放模式。
        /// </summary>
        /// <value>券发放模式。</value>
        [DataMember(Name = "voucher_send_mode", EmitDefaultValue = false)]
        public string VoucherSendMode { get; set; }

        /// <summary>
        /// Gets or Sets VoucherSendRuleInfo
        /// </summary>
        [DataMember(Name = "voucher_send_rule_info", EmitDefaultValue = false)]
        public VoucherSendRuleInfo VoucherSendRuleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherSendModeInfo {\n");
            sb.Append("  VoucherPackageModeInfo: ").Append(VoucherPackageModeInfo).Append("\n");
            sb.Append("  VoucherSaleModeInfo: ").Append(VoucherSaleModeInfo).Append("\n");
            sb.Append("  VoucherSendMode: ").Append(VoucherSendMode).Append("\n");
            sb.Append("  VoucherSendRuleInfo: ").Append(VoucherSendRuleInfo).Append("\n");
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
            return this.Equals(input as VoucherSendModeInfo);
        }

        /// <summary>
        /// Returns true if VoucherSendModeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherSendModeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherSendModeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherPackageModeInfo == input.VoucherPackageModeInfo ||
                    (this.VoucherPackageModeInfo != null &&
                    this.VoucherPackageModeInfo.Equals(input.VoucherPackageModeInfo))
                ) && 
                (
                    this.VoucherSaleModeInfo == input.VoucherSaleModeInfo ||
                    (this.VoucherSaleModeInfo != null &&
                    this.VoucherSaleModeInfo.Equals(input.VoucherSaleModeInfo))
                ) && 
                (
                    this.VoucherSendMode == input.VoucherSendMode ||
                    (this.VoucherSendMode != null &&
                    this.VoucherSendMode.Equals(input.VoucherSendMode))
                ) && 
                (
                    this.VoucherSendRuleInfo == input.VoucherSendRuleInfo ||
                    (this.VoucherSendRuleInfo != null &&
                    this.VoucherSendRuleInfo.Equals(input.VoucherSendRuleInfo))
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
                if (this.VoucherPackageModeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherPackageModeInfo.GetHashCode();
                }
                if (this.VoucherSaleModeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSaleModeInfo.GetHashCode();
                }
                if (this.VoucherSendMode != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSendMode.GetHashCode();
                }
                if (this.VoucherSendRuleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSendRuleInfo.GetHashCode();
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
