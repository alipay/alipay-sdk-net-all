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
    /// Keyword
    /// </summary>
    [DataContract(Name = "Keyword")]
    public partial class Keyword : IEquatable<Keyword>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Keyword" /> class.
        /// </summary>
        /// <param name="color">当前文字颜色.</param>
        /// <param name="value">模板中占位符的值.</param>
        public Keyword(string color = default(string), string value = default(string))
        {
            this.Color = color;
            this.Value = value;
        }

        /// <summary>
        /// 当前文字颜色
        /// </summary>
        /// <value>当前文字颜色</value>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// 模板中占位符的值
        /// </summary>
        /// <value>模板中占位符的值</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Keyword {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Keyword);
        }

        /// <summary>
        /// Returns true if Keyword instances are equal
        /// </summary>
        /// <param name="input">Instance of Keyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Keyword input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
