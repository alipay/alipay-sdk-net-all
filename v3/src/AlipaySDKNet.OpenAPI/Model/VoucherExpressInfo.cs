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
    /// VoucherExpressInfo
    /// </summary>
    [DataContract(Name = "VoucherExpressInfo")]
    public partial class VoucherExpressInfo : IEquatable<VoucherExpressInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherExpressInfo" /> class.
        /// </summary>
        /// <param name="payExpress">邮费标识，属于券的服务，用于用户门槛信息展示.</param>
        public VoucherExpressInfo(string payExpress = default(string))
        {
            this.PayExpress = payExpress;
        }

        /// <summary>
        /// 邮费标识，属于券的服务，用于用户门槛信息展示
        /// </summary>
        /// <value>邮费标识，属于券的服务，用于用户门槛信息展示</value>
        [DataMember(Name = "pay_express", EmitDefaultValue = false)]
        public string PayExpress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherExpressInfo {\n");
            sb.Append("  PayExpress: ").Append(PayExpress).Append("\n");
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
            return this.Equals(input as VoucherExpressInfo);
        }

        /// <summary>
        /// Returns true if VoucherExpressInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherExpressInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherExpressInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PayExpress == input.PayExpress ||
                    (this.PayExpress != null &&
                    this.PayExpress.Equals(input.PayExpress))
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
                if (this.PayExpress != null)
                {
                    hashCode = (hashCode * 59) + this.PayExpress.GetHashCode();
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
