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
    /// PaidOuterCardSellingConfDTO
    /// </summary>
    [DataContract(Name = "PaidOuterCardSellingConfDTO")]
    public partial class PaidOuterCardSellingConfDTO : IEquatable<PaidOuterCardSellingConfDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaidOuterCardSellingConfDTO" /> class.
        /// </summary>
        /// <param name="endDate">售卖结束时间。 格式：yyyy-MM-dd HH:mm:ss 如果永久有效则不传。.</param>
        /// <param name="priceDetail">售卖方案列表.</param>
        /// <param name="sellingUrl">售卖地址.</param>
        /// <param name="startDate">售卖开始时间。格式：yyyy-MM-dd HH:mm:ss.</param>
        public PaidOuterCardSellingConfDTO(string endDate = default(string), List<PaidOuterCardPriceDetailDTO> priceDetail = default(List<PaidOuterCardPriceDetailDTO>), string sellingUrl = default(string), string startDate = default(string))
        {
            this.EndDate = endDate;
            this.PriceDetail = priceDetail;
            this.SellingUrl = sellingUrl;
            this.StartDate = startDate;
        }

        /// <summary>
        /// 售卖结束时间。 格式：yyyy-MM-dd HH:mm:ss 如果永久有效则不传。
        /// </summary>
        /// <value>售卖结束时间。 格式：yyyy-MM-dd HH:mm:ss 如果永久有效则不传。</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 售卖方案列表
        /// </summary>
        /// <value>售卖方案列表</value>
        [DataMember(Name = "price_detail", EmitDefaultValue = false)]
        public List<PaidOuterCardPriceDetailDTO> PriceDetail { get; set; }

        /// <summary>
        /// 售卖地址
        /// </summary>
        /// <value>售卖地址</value>
        [DataMember(Name = "selling_url", EmitDefaultValue = false)]
        public string SellingUrl { get; set; }

        /// <summary>
        /// 售卖开始时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>售卖开始时间。格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaidOuterCardSellingConfDTO {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PriceDetail: ").Append(PriceDetail).Append("\n");
            sb.Append("  SellingUrl: ").Append(SellingUrl).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as PaidOuterCardSellingConfDTO);
        }

        /// <summary>
        /// Returns true if PaidOuterCardSellingConfDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PaidOuterCardSellingConfDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaidOuterCardSellingConfDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.PriceDetail == input.PriceDetail ||
                    this.PriceDetail != null &&
                    input.PriceDetail != null &&
                    this.PriceDetail.SequenceEqual(input.PriceDetail)
                ) && 
                (
                    this.SellingUrl == input.SellingUrl ||
                    (this.SellingUrl != null &&
                    this.SellingUrl.Equals(input.SellingUrl))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.PriceDetail != null)
                {
                    hashCode = (hashCode * 59) + this.PriceDetail.GetHashCode();
                }
                if (this.SellingUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SellingUrl.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
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
