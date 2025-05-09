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
    /// SearchPartAgreeInfo
    /// </summary>
    [DataContract(Name = "SearchPartAgreeInfo")]
    public partial class SearchPartAgreeInfo : IEquatable<SearchPartAgreeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPartAgreeInfo" /> class.
        /// </summary>
        /// <param name="auditInfo">剔除数据名称.</param>
        /// <param name="auditOperator">审核operator信息.</param>
        /// <param name="auditReason">审核原因.</param>
        /// <param name="auditType">剔除数据类型.</param>
        public SearchPartAgreeInfo(string auditInfo = default(string), string auditOperator = default(string), string auditReason = default(string), string auditType = default(string))
        {
            this.AuditInfo = auditInfo;
            this.AuditOperator = auditOperator;
            this.AuditReason = auditReason;
            this.AuditType = auditType;
        }

        /// <summary>
        /// 剔除数据名称
        /// </summary>
        /// <value>剔除数据名称</value>
        [DataMember(Name = "audit_info", EmitDefaultValue = false)]
        public string AuditInfo { get; set; }

        /// <summary>
        /// 审核operator信息
        /// </summary>
        /// <value>审核operator信息</value>
        [DataMember(Name = "audit_operator", EmitDefaultValue = false)]
        public string AuditOperator { get; set; }

        /// <summary>
        /// 审核原因
        /// </summary>
        /// <value>审核原因</value>
        [DataMember(Name = "audit_reason", EmitDefaultValue = false)]
        public string AuditReason { get; set; }

        /// <summary>
        /// 剔除数据类型
        /// </summary>
        /// <value>剔除数据类型</value>
        [DataMember(Name = "audit_type", EmitDefaultValue = false)]
        public string AuditType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchPartAgreeInfo {\n");
            sb.Append("  AuditInfo: ").Append(AuditInfo).Append("\n");
            sb.Append("  AuditOperator: ").Append(AuditOperator).Append("\n");
            sb.Append("  AuditReason: ").Append(AuditReason).Append("\n");
            sb.Append("  AuditType: ").Append(AuditType).Append("\n");
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
            return this.Equals(input as SearchPartAgreeInfo);
        }

        /// <summary>
        /// Returns true if SearchPartAgreeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchPartAgreeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchPartAgreeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuditInfo == input.AuditInfo ||
                    (this.AuditInfo != null &&
                    this.AuditInfo.Equals(input.AuditInfo))
                ) && 
                (
                    this.AuditOperator == input.AuditOperator ||
                    (this.AuditOperator != null &&
                    this.AuditOperator.Equals(input.AuditOperator))
                ) && 
                (
                    this.AuditReason == input.AuditReason ||
                    (this.AuditReason != null &&
                    this.AuditReason.Equals(input.AuditReason))
                ) && 
                (
                    this.AuditType == input.AuditType ||
                    (this.AuditType != null &&
                    this.AuditType.Equals(input.AuditType))
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
                if (this.AuditInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AuditInfo.GetHashCode();
                }
                if (this.AuditOperator != null)
                {
                    hashCode = (hashCode * 59) + this.AuditOperator.GetHashCode();
                }
                if (this.AuditReason != null)
                {
                    hashCode = (hashCode * 59) + this.AuditReason.GetHashCode();
                }
                if (this.AuditType != null)
                {
                    hashCode = (hashCode * 59) + this.AuditType.GetHashCode();
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
