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
    /// AlipayMarketingActivityOrdervoucherAssociateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityOrdervoucherAssociateResponseModel")]
    public partial class AlipayMarketingActivityOrdervoucherAssociateResponseModel : IEquatable<AlipayMarketingActivityOrdervoucherAssociateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityOrdervoucherAssociateResponseModel" /> class.
        /// </summary>
        /// <param name="associateTime">支付宝系统关联订单成功的时间。 格式为：yyyy-MM-dd HH:mm:ss.</param>
        public AlipayMarketingActivityOrdervoucherAssociateResponseModel(string associateTime = default(string))
        {
            this.AssociateTime = associateTime;
        }

        /// <summary>
        /// 支付宝系统关联订单成功的时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>支付宝系统关联订单成功的时间。 格式为：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "associate_time", EmitDefaultValue = false)]
        public string AssociateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityOrdervoucherAssociateResponseModel {\n");
            sb.Append("  AssociateTime: ").Append(AssociateTime).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityOrdervoucherAssociateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityOrdervoucherAssociateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityOrdervoucherAssociateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityOrdervoucherAssociateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssociateTime == input.AssociateTime ||
                    (this.AssociateTime != null &&
                    this.AssociateTime.Equals(input.AssociateTime))
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
                if (this.AssociateTime != null)
                {
                    hashCode = (hashCode * 59) + this.AssociateTime.GetHashCode();
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
