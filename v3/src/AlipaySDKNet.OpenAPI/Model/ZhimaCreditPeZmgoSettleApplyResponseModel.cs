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
    /// ZhimaCreditPeZmgoSettleApplyResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoSettleApplyResponseModel")]
    public partial class ZhimaCreditPeZmgoSettleApplyResponseModel : IEquatable<ZhimaCreditPeZmgoSettleApplyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoSettleApplyResponseModel" /> class.
        /// </summary>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号。.</param>
        /// <param name="failReason">根据商户传入的轻会员协议结算周期内累计消费数据与支付宝端轻会员协议结算周期内消费数据比对之后，若数据不一致，则会返回对应的异常数据比对结果。.</param>
        /// <param name="outRequestNo">商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。.</param>
        /// <param name="settleStatus">Y(\&quot;Y\&quot;, \&quot;支付成功\&quot;), P(\&quot;P\&quot;, \&quot;支付中\&quot;), N(\&quot;N\&quot;, \&quot;支付失败\&quot;),.</param>
        /// <param name="withholdPlanNo">芝麻GO结算时，需要传入的扣款单据号。来源于协议到期通知消息.</param>
        public ZhimaCreditPeZmgoSettleApplyResponseModel(string agreementId = default(string), string failReason = default(string), string outRequestNo = default(string), string settleStatus = default(string), string withholdPlanNo = default(string))
        {
            this.AgreementId = agreementId;
            this.FailReason = failReason;
            this.OutRequestNo = outRequestNo;
            this.SettleStatus = settleStatus;
            this.WithholdPlanNo = withholdPlanNo;
        }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号。</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 根据商户传入的轻会员协议结算周期内累计消费数据与支付宝端轻会员协议结算周期内消费数据比对之后，若数据不一致，则会返回对应的异常数据比对结果。
        /// </summary>
        /// <value>根据商户传入的轻会员协议结算周期内累计消费数据与支付宝端轻会员协议结算周期内消费数据比对之后，若数据不一致，则会返回对应的异常数据比对结果。</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        /// <value>商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// Y(\&quot;Y\&quot;, \&quot;支付成功\&quot;), P(\&quot;P\&quot;, \&quot;支付中\&quot;), N(\&quot;N\&quot;, \&quot;支付失败\&quot;),
        /// </summary>
        /// <value>Y(\&quot;Y\&quot;, \&quot;支付成功\&quot;), P(\&quot;P\&quot;, \&quot;支付中\&quot;), N(\&quot;N\&quot;, \&quot;支付失败\&quot;),</value>
        [DataMember(Name = "settle_status", EmitDefaultValue = false)]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 芝麻GO结算时，需要传入的扣款单据号。来源于协议到期通知消息
        /// </summary>
        /// <value>芝麻GO结算时，需要传入的扣款单据号。来源于协议到期通知消息</value>
        [DataMember(Name = "withhold_plan_no", EmitDefaultValue = false)]
        public string WithholdPlanNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPeZmgoSettleApplyResponseModel {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  SettleStatus: ").Append(SettleStatus).Append("\n");
            sb.Append("  WithholdPlanNo: ").Append(WithholdPlanNo).Append("\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoSettleApplyResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoSettleApplyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoSettleApplyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoSettleApplyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.SettleStatus == input.SettleStatus ||
                    (this.SettleStatus != null &&
                    this.SettleStatus.Equals(input.SettleStatus))
                ) && 
                (
                    this.WithholdPlanNo == input.WithholdPlanNo ||
                    (this.WithholdPlanNo != null &&
                    this.WithholdPlanNo.Equals(input.WithholdPlanNo))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.SettleStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SettleStatus.GetHashCode();
                }
                if (this.WithholdPlanNo != null)
                {
                    hashCode = (hashCode * 59) + this.WithholdPlanNo.GetHashCode();
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
