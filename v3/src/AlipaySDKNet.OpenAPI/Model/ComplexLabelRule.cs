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
    /// ComplexLabelRule
    /// </summary>
    [DataContract(Name = "ComplexLabelRule")]
    public partial class ComplexLabelRule : IEquatable<ComplexLabelRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexLabelRule" /> class.
        /// </summary>
        /// <param name="labelId">标签id.</param>
        /// <param name="labelValue">标签取值，当有多个取值时用英文\&quot;,\&quot;分隔（比如使用in操作符时）；不允许传入下划线\&quot;_\&quot;、竖线\&quot;|\&quot;或者空格\&quot; \&quot;.</param>
        /// <param name="_operator">目前支持EQ（等于）、NEQ（不等于）、LT（小于），GT（大于）、LTEQ（小于等于）、GTEQ（大于等于）、LIKE（匹配）、BETWEEN（范围）、IN（包含）、NOTIN（不包含）操作.</param>
        public ComplexLabelRule(string labelId = default(string), string labelValue = default(string), string _operator = default(string))
        {
            this.LabelId = labelId;
            this.LabelValue = labelValue;
            this.Operator = _operator;
        }

        /// <summary>
        /// 标签id
        /// </summary>
        /// <value>标签id</value>
        [DataMember(Name = "label_id", EmitDefaultValue = false)]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签取值，当有多个取值时用英文\&quot;,\&quot;分隔（比如使用in操作符时）；不允许传入下划线\&quot;_\&quot;、竖线\&quot;|\&quot;或者空格\&quot; \&quot;
        /// </summary>
        /// <value>标签取值，当有多个取值时用英文\&quot;,\&quot;分隔（比如使用in操作符时）；不允许传入下划线\&quot;_\&quot;、竖线\&quot;|\&quot;或者空格\&quot; \&quot;</value>
        [DataMember(Name = "label_value", EmitDefaultValue = false)]
        public string LabelValue { get; set; }

        /// <summary>
        /// 目前支持EQ（等于）、NEQ（不等于）、LT（小于），GT（大于）、LTEQ（小于等于）、GTEQ（大于等于）、LIKE（匹配）、BETWEEN（范围）、IN（包含）、NOTIN（不包含）操作
        /// </summary>
        /// <value>目前支持EQ（等于）、NEQ（不等于）、LT（小于），GT（大于）、LTEQ（小于等于）、GTEQ（大于等于）、LIKE（匹配）、BETWEEN（范围）、IN（包含）、NOTIN（不包含）操作</value>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public string Operator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComplexLabelRule {\n");
            sb.Append("  LabelId: ").Append(LabelId).Append("\n");
            sb.Append("  LabelValue: ").Append(LabelValue).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(input as ComplexLabelRule);
        }

        /// <summary>
        /// Returns true if ComplexLabelRule instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplexLabelRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplexLabelRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LabelId == input.LabelId ||
                    (this.LabelId != null &&
                    this.LabelId.Equals(input.LabelId))
                ) && 
                (
                    this.LabelValue == input.LabelValue ||
                    (this.LabelValue != null &&
                    this.LabelValue.Equals(input.LabelValue))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
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
                if (this.LabelId != null)
                {
                    hashCode = (hashCode * 59) + this.LabelId.GetHashCode();
                }
                if (this.LabelValue != null)
                {
                    hashCode = (hashCode * 59) + this.LabelValue.GetHashCode();
                }
                if (this.Operator != null)
                {
                    hashCode = (hashCode * 59) + this.Operator.GetHashCode();
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
