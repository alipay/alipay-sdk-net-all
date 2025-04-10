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
    /// ItemConsultRequest
    /// </summary>
    [DataContract(Name = "ItemConsultRequest")]
    public partial class ItemConsultRequest : IEquatable<ItemConsultRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemConsultRequest" /> class.
        /// </summary>
        /// <param name="itemId">商品id.</param>
        /// <param name="price">商品单价，单位为元，最多2位小数.</param>
        /// <param name="quantity">商品数量.</param>
        public ItemConsultRequest(string itemId = default(string), string price = default(string), string quantity = default(string))
        {
            this.ItemId = itemId;
            this.Price = price;
            this.Quantity = quantity;
        }

        /// <summary>
        /// 商品id
        /// </summary>
        /// <value>商品id</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品单价，单位为元，最多2位小数
        /// </summary>
        /// <value>商品单价，单位为元，最多2位小数</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <value>商品数量</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemConsultRequest {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as ItemConsultRequest);
        }

        /// <summary>
        /// Returns true if ItemConsultRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemConsultRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemConsultRequest input)
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
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
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
