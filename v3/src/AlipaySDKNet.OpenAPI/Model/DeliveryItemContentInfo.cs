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
    /// DeliveryItemContentInfo
    /// </summary>
    [DataContract(Name = "DeliveryItemContentInfo")]
    public partial class DeliveryItemContentInfo : IEquatable<DeliveryItemContentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryItemContentInfo" /> class.
        /// </summary>
        /// <param name="itemId">支付宝侧商品id。 注意事项：支持状态为“出售中”的商品.</param>
        /// <param name="itemType">商品模版类型.</param>
        public DeliveryItemContentInfo(string itemId = default(string), string itemType = default(string))
        {
            this.ItemId = itemId;
            this.ItemType = itemType;
        }

        /// <summary>
        /// 支付宝侧商品id。 注意事项：支持状态为“出售中”的商品
        /// </summary>
        /// <value>支付宝侧商品id。 注意事项：支持状态为“出售中”的商品</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品模版类型
        /// </summary>
        /// <value>商品模版类型</value>
        [DataMember(Name = "item_type", EmitDefaultValue = false)]
        public string ItemType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryItemContentInfo {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
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
            return this.Equals(input as DeliveryItemContentInfo);
        }

        /// <summary>
        /// Returns true if DeliveryItemContentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryItemContentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryItemContentInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemType == input.ItemType ||
                    (this.ItemType != null &&
                    this.ItemType.Equals(input.ItemType))
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
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                if (this.ItemType != null)
                {
                    hashCode = (hashCode * 59) + this.ItemType.GetHashCode();
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
