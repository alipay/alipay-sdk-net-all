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
    /// McardTemplateBenefitQuery
    /// </summary>
    [DataContract(Name = "McardTemplateBenefitQuery")]
    public partial class McardTemplateBenefitQuery : IEquatable<McardTemplateBenefitQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="McardTemplateBenefitQuery" /> class.
        /// </summary>
        /// <param name="benefitDesc">权益描述信息.</param>
        /// <param name="benefitId">权益ID.</param>
        /// <param name="endDate">权益结束时间.</param>
        /// <param name="extInfo">会员卡模板权益扩展信息：JSON格式; openUrl 说明：跳转到商户的优惠活动页面.</param>
        /// <param name="startDate">权益开始时间.</param>
        /// <param name="templateId">会员卡模板ID.</param>
        /// <param name="title">权益标题.</param>
        public McardTemplateBenefitQuery(string benefitDesc = default(string), string benefitId = default(string), string endDate = default(string), string extInfo = default(string), string startDate = default(string), string templateId = default(string), string title = default(string))
        {
            this.BenefitDesc = benefitDesc;
            this.BenefitId = benefitId;
            this.EndDate = endDate;
            this.ExtInfo = extInfo;
            this.StartDate = startDate;
            this.TemplateId = templateId;
            this.Title = title;
        }

        /// <summary>
        /// 权益描述信息
        /// </summary>
        /// <value>权益描述信息</value>
        [DataMember(Name = "benefit_desc", EmitDefaultValue = false)]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 权益ID
        /// </summary>
        /// <value>权益ID</value>
        [DataMember(Name = "benefit_id", EmitDefaultValue = false)]
        public string BenefitId { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        /// <value>权益结束时间</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 会员卡模板权益扩展信息：JSON格式; openUrl 说明：跳转到商户的优惠活动页面
        /// </summary>
        /// <value>会员卡模板权益扩展信息：JSON格式; openUrl 说明：跳转到商户的优惠活动页面</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        /// <value>权益开始时间</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 会员卡模板ID
        /// </summary>
        /// <value>会员卡模板ID</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 权益标题
        /// </summary>
        /// <value>权益标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class McardTemplateBenefitQuery {\n");
            sb.Append("  BenefitDesc: ").Append(BenefitDesc).Append("\n");
            sb.Append("  BenefitId: ").Append(BenefitId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as McardTemplateBenefitQuery);
        }

        /// <summary>
        /// Returns true if McardTemplateBenefitQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of McardTemplateBenefitQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(McardTemplateBenefitQuery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BenefitDesc == input.BenefitDesc ||
                    (this.BenefitDesc != null &&
                    this.BenefitDesc.Equals(input.BenefitDesc))
                ) && 
                (
                    this.BenefitId == input.BenefitId ||
                    (this.BenefitId != null &&
                    this.BenefitId.Equals(input.BenefitId))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.BenefitDesc != null)
                {
                    hashCode = (hashCode * 59) + this.BenefitDesc.GetHashCode();
                }
                if (this.BenefitId != null)
                {
                    hashCode = (hashCode * 59) + this.BenefitId.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
