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
    /// AlipayMerchantIndirectAuthorderCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantIndirectAuthorderCreateResponseModel")]
    public partial class AlipayMerchantIndirectAuthorderCreateResponseModel : IEquatable<AlipayMerchantIndirectAuthorderCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIndirectAuthorderCreateResponseModel" /> class.
        /// </summary>
        /// <param name="orderNo">申请单号.</param>
        /// <param name="orderStatus">意愿申请单状态，枚举值：审核中(AUDITING)、待联系人确认（CONTACT_CONFIRM），待法人确认（LEGAL_CONFIRM）、审核通过(AUDIT_PASS)、审核驳回(AUDIT_REJECT)、已冻结(AUDIT_FREEZE)、已撤回(CANCELED)、联系人处理中(CONTACT_PROCESSING).</param>
        public AlipayMerchantIndirectAuthorderCreateResponseModel(string orderNo = default(string), string orderStatus = default(string))
        {
            this.OrderNo = orderNo;
            this.OrderStatus = orderStatus;
        }

        /// <summary>
        /// 申请单号
        /// </summary>
        /// <value>申请单号</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 意愿申请单状态，枚举值：审核中(AUDITING)、待联系人确认（CONTACT_CONFIRM），待法人确认（LEGAL_CONFIRM）、审核通过(AUDIT_PASS)、审核驳回(AUDIT_REJECT)、已冻结(AUDIT_FREEZE)、已撤回(CANCELED)、联系人处理中(CONTACT_PROCESSING)
        /// </summary>
        /// <value>意愿申请单状态，枚举值：审核中(AUDITING)、待联系人确认（CONTACT_CONFIRM），待法人确认（LEGAL_CONFIRM）、审核通过(AUDIT_PASS)、审核驳回(AUDIT_REJECT)、已冻结(AUDIT_FREEZE)、已撤回(CANCELED)、联系人处理中(CONTACT_PROCESSING)</value>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantIndirectAuthorderCreateResponseModel {\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
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
            return this.Equals(input as AlipayMerchantIndirectAuthorderCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantIndirectAuthorderCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantIndirectAuthorderCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantIndirectAuthorderCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
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
                if (this.OrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
                }
                if (this.OrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.OrderStatus.GetHashCode();
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
