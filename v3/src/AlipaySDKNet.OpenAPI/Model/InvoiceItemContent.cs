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
    /// InvoiceItemContent
    /// </summary>
    [DataContract(Name = "InvoiceItemContent")]
    public partial class InvoiceItemContent : IEquatable<InvoiceItemContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceItemContent" /> class.
        /// </summary>
        /// <param name="itemAmount">价税合计。(等于sumPrice和tax之和).</param>
        /// <param name="itemName">发票项目名称（或商品名称）.</param>
        /// <param name="itemNo">商品编号.</param>
        /// <param name="itemPrice">单价，格式：100.00。新版电子发票，折扣行此参数不能传，非折扣行必传.</param>
        /// <param name="itemQuantity">数量。新版电子发票，折扣行此参数不能传，非折扣行必传.</param>
        /// <param name="itemSumPrice">单项总价，格式：100.00.</param>
        /// <param name="itemTaxPrice">税额.</param>
        /// <param name="itemTaxRate">税率.</param>
        /// <param name="itemUnit">台.</param>
        /// <param name="rowType">发票行性质。0表示正常行，1表示折扣行，2表示被折扣行。比如充电器单价100元，折扣10元，则明细为2行，充电器行性质为2，折扣行性质为1。如果充电器没有折扣，则值应为0.</param>
        public InvoiceItemContent(string itemAmount = default(string), string itemName = default(string), string itemNo = default(string), string itemPrice = default(string), int itemQuantity = default(int), string itemSumPrice = default(string), string itemTaxPrice = default(string), string itemTaxRate = default(string), string itemUnit = default(string), int rowType = default(int))
        {
            this.ItemAmount = itemAmount;
            this.ItemName = itemName;
            this.ItemNo = itemNo;
            this.ItemPrice = itemPrice;
            this.ItemQuantity = itemQuantity;
            this.ItemSumPrice = itemSumPrice;
            this.ItemTaxPrice = itemTaxPrice;
            this.ItemTaxRate = itemTaxRate;
            this.ItemUnit = itemUnit;
            this.RowType = rowType;
        }

        /// <summary>
        /// 价税合计。(等于sumPrice和tax之和)
        /// </summary>
        /// <value>价税合计。(等于sumPrice和tax之和)</value>
        [DataMember(Name = "item_amount", EmitDefaultValue = false)]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 发票项目名称（或商品名称）
        /// </summary>
        /// <value>发票项目名称（或商品名称）</value>
        [DataMember(Name = "item_name", EmitDefaultValue = false)]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        /// <value>商品编号</value>
        [DataMember(Name = "item_no", EmitDefaultValue = false)]
        public string ItemNo { get; set; }

        /// <summary>
        /// 单价，格式：100.00。新版电子发票，折扣行此参数不能传，非折扣行必传
        /// </summary>
        /// <value>单价，格式：100.00。新版电子发票，折扣行此参数不能传，非折扣行必传</value>
        [DataMember(Name = "item_price", EmitDefaultValue = false)]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 数量。新版电子发票，折扣行此参数不能传，非折扣行必传
        /// </summary>
        /// <value>数量。新版电子发票，折扣行此参数不能传，非折扣行必传</value>
        [DataMember(Name = "item_quantity", EmitDefaultValue = false)]
        public int ItemQuantity { get; set; }

        /// <summary>
        /// 单项总价，格式：100.00
        /// </summary>
        /// <value>单项总价，格式：100.00</value>
        [DataMember(Name = "item_sum_price", EmitDefaultValue = false)]
        public string ItemSumPrice { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        /// <value>税额</value>
        [DataMember(Name = "item_tax_price", EmitDefaultValue = false)]
        public string ItemTaxPrice { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        /// <value>税率</value>
        [DataMember(Name = "item_tax_rate", EmitDefaultValue = false)]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 台
        /// </summary>
        /// <value>台</value>
        [DataMember(Name = "item_unit", EmitDefaultValue = false)]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 发票行性质。0表示正常行，1表示折扣行，2表示被折扣行。比如充电器单价100元，折扣10元，则明细为2行，充电器行性质为2，折扣行性质为1。如果充电器没有折扣，则值应为0
        /// </summary>
        /// <value>发票行性质。0表示正常行，1表示折扣行，2表示被折扣行。比如充电器单价100元，折扣10元，则明细为2行，充电器行性质为2，折扣行性质为1。如果充电器没有折扣，则值应为0</value>
        [DataMember(Name = "row_type", EmitDefaultValue = false)]
        public int RowType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceItemContent {\n");
            sb.Append("  ItemAmount: ").Append(ItemAmount).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  ItemNo: ").Append(ItemNo).Append("\n");
            sb.Append("  ItemPrice: ").Append(ItemPrice).Append("\n");
            sb.Append("  ItemQuantity: ").Append(ItemQuantity).Append("\n");
            sb.Append("  ItemSumPrice: ").Append(ItemSumPrice).Append("\n");
            sb.Append("  ItemTaxPrice: ").Append(ItemTaxPrice).Append("\n");
            sb.Append("  ItemTaxRate: ").Append(ItemTaxRate).Append("\n");
            sb.Append("  ItemUnit: ").Append(ItemUnit).Append("\n");
            sb.Append("  RowType: ").Append(RowType).Append("\n");
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
            return this.Equals(input as InvoiceItemContent);
        }

        /// <summary>
        /// Returns true if InvoiceItemContent instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceItemContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceItemContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemAmount == input.ItemAmount ||
                    (this.ItemAmount != null &&
                    this.ItemAmount.Equals(input.ItemAmount))
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.ItemNo == input.ItemNo ||
                    (this.ItemNo != null &&
                    this.ItemNo.Equals(input.ItemNo))
                ) && 
                (
                    this.ItemPrice == input.ItemPrice ||
                    (this.ItemPrice != null &&
                    this.ItemPrice.Equals(input.ItemPrice))
                ) && 
                (
                    this.ItemQuantity == input.ItemQuantity ||
                    this.ItemQuantity.Equals(input.ItemQuantity)
                ) && 
                (
                    this.ItemSumPrice == input.ItemSumPrice ||
                    (this.ItemSumPrice != null &&
                    this.ItemSumPrice.Equals(input.ItemSumPrice))
                ) && 
                (
                    this.ItemTaxPrice == input.ItemTaxPrice ||
                    (this.ItemTaxPrice != null &&
                    this.ItemTaxPrice.Equals(input.ItemTaxPrice))
                ) && 
                (
                    this.ItemTaxRate == input.ItemTaxRate ||
                    (this.ItemTaxRate != null &&
                    this.ItemTaxRate.Equals(input.ItemTaxRate))
                ) && 
                (
                    this.ItemUnit == input.ItemUnit ||
                    (this.ItemUnit != null &&
                    this.ItemUnit.Equals(input.ItemUnit))
                ) && 
                (
                    this.RowType == input.RowType ||
                    this.RowType.Equals(input.RowType)
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
                if (this.ItemAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ItemAmount.GetHashCode();
                }
                if (this.ItemName != null)
                {
                    hashCode = (hashCode * 59) + this.ItemName.GetHashCode();
                }
                if (this.ItemNo != null)
                {
                    hashCode = (hashCode * 59) + this.ItemNo.GetHashCode();
                }
                if (this.ItemPrice != null)
                {
                    hashCode = (hashCode * 59) + this.ItemPrice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemQuantity.GetHashCode();
                if (this.ItemSumPrice != null)
                {
                    hashCode = (hashCode * 59) + this.ItemSumPrice.GetHashCode();
                }
                if (this.ItemTaxPrice != null)
                {
                    hashCode = (hashCode * 59) + this.ItemTaxPrice.GetHashCode();
                }
                if (this.ItemTaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.ItemTaxRate.GetHashCode();
                }
                if (this.ItemUnit != null)
                {
                    hashCode = (hashCode * 59) + this.ItemUnit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RowType.GetHashCode();
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
