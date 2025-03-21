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
    /// EnterpriseAgreementDTO
    /// </summary>
    [DataContract(Name = "EnterpriseAgreementDTO")]
    public partial class EnterpriseAgreementDTO : IEquatable<EnterpriseAgreementDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseAgreementDTO" /> class.
        /// </summary>
        /// <param name="agreementId">协议id.</param>
        /// <param name="enterpriseId">企业id.</param>
        /// <param name="enterpriseName">企业名称.</param>
        /// <param name="signDate">签约时间.</param>
        /// <param name="signStatus">签约状态.</param>
        public EnterpriseAgreementDTO(string agreementId = default(string), string enterpriseId = default(string), string enterpriseName = default(string), string signDate = default(string), string signStatus = default(string))
        {
            this.AgreementId = agreementId;
            this.EnterpriseId = enterpriseId;
            this.EnterpriseName = enterpriseName;
            this.SignDate = signDate;
            this.SignStatus = signStatus;
        }

        /// <summary>
        /// 协议id
        /// </summary>
        /// <value>协议id</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        /// <value>企业名称</value>
        [DataMember(Name = "enterprise_name", EmitDefaultValue = false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        /// <value>签约时间</value>
        [DataMember(Name = "sign_date", EmitDefaultValue = false)]
        public string SignDate { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        /// <value>签约状态</value>
        [DataMember(Name = "sign_status", EmitDefaultValue = false)]
        public string SignStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnterpriseAgreementDTO {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  EnterpriseName: ").Append(EnterpriseName).Append("\n");
            sb.Append("  SignDate: ").Append(SignDate).Append("\n");
            sb.Append("  SignStatus: ").Append(SignStatus).Append("\n");
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
            return this.Equals(input as EnterpriseAgreementDTO);
        }

        /// <summary>
        /// Returns true if EnterpriseAgreementDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EnterpriseAgreementDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnterpriseAgreementDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.EnterpriseName == input.EnterpriseName ||
                    (this.EnterpriseName != null &&
                    this.EnterpriseName.Equals(input.EnterpriseName))
                ) && 
                (
                    this.SignDate == input.SignDate ||
                    (this.SignDate != null &&
                    this.SignDate.Equals(input.SignDate))
                ) && 
                (
                    this.SignStatus == input.SignStatus ||
                    (this.SignStatus != null &&
                    this.SignStatus.Equals(input.SignStatus))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.EnterpriseName != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseName.GetHashCode();
                }
                if (this.SignDate != null)
                {
                    hashCode = (hashCode * 59) + this.SignDate.GetHashCode();
                }
                if (this.SignStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SignStatus.GetHashCode();
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
