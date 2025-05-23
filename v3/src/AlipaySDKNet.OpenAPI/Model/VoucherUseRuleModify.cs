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
    /// VoucherUseRuleModify
    /// </summary>
    [DataContract(Name = "VoucherUseRuleModify")]
    public partial class VoucherUseRuleModify : IEquatable<VoucherUseRuleModify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherUseRuleModify" /> class.
        /// </summary>
        /// <param name="exchangeVoucher">exchangeVoucher.</param>
        /// <param name="voucherAvailableScope">voucherAvailableScope.</param>
        /// <param name="voucherValidPeriod">voucherValidPeriod.</param>
        public VoucherUseRuleModify(ExchangeVoucherModify exchangeVoucher = default(ExchangeVoucherModify), VoucherAvailableScopeModify voucherAvailableScope = default(VoucherAvailableScopeModify), VoucherValidPeriodModify voucherValidPeriod = default(VoucherValidPeriodModify))
        {
            this.ExchangeVoucher = exchangeVoucher;
            this.VoucherAvailableScope = voucherAvailableScope;
            this.VoucherValidPeriod = voucherValidPeriod;
        }

        /// <summary>
        /// Gets or Sets ExchangeVoucher
        /// </summary>
        [DataMember(Name = "exchange_voucher", EmitDefaultValue = false)]
        public ExchangeVoucherModify ExchangeVoucher { get; set; }

        /// <summary>
        /// Gets or Sets VoucherAvailableScope
        /// </summary>
        [DataMember(Name = "voucher_available_scope", EmitDefaultValue = false)]
        public VoucherAvailableScopeModify VoucherAvailableScope { get; set; }

        /// <summary>
        /// Gets or Sets VoucherValidPeriod
        /// </summary>
        [DataMember(Name = "voucher_valid_period", EmitDefaultValue = false)]
        public VoucherValidPeriodModify VoucherValidPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherUseRuleModify {\n");
            sb.Append("  ExchangeVoucher: ").Append(ExchangeVoucher).Append("\n");
            sb.Append("  VoucherAvailableScope: ").Append(VoucherAvailableScope).Append("\n");
            sb.Append("  VoucherValidPeriod: ").Append(VoucherValidPeriod).Append("\n");
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
            return this.Equals(input as VoucherUseRuleModify);
        }

        /// <summary>
        /// Returns true if VoucherUseRuleModify instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherUseRuleModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherUseRuleModify input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExchangeVoucher == input.ExchangeVoucher ||
                    (this.ExchangeVoucher != null &&
                    this.ExchangeVoucher.Equals(input.ExchangeVoucher))
                ) && 
                (
                    this.VoucherAvailableScope == input.VoucherAvailableScope ||
                    (this.VoucherAvailableScope != null &&
                    this.VoucherAvailableScope.Equals(input.VoucherAvailableScope))
                ) && 
                (
                    this.VoucherValidPeriod == input.VoucherValidPeriod ||
                    (this.VoucherValidPeriod != null &&
                    this.VoucherValidPeriod.Equals(input.VoucherValidPeriod))
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
                if (this.ExchangeVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeVoucher.GetHashCode();
                }
                if (this.VoucherAvailableScope != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherAvailableScope.GetHashCode();
                }
                if (this.VoucherValidPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherValidPeriod.GetHashCode();
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
