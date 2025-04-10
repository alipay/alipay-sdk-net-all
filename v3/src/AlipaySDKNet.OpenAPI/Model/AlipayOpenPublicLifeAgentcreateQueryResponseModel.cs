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
    /// AlipayOpenPublicLifeAgentcreateQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicLifeAgentcreateQueryResponseModel")]
    public partial class AlipayOpenPublicLifeAgentcreateQueryResponseModel : IEquatable<AlipayOpenPublicLifeAgentcreateQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicLifeAgentcreateQueryResponseModel" /> class.
        /// </summary>
        /// <param name="lifeAppId">只有审核通过，且商户在支付宝发送的授权邮件中确认授权，此时生活号才会正式创建，查询才会返回该值.</param>
        /// <param name="merchantPid">商户pid.</param>
        /// <param name="orderStatusBizDesc">支付宝商户入驻申请单状态，申请单状态包括：暂存、审核中、待商户确认、成功、失败。 说明：暂存是审核前的中间状态，如出现暂存状态请再次提交代创建生活号申请。.</param>
        /// <param name="outBizNo">由开发者创建的外部入驻申请单据号.</param>
        /// <param name="refusedReason">只有审核失败才会返回该值.</param>
        public AlipayOpenPublicLifeAgentcreateQueryResponseModel(string lifeAppId = default(string), string merchantPid = default(string), string orderStatusBizDesc = default(string), string outBizNo = default(string), string refusedReason = default(string))
        {
            this.LifeAppId = lifeAppId;
            this.MerchantPid = merchantPid;
            this.OrderStatusBizDesc = orderStatusBizDesc;
            this.OutBizNo = outBizNo;
            this.RefusedReason = refusedReason;
        }

        /// <summary>
        /// 只有审核通过，且商户在支付宝发送的授权邮件中确认授权，此时生活号才会正式创建，查询才会返回该值
        /// </summary>
        /// <value>只有审核通过，且商户在支付宝发送的授权邮件中确认授权，此时生活号才会正式创建，查询才会返回该值</value>
        [DataMember(Name = "life_app_id", EmitDefaultValue = false)]
        public string LifeAppId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        /// <value>商户pid</value>
        [DataMember(Name = "merchant_pid", EmitDefaultValue = false)]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 支付宝商户入驻申请单状态，申请单状态包括：暂存、审核中、待商户确认、成功、失败。 说明：暂存是审核前的中间状态，如出现暂存状态请再次提交代创建生活号申请。
        /// </summary>
        /// <value>支付宝商户入驻申请单状态，申请单状态包括：暂存、审核中、待商户确认、成功、失败。 说明：暂存是审核前的中间状态，如出现暂存状态请再次提交代创建生活号申请。</value>
        [DataMember(Name = "order_status_biz_desc", EmitDefaultValue = false)]
        public string OrderStatusBizDesc { get; set; }

        /// <summary>
        /// 由开发者创建的外部入驻申请单据号
        /// </summary>
        /// <value>由开发者创建的外部入驻申请单据号</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 只有审核失败才会返回该值
        /// </summary>
        /// <value>只有审核失败才会返回该值</value>
        [DataMember(Name = "refused_reason", EmitDefaultValue = false)]
        public string RefusedReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicLifeAgentcreateQueryResponseModel {\n");
            sb.Append("  LifeAppId: ").Append(LifeAppId).Append("\n");
            sb.Append("  MerchantPid: ").Append(MerchantPid).Append("\n");
            sb.Append("  OrderStatusBizDesc: ").Append(OrderStatusBizDesc).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  RefusedReason: ").Append(RefusedReason).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicLifeAgentcreateQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicLifeAgentcreateQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicLifeAgentcreateQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicLifeAgentcreateQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LifeAppId == input.LifeAppId ||
                    (this.LifeAppId != null &&
                    this.LifeAppId.Equals(input.LifeAppId))
                ) && 
                (
                    this.MerchantPid == input.MerchantPid ||
                    (this.MerchantPid != null &&
                    this.MerchantPid.Equals(input.MerchantPid))
                ) && 
                (
                    this.OrderStatusBizDesc == input.OrderStatusBizDesc ||
                    (this.OrderStatusBizDesc != null &&
                    this.OrderStatusBizDesc.Equals(input.OrderStatusBizDesc))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.RefusedReason == input.RefusedReason ||
                    (this.RefusedReason != null &&
                    this.RefusedReason.Equals(input.RefusedReason))
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
                if (this.LifeAppId != null)
                {
                    hashCode = (hashCode * 59) + this.LifeAppId.GetHashCode();
                }
                if (this.MerchantPid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantPid.GetHashCode();
                }
                if (this.OrderStatusBizDesc != null)
                {
                    hashCode = (hashCode * 59) + this.OrderStatusBizDesc.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.RefusedReason != null)
                {
                    hashCode = (hashCode * 59) + this.RefusedReason.GetHashCode();
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
