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
    /// OrderVoucherUseRuleResult
    /// </summary>
    [DataContract(Name = "OrderVoucherUseRuleResult")]
    public partial class OrderVoucherUseRuleResult : IEquatable<OrderVoucherUseRuleResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderVoucherUseRuleResult" /> class.
        /// </summary>
        /// <param name="voucherAvailableScopeResult">voucherAvailableScopeResult.</param>
        public OrderVoucherUseRuleResult(OrderVoucherAvailableScopeResult voucherAvailableScopeResult = default(OrderVoucherAvailableScopeResult))
        {
            this.VoucherAvailableScopeResult = voucherAvailableScopeResult;
        }

        /// <summary>
        /// Gets or Sets VoucherAvailableScopeResult
        /// </summary>
        [DataMember(Name = "voucher_available_scope_result", EmitDefaultValue = false)]
        public OrderVoucherAvailableScopeResult VoucherAvailableScopeResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderVoucherUseRuleResult {\n");
            sb.Append("  VoucherAvailableScopeResult: ").Append(VoucherAvailableScopeResult).Append("\n");
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
            return this.Equals(input as OrderVoucherUseRuleResult);
        }

        /// <summary>
        /// Returns true if OrderVoucherUseRuleResult instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderVoucherUseRuleResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderVoucherUseRuleResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherAvailableScopeResult == input.VoucherAvailableScopeResult ||
                    (this.VoucherAvailableScopeResult != null &&
                    this.VoucherAvailableScopeResult.Equals(input.VoucherAvailableScopeResult))
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
                if (this.VoucherAvailableScopeResult != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherAvailableScopeResult.GetHashCode();
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
