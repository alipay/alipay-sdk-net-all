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
    /// ModifyIssueRuleInfo
    /// </summary>
    [DataContract(Name = "ModifyIssueRuleInfo")]
    public partial class ModifyIssueRuleInfo : IEquatable<ModifyIssueRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyIssueRuleInfo" /> class.
        /// </summary>
        /// <param name="effectivePeriod">发放资产的有效时间段，该字段为空时，默认为不限制。当发放资产为余额时，仅支持设置为不限，当发放资产为点券时，可支持设置多种值。具体传值格式请参考文档 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/07nwcs\&quot;&gt;接入文档&lt;/a&gt;.</param>
        /// <param name="issueRuleId">发放规则id.</param>
        /// <param name="issueRuleName">发放规则名称.</param>
        /// <param name="issueType">额度发放周期.</param>
        /// <param name="quotaType">发放规则发放的额度类型.</param>
        public ModifyIssueRuleInfo(string effectivePeriod = default(string), string issueRuleId = default(string), string issueRuleName = default(string), string issueType = default(string), string quotaType = default(string))
        {
            this.EffectivePeriod = effectivePeriod;
            this.IssueRuleId = issueRuleId;
            this.IssueRuleName = issueRuleName;
            this.IssueType = issueType;
            this.QuotaType = quotaType;
        }

        /// <summary>
        /// 发放资产的有效时间段，该字段为空时，默认为不限制。当发放资产为余额时，仅支持设置为不限，当发放资产为点券时，可支持设置多种值。具体传值格式请参考文档 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/07nwcs\&quot;&gt;接入文档&lt;/a&gt;
        /// </summary>
        /// <value>发放资产的有效时间段，该字段为空时，默认为不限制。当发放资产为余额时，仅支持设置为不限，当发放资产为点券时，可支持设置多种值。具体传值格式请参考文档 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/07nwcs\&quot;&gt;接入文档&lt;/a&gt;</value>
        [DataMember(Name = "effective_period", EmitDefaultValue = false)]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 发放规则id
        /// </summary>
        /// <value>发放规则id</value>
        [DataMember(Name = "issue_rule_id", EmitDefaultValue = false)]
        public string IssueRuleId { get; set; }

        /// <summary>
        /// 发放规则名称
        /// </summary>
        /// <value>发放规则名称</value>
        [DataMember(Name = "issue_rule_name", EmitDefaultValue = false)]
        public string IssueRuleName { get; set; }

        /// <summary>
        /// 额度发放周期
        /// </summary>
        /// <value>额度发放周期</value>
        [DataMember(Name = "issue_type", EmitDefaultValue = false)]
        public string IssueType { get; set; }

        /// <summary>
        /// 发放规则发放的额度类型
        /// </summary>
        /// <value>发放规则发放的额度类型</value>
        [DataMember(Name = "quota_type", EmitDefaultValue = false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifyIssueRuleInfo {\n");
            sb.Append("  EffectivePeriod: ").Append(EffectivePeriod).Append("\n");
            sb.Append("  IssueRuleId: ").Append(IssueRuleId).Append("\n");
            sb.Append("  IssueRuleName: ").Append(IssueRuleName).Append("\n");
            sb.Append("  IssueType: ").Append(IssueType).Append("\n");
            sb.Append("  QuotaType: ").Append(QuotaType).Append("\n");
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
            return this.Equals(input as ModifyIssueRuleInfo);
        }

        /// <summary>
        /// Returns true if ModifyIssueRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyIssueRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyIssueRuleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EffectivePeriod == input.EffectivePeriod ||
                    (this.EffectivePeriod != null &&
                    this.EffectivePeriod.Equals(input.EffectivePeriod))
                ) && 
                (
                    this.IssueRuleId == input.IssueRuleId ||
                    (this.IssueRuleId != null &&
                    this.IssueRuleId.Equals(input.IssueRuleId))
                ) && 
                (
                    this.IssueRuleName == input.IssueRuleName ||
                    (this.IssueRuleName != null &&
                    this.IssueRuleName.Equals(input.IssueRuleName))
                ) && 
                (
                    this.IssueType == input.IssueType ||
                    (this.IssueType != null &&
                    this.IssueType.Equals(input.IssueType))
                ) && 
                (
                    this.QuotaType == input.QuotaType ||
                    (this.QuotaType != null &&
                    this.QuotaType.Equals(input.QuotaType))
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
                if (this.EffectivePeriod != null)
                {
                    hashCode = (hashCode * 59) + this.EffectivePeriod.GetHashCode();
                }
                if (this.IssueRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleId.GetHashCode();
                }
                if (this.IssueRuleName != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleName.GetHashCode();
                }
                if (this.IssueType != null)
                {
                    hashCode = (hashCode * 59) + this.IssueType.GetHashCode();
                }
                if (this.QuotaType != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaType.GetHashCode();
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
