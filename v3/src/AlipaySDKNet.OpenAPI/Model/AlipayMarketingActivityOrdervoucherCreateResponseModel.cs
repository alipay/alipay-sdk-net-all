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
    /// AlipayMarketingActivityOrdervoucherCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityOrdervoucherCreateResponseModel")]
    public partial class AlipayMarketingActivityOrdervoucherCreateResponseModel : IEquatable<AlipayMarketingActivityOrdervoucherCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityOrdervoucherCreateResponseModel" /> class.
        /// </summary>
        /// <param name="activityId">活动id.</param>
        /// <param name="voucherAvailableScopeResultInfo">voucherAvailableScopeResultInfo.</param>
        /// <param name="voucherUseRuleResult">voucherUseRuleResult.</param>
        public AlipayMarketingActivityOrdervoucherCreateResponseModel(string activityId = default(string), VoucherAvailableScopeResultInfo voucherAvailableScopeResultInfo = default(VoucherAvailableScopeResultInfo), OrderVoucherUseRuleResult voucherUseRuleResult = default(OrderVoucherUseRuleResult))
        {
            this.ActivityId = activityId;
            this.VoucherAvailableScopeResultInfo = voucherAvailableScopeResultInfo;
            this.VoucherUseRuleResult = voucherUseRuleResult;
        }

        /// <summary>
        /// 活动id
        /// </summary>
        /// <value>活动id</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Gets or Sets VoucherAvailableScopeResultInfo
        /// </summary>
        [DataMember(Name = "voucher_available_scope_result_info", EmitDefaultValue = false)]
        public VoucherAvailableScopeResultInfo VoucherAvailableScopeResultInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseRuleResult
        /// </summary>
        [DataMember(Name = "voucher_use_rule_result", EmitDefaultValue = false)]
        public OrderVoucherUseRuleResult VoucherUseRuleResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityOrdervoucherCreateResponseModel {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  VoucherAvailableScopeResultInfo: ").Append(VoucherAvailableScopeResultInfo).Append("\n");
            sb.Append("  VoucherUseRuleResult: ").Append(VoucherUseRuleResult).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityOrdervoucherCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityOrdervoucherCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityOrdervoucherCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityOrdervoucherCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.VoucherAvailableScopeResultInfo == input.VoucherAvailableScopeResultInfo ||
                    (this.VoucherAvailableScopeResultInfo != null &&
                    this.VoucherAvailableScopeResultInfo.Equals(input.VoucherAvailableScopeResultInfo))
                ) && 
                (
                    this.VoucherUseRuleResult == input.VoucherUseRuleResult ||
                    (this.VoucherUseRuleResult != null &&
                    this.VoucherUseRuleResult.Equals(input.VoucherUseRuleResult))
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
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
                }
                if (this.VoucherAvailableScopeResultInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherAvailableScopeResultInfo.GetHashCode();
                }
                if (this.VoucherUseRuleResult != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseRuleResult.GetHashCode();
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
