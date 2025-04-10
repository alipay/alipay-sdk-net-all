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
    /// AlipayOpenMiniTipsDeliveryQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTipsDeliveryQueryResponseModel")]
    public partial class AlipayOpenMiniTipsDeliveryQueryResponseModel : IEquatable<AlipayOpenMiniTipsDeliveryQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTipsDeliveryQueryResponseModel" /> class.
        /// </summary>
        /// <param name="deliveryContent">收藏引导文案内容，不得超过14个字.</param>
        /// <param name="deliveryId">收藏引导投放活动ID.</param>
        /// <param name="deliveryName">收藏引导配置投放活动的名称.</param>
        /// <param name="endTime">活动结束时间.</param>
        /// <param name="failReason">文案审核驳回理由，仅AUDIT_REJECTED生效.</param>
        /// <param name="matchType">匹配类型.</param>
        /// <param name="matchUrl">目标页面地址，当匹配类型为TARGETURL时，投放文案仅在当前页面生效.</param>
        /// <param name="startTime">活动开始时间.</param>
        /// <param name="status">活动状态.</param>
        public AlipayOpenMiniTipsDeliveryQueryResponseModel(string deliveryContent = default(string), string deliveryId = default(string), string deliveryName = default(string), string endTime = default(string), string failReason = default(string), string matchType = default(string), string matchUrl = default(string), string startTime = default(string), string status = default(string))
        {
            this.DeliveryContent = deliveryContent;
            this.DeliveryId = deliveryId;
            this.DeliveryName = deliveryName;
            this.EndTime = endTime;
            this.FailReason = failReason;
            this.MatchType = matchType;
            this.MatchUrl = matchUrl;
            this.StartTime = startTime;
            this.Status = status;
        }

        /// <summary>
        /// 收藏引导文案内容，不得超过14个字
        /// </summary>
        /// <value>收藏引导文案内容，不得超过14个字</value>
        [DataMember(Name = "delivery_content", EmitDefaultValue = false)]
        public string DeliveryContent { get; set; }

        /// <summary>
        /// 收藏引导投放活动ID
        /// </summary>
        /// <value>收藏引导投放活动ID</value>
        [DataMember(Name = "delivery_id", EmitDefaultValue = false)]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 收藏引导配置投放活动的名称
        /// </summary>
        /// <value>收藏引导配置投放活动的名称</value>
        [DataMember(Name = "delivery_name", EmitDefaultValue = false)]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        /// <value>活动结束时间</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 文案审核驳回理由，仅AUDIT_REJECTED生效
        /// </summary>
        /// <value>文案审核驳回理由，仅AUDIT_REJECTED生效</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 匹配类型
        /// </summary>
        /// <value>匹配类型</value>
        [DataMember(Name = "match_type", EmitDefaultValue = false)]
        public string MatchType { get; set; }

        /// <summary>
        /// 目标页面地址，当匹配类型为TARGETURL时，投放文案仅在当前页面生效
        /// </summary>
        /// <value>目标页面地址，当匹配类型为TARGETURL时，投放文案仅在当前页面生效</value>
        [DataMember(Name = "match_url", EmitDefaultValue = false)]
        public string MatchUrl { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        /// <value>活动开始时间</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        /// <value>活动状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniTipsDeliveryQueryResponseModel {\n");
            sb.Append("  DeliveryContent: ").Append(DeliveryContent).Append("\n");
            sb.Append("  DeliveryId: ").Append(DeliveryId).Append("\n");
            sb.Append("  DeliveryName: ").Append(DeliveryName).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  MatchUrl: ").Append(MatchUrl).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniTipsDeliveryQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTipsDeliveryQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTipsDeliveryQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTipsDeliveryQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryContent == input.DeliveryContent ||
                    (this.DeliveryContent != null &&
                    this.DeliveryContent.Equals(input.DeliveryContent))
                ) && 
                (
                    this.DeliveryId == input.DeliveryId ||
                    (this.DeliveryId != null &&
                    this.DeliveryId.Equals(input.DeliveryId))
                ) && 
                (
                    this.DeliveryName == input.DeliveryName ||
                    (this.DeliveryName != null &&
                    this.DeliveryName.Equals(input.DeliveryName))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.MatchType == input.MatchType ||
                    (this.MatchType != null &&
                    this.MatchType.Equals(input.MatchType))
                ) && 
                (
                    this.MatchUrl == input.MatchUrl ||
                    (this.MatchUrl != null &&
                    this.MatchUrl.Equals(input.MatchUrl))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.DeliveryContent != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryContent.GetHashCode();
                }
                if (this.DeliveryId != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryId.GetHashCode();
                }
                if (this.DeliveryName != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryName.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                if (this.MatchType != null)
                {
                    hashCode = (hashCode * 59) + this.MatchType.GetHashCode();
                }
                if (this.MatchUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MatchUrl.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
