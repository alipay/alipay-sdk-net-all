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
    /// MccQueryInfo
    /// </summary>
    [DataContract(Name = "MccQueryInfo")]
    public partial class MccQueryInfo : IEquatable<MccQueryInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MccQueryInfo" /> class.
        /// </summary>
        /// <param name="isSpecial">是否特殊行业.</param>
        /// <param name="mccLevel1">一级类目code.</param>
        /// <param name="mccLevel1Name">商户一级类目名称.</param>
        /// <param name="mccLevel2">二级类目code.</param>
        /// <param name="mccLevel2Name">二级类目名称.</param>
        /// <param name="mccRequirements">特殊行业需要上传的资质.</param>
        /// <param name="specialQualRequired">是否需要特殊资质.</param>
        public MccQueryInfo(bool isSpecial = default(bool), string mccLevel1 = default(string), string mccLevel1Name = default(string), string mccLevel2 = default(string), string mccLevel2Name = default(string), string mccRequirements = default(string), bool specialQualRequired = default(bool))
        {
            this.IsSpecial = isSpecial;
            this.MccLevel1 = mccLevel1;
            this.MccLevel1Name = mccLevel1Name;
            this.MccLevel2 = mccLevel2;
            this.MccLevel2Name = mccLevel2Name;
            this.MccRequirements = mccRequirements;
            this.SpecialQualRequired = specialQualRequired;
        }

        /// <summary>
        /// 是否特殊行业
        /// </summary>
        /// <value>是否特殊行业</value>
        [DataMember(Name = "is_special", EmitDefaultValue = true)]
        public bool IsSpecial { get; set; }

        /// <summary>
        /// 一级类目code
        /// </summary>
        /// <value>一级类目code</value>
        [DataMember(Name = "mcc_level_1", EmitDefaultValue = false)]
        public string MccLevel1 { get; set; }

        /// <summary>
        /// 商户一级类目名称
        /// </summary>
        /// <value>商户一级类目名称</value>
        [DataMember(Name = "mcc_level_1_name", EmitDefaultValue = false)]
        public string MccLevel1Name { get; set; }

        /// <summary>
        /// 二级类目code
        /// </summary>
        /// <value>二级类目code</value>
        [DataMember(Name = "mcc_level_2", EmitDefaultValue = false)]
        public string MccLevel2 { get; set; }

        /// <summary>
        /// 二级类目名称
        /// </summary>
        /// <value>二级类目名称</value>
        [DataMember(Name = "mcc_level_2_name", EmitDefaultValue = false)]
        public string MccLevel2Name { get; set; }

        /// <summary>
        /// 特殊行业需要上传的资质
        /// </summary>
        /// <value>特殊行业需要上传的资质</value>
        [DataMember(Name = "mcc_requirements", EmitDefaultValue = false)]
        public string MccRequirements { get; set; }

        /// <summary>
        /// 是否需要特殊资质
        /// </summary>
        /// <value>是否需要特殊资质</value>
        [DataMember(Name = "special_qual_required", EmitDefaultValue = true)]
        public bool SpecialQualRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MccQueryInfo {\n");
            sb.Append("  IsSpecial: ").Append(IsSpecial).Append("\n");
            sb.Append("  MccLevel1: ").Append(MccLevel1).Append("\n");
            sb.Append("  MccLevel1Name: ").Append(MccLevel1Name).Append("\n");
            sb.Append("  MccLevel2: ").Append(MccLevel2).Append("\n");
            sb.Append("  MccLevel2Name: ").Append(MccLevel2Name).Append("\n");
            sb.Append("  MccRequirements: ").Append(MccRequirements).Append("\n");
            sb.Append("  SpecialQualRequired: ").Append(SpecialQualRequired).Append("\n");
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
            return this.Equals(input as MccQueryInfo);
        }

        /// <summary>
        /// Returns true if MccQueryInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MccQueryInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MccQueryInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsSpecial == input.IsSpecial ||
                    this.IsSpecial.Equals(input.IsSpecial)
                ) && 
                (
                    this.MccLevel1 == input.MccLevel1 ||
                    (this.MccLevel1 != null &&
                    this.MccLevel1.Equals(input.MccLevel1))
                ) && 
                (
                    this.MccLevel1Name == input.MccLevel1Name ||
                    (this.MccLevel1Name != null &&
                    this.MccLevel1Name.Equals(input.MccLevel1Name))
                ) && 
                (
                    this.MccLevel2 == input.MccLevel2 ||
                    (this.MccLevel2 != null &&
                    this.MccLevel2.Equals(input.MccLevel2))
                ) && 
                (
                    this.MccLevel2Name == input.MccLevel2Name ||
                    (this.MccLevel2Name != null &&
                    this.MccLevel2Name.Equals(input.MccLevel2Name))
                ) && 
                (
                    this.MccRequirements == input.MccRequirements ||
                    (this.MccRequirements != null &&
                    this.MccRequirements.Equals(input.MccRequirements))
                ) && 
                (
                    this.SpecialQualRequired == input.SpecialQualRequired ||
                    this.SpecialQualRequired.Equals(input.SpecialQualRequired)
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
                hashCode = (hashCode * 59) + this.IsSpecial.GetHashCode();
                if (this.MccLevel1 != null)
                {
                    hashCode = (hashCode * 59) + this.MccLevel1.GetHashCode();
                }
                if (this.MccLevel1Name != null)
                {
                    hashCode = (hashCode * 59) + this.MccLevel1Name.GetHashCode();
                }
                if (this.MccLevel2 != null)
                {
                    hashCode = (hashCode * 59) + this.MccLevel2.GetHashCode();
                }
                if (this.MccLevel2Name != null)
                {
                    hashCode = (hashCode * 59) + this.MccLevel2Name.GetHashCode();
                }
                if (this.MccRequirements != null)
                {
                    hashCode = (hashCode * 59) + this.MccRequirements.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SpecialQualRequired.GetHashCode();
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
