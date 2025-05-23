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
    /// JinyouTestFour
    /// </summary>
    [DataContract(Name = "JinyouTestFour")]
    public partial class JinyouTestFour : IEquatable<JinyouTestFour>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JinyouTestFour" /> class.
        /// </summary>
        /// <param name="f1Openid">1.</param>
        /// <param name="f1Y">1.</param>
        /// <param name="f2F">f2F.</param>
        /// <param name="f3Openid">1.</param>
        /// <param name="f3Y">1.</param>
        public JinyouTestFour(string f1Openid = default(string), string f1Y = default(string), JinyouTestThree f2F = default(JinyouTestThree), string f3Openid = default(string), int f3Y = default(int))
        {
            this.F1Openid = f1Openid;
            this.F1Y = f1Y;
            this.F2F = f2F;
            this.F3Openid = f3Openid;
            this.F3Y = f3Y;
        }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "f_1_openid", EmitDefaultValue = false)]
        public string F1Openid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "f_1_y", EmitDefaultValue = false)]
        public string F1Y { get; set; }

        /// <summary>
        /// Gets or Sets F2F
        /// </summary>
        [DataMember(Name = "f_2_f", EmitDefaultValue = false)]
        public JinyouTestThree F2F { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "f_3_openid", EmitDefaultValue = false)]
        public string F3Openid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "f_3_y", EmitDefaultValue = false)]
        public int F3Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JinyouTestFour {\n");
            sb.Append("  F1Openid: ").Append(F1Openid).Append("\n");
            sb.Append("  F1Y: ").Append(F1Y).Append("\n");
            sb.Append("  F2F: ").Append(F2F).Append("\n");
            sb.Append("  F3Openid: ").Append(F3Openid).Append("\n");
            sb.Append("  F3Y: ").Append(F3Y).Append("\n");
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
            return this.Equals(input as JinyouTestFour);
        }

        /// <summary>
        /// Returns true if JinyouTestFour instances are equal
        /// </summary>
        /// <param name="input">Instance of JinyouTestFour to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JinyouTestFour input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.F1Openid == input.F1Openid ||
                    (this.F1Openid != null &&
                    this.F1Openid.Equals(input.F1Openid))
                ) && 
                (
                    this.F1Y == input.F1Y ||
                    (this.F1Y != null &&
                    this.F1Y.Equals(input.F1Y))
                ) && 
                (
                    this.F2F == input.F2F ||
                    (this.F2F != null &&
                    this.F2F.Equals(input.F2F))
                ) && 
                (
                    this.F3Openid == input.F3Openid ||
                    (this.F3Openid != null &&
                    this.F3Openid.Equals(input.F3Openid))
                ) && 
                (
                    this.F3Y == input.F3Y ||
                    this.F3Y.Equals(input.F3Y)
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
                if (this.F1Openid != null)
                {
                    hashCode = (hashCode * 59) + this.F1Openid.GetHashCode();
                }
                if (this.F1Y != null)
                {
                    hashCode = (hashCode * 59) + this.F1Y.GetHashCode();
                }
                if (this.F2F != null)
                {
                    hashCode = (hashCode * 59) + this.F2F.GetHashCode();
                }
                if (this.F3Openid != null)
                {
                    hashCode = (hashCode * 59) + this.F3Openid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.F3Y.GetHashCode();
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
