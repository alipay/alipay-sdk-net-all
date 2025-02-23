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
    /// MerchantMenber
    /// </summary>
    [DataContract(Name = "MerchantMenber")]
    public partial class MerchantMenber : IEquatable<MerchantMenber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantMenber" /> class.
        /// </summary>
        /// <param name="birth">生日 yyyy-MM-dd.</param>
        /// <param name="cell">手机号.</param>
        /// <param name="gende">性别.</param>
        /// <param name="name">姓名.</param>
        public MerchantMenber(string birth = default(string), string cell = default(string), string gende = default(string), string name = default(string))
        {
            this.Birth = birth;
            this.Cell = cell;
            this.Gende = gende;
            this.Name = name;
        }

        /// <summary>
        /// 生日 yyyy-MM-dd
        /// </summary>
        /// <value>生日 yyyy-MM-dd</value>
        [DataMember(Name = "birth", EmitDefaultValue = false)]
        public string Birth { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value>手机号</value>
        [DataMember(Name = "cell", EmitDefaultValue = false)]
        public string Cell { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        /// <value>性别</value>
        [DataMember(Name = "gende", EmitDefaultValue = false)]
        public string Gende { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        /// <value>姓名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantMenber {\n");
            sb.Append("  Birth: ").Append(Birth).Append("\n");
            sb.Append("  Cell: ").Append(Cell).Append("\n");
            sb.Append("  Gende: ").Append(Gende).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as MerchantMenber);
        }

        /// <summary>
        /// Returns true if MerchantMenber instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantMenber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantMenber input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Birth == input.Birth ||
                    (this.Birth != null &&
                    this.Birth.Equals(input.Birth))
                ) && 
                (
                    this.Cell == input.Cell ||
                    (this.Cell != null &&
                    this.Cell.Equals(input.Cell))
                ) && 
                (
                    this.Gende == input.Gende ||
                    (this.Gende != null &&
                    this.Gende.Equals(input.Gende))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Birth != null)
                {
                    hashCode = (hashCode * 59) + this.Birth.GetHashCode();
                }
                if (this.Cell != null)
                {
                    hashCode = (hashCode * 59) + this.Cell.GetHashCode();
                }
                if (this.Gende != null)
                {
                    hashCode = (hashCode * 59) + this.Gende.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
