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
    /// AlipayEbppInvoiceInstitutionModifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceInstitutionModifyResponseModel")]
    public partial class AlipayEbppInvoiceInstitutionModifyResponseModel : IEquatable<AlipayEbppInvoiceInstitutionModifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionModifyResponseModel" /> class.
        /// </summary>
        /// <param name="issueRuleIdInfoList">新增发放规则时返回外部幂等id和发放规则id的映射关系.</param>
        /// <param name="result">修改是否成功.</param>
        /// <param name="standardIdInfoList">新增使用规则后会返回外部幂等id和使用规则id的映射关系.</param>
        public AlipayEbppInvoiceInstitutionModifyResponseModel(List<IssueRuleIdInfo> issueRuleIdInfoList = default(List<IssueRuleIdInfo>), bool result = default(bool), List<StandardIdInfo> standardIdInfoList = default(List<StandardIdInfo>))
        {
            this.IssueRuleIdInfoList = issueRuleIdInfoList;
            this.Result = result;
            this.StandardIdInfoList = standardIdInfoList;
        }

        /// <summary>
        /// 新增发放规则时返回外部幂等id和发放规则id的映射关系
        /// </summary>
        /// <value>新增发放规则时返回外部幂等id和发放规则id的映射关系</value>
        [DataMember(Name = "issue_rule_id_info_list", EmitDefaultValue = false)]
        public List<IssueRuleIdInfo> IssueRuleIdInfoList { get; set; }

        /// <summary>
        /// 修改是否成功
        /// </summary>
        /// <value>修改是否成功</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public bool Result { get; set; }

        /// <summary>
        /// 新增使用规则后会返回外部幂等id和使用规则id的映射关系
        /// </summary>
        /// <value>新增使用规则后会返回外部幂等id和使用规则id的映射关系</value>
        [DataMember(Name = "standard_id_info_list", EmitDefaultValue = false)]
        public List<StandardIdInfo> StandardIdInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceInstitutionModifyResponseModel {\n");
            sb.Append("  IssueRuleIdInfoList: ").Append(IssueRuleIdInfoList).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  StandardIdInfoList: ").Append(StandardIdInfoList).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceInstitutionModifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceInstitutionModifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceInstitutionModifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceInstitutionModifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IssueRuleIdInfoList == input.IssueRuleIdInfoList ||
                    this.IssueRuleIdInfoList != null &&
                    input.IssueRuleIdInfoList != null &&
                    this.IssueRuleIdInfoList.SequenceEqual(input.IssueRuleIdInfoList)
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.StandardIdInfoList == input.StandardIdInfoList ||
                    this.StandardIdInfoList != null &&
                    input.StandardIdInfoList != null &&
                    this.StandardIdInfoList.SequenceEqual(input.StandardIdInfoList)
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
                if (this.IssueRuleIdInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleIdInfoList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Result.GetHashCode();
                if (this.StandardIdInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardIdInfoList.GetHashCode();
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
