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
    /// TemplateBenefitInfoDTO
    /// </summary>
    [DataContract(Name = "TemplateBenefitInfoDTO")]
    public partial class TemplateBenefitInfoDTO : IEquatable<TemplateBenefitInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBenefitInfoDTO" /> class.
        /// </summary>
        /// <param name="benefitDesc">权益描述信息.</param>
        /// <param name="endDate">权益结束时间.</param>
        /// <param name="startDate">权益开始时间.</param>
        /// <param name="title">权益描述.</param>
        public TemplateBenefitInfoDTO(List<string> benefitDesc = default(List<string>), string endDate = default(string), string startDate = default(string), string title = default(string))
        {
            this.BenefitDesc = benefitDesc;
            this.EndDate = endDate;
            this.StartDate = startDate;
            this.Title = title;
        }

        /// <summary>
        /// 权益描述信息
        /// </summary>
        /// <value>权益描述信息</value>
        [DataMember(Name = "benefit_desc", EmitDefaultValue = false)]
        public List<string> BenefitDesc { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        /// <value>权益结束时间</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        /// <value>权益开始时间</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 权益描述
        /// </summary>
        /// <value>权益描述</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateBenefitInfoDTO {\n");
            sb.Append("  BenefitDesc: ").Append(BenefitDesc).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as TemplateBenefitInfoDTO);
        }

        /// <summary>
        /// Returns true if TemplateBenefitInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateBenefitInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateBenefitInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BenefitDesc == input.BenefitDesc ||
                    this.BenefitDesc != null &&
                    input.BenefitDesc != null &&
                    this.BenefitDesc.SequenceEqual(input.BenefitDesc)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
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
