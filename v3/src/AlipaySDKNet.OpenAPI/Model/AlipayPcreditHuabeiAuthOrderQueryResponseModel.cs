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
    /// AlipayPcreditHuabeiAuthOrderQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayPcreditHuabeiAuthOrderQueryResponseModel")]
    public partial class AlipayPcreditHuabeiAuthOrderQueryResponseModel : IEquatable<AlipayPcreditHuabeiAuthOrderQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayPcreditHuabeiAuthOrderQueryResponseModel" /> class.
        /// </summary>
        /// <param name="agreementNo">支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号。.</param>
        /// <param name="alipayUserId">支付宝用户userId.</param>
        /// <param name="authOptId">支付宝侧花呗冻结解冻操作单据id.</param>
        /// <param name="gmtTrans">业务操作完成时间.</param>
        /// <param name="openId">支付宝用户userId.</param>
        /// <param name="orderTitle">商户业务订单的简单描述，如商品名称等，长度不超过100个字母或50个汉字.</param>
        /// <param name="outRequestNo">商户本次操作的请求流水号.</param>
        /// <param name="restFreezeAmount">完成本次操作时，用户资金池余额快照。仅作提示用，请勿用于核对，并发情况下数值有可能不准确。两位小数，单位元。.</param>
        /// <param name="sellerId">商户的支付宝用户id.</param>
        /// <param name="transAmount">冻结或者解冻金额.</param>
        /// <param name="transStatus">业务操作状态，Y表示成功结束；N表示失败结束；I表示进行中。.</param>
        /// <param name="transType">操作类型，FREEZE表示冻结操作；UNFREEZE表示解冻操作；PAY表示支付操作；SETTLE表示结算操作.</param>
        public AlipayPcreditHuabeiAuthOrderQueryResponseModel(string agreementNo = default(string), string alipayUserId = default(string), string authOptId = default(string), string gmtTrans = default(string), string openId = default(string), string orderTitle = default(string), string outRequestNo = default(string), string restFreezeAmount = default(string), string sellerId = default(string), string transAmount = default(string), string transStatus = default(string), string transType = default(string))
        {
            this.AgreementNo = agreementNo;
            this.AlipayUserId = alipayUserId;
            this.AuthOptId = authOptId;
            this.GmtTrans = gmtTrans;
            this.OpenId = openId;
            this.OrderTitle = orderTitle;
            this.OutRequestNo = outRequestNo;
            this.RestFreezeAmount = restFreezeAmount;
            this.SellerId = sellerId;
            this.TransAmount = transAmount;
            this.TransStatus = transStatus;
            this.TransType = transType;
        }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号。
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号。</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        /// <value>支付宝用户userId</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝侧花呗冻结解冻操作单据id
        /// </summary>
        /// <value>支付宝侧花呗冻结解冻操作单据id</value>
        [DataMember(Name = "auth_opt_id", EmitDefaultValue = false)]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 业务操作完成时间
        /// </summary>
        /// <value>业务操作完成时间</value>
        [DataMember(Name = "gmt_trans", EmitDefaultValue = false)]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        /// <value>支付宝用户userId</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户业务订单的简单描述，如商品名称等，长度不超过100个字母或50个汉字
        /// </summary>
        /// <value>商户业务订单的简单描述，如商品名称等，长度不超过100个字母或50个汉字</value>
        [DataMember(Name = "order_title", EmitDefaultValue = false)]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号
        /// </summary>
        /// <value>商户本次操作的请求流水号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 完成本次操作时，用户资金池余额快照。仅作提示用，请勿用于核对，并发情况下数值有可能不准确。两位小数，单位元。
        /// </summary>
        /// <value>完成本次操作时，用户资金池余额快照。仅作提示用，请勿用于核对，并发情况下数值有可能不准确。两位小数，单位元。</value>
        [DataMember(Name = "rest_freeze_amount", EmitDefaultValue = false)]
        public string RestFreezeAmount { get; set; }

        /// <summary>
        /// 商户的支付宝用户id
        /// </summary>
        /// <value>商户的支付宝用户id</value>
        [DataMember(Name = "seller_id", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// 冻结或者解冻金额
        /// </summary>
        /// <value>冻结或者解冻金额</value>
        [DataMember(Name = "trans_amount", EmitDefaultValue = false)]
        public string TransAmount { get; set; }

        /// <summary>
        /// 业务操作状态，Y表示成功结束；N表示失败结束；I表示进行中。
        /// </summary>
        /// <value>业务操作状态，Y表示成功结束；N表示失败结束；I表示进行中。</value>
        [DataMember(Name = "trans_status", EmitDefaultValue = false)]
        public string TransStatus { get; set; }

        /// <summary>
        /// 操作类型，FREEZE表示冻结操作；UNFREEZE表示解冻操作；PAY表示支付操作；SETTLE表示结算操作
        /// </summary>
        /// <value>操作类型，FREEZE表示冻结操作；UNFREEZE表示解冻操作；PAY表示支付操作；SETTLE表示结算操作</value>
        [DataMember(Name = "trans_type", EmitDefaultValue = false)]
        public string TransType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayPcreditHuabeiAuthOrderQueryResponseModel {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  AuthOptId: ").Append(AuthOptId).Append("\n");
            sb.Append("  GmtTrans: ").Append(GmtTrans).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OrderTitle: ").Append(OrderTitle).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  RestFreezeAmount: ").Append(RestFreezeAmount).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  TransAmount: ").Append(TransAmount).Append("\n");
            sb.Append("  TransStatus: ").Append(TransStatus).Append("\n");
            sb.Append("  TransType: ").Append(TransType).Append("\n");
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
            return this.Equals(input as AlipayPcreditHuabeiAuthOrderQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayPcreditHuabeiAuthOrderQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayPcreditHuabeiAuthOrderQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayPcreditHuabeiAuthOrderQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.AuthOptId == input.AuthOptId ||
                    (this.AuthOptId != null &&
                    this.AuthOptId.Equals(input.AuthOptId))
                ) && 
                (
                    this.GmtTrans == input.GmtTrans ||
                    (this.GmtTrans != null &&
                    this.GmtTrans.Equals(input.GmtTrans))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OrderTitle == input.OrderTitle ||
                    (this.OrderTitle != null &&
                    this.OrderTitle.Equals(input.OrderTitle))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.RestFreezeAmount == input.RestFreezeAmount ||
                    (this.RestFreezeAmount != null &&
                    this.RestFreezeAmount.Equals(input.RestFreezeAmount))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.TransAmount == input.TransAmount ||
                    (this.TransAmount != null &&
                    this.TransAmount.Equals(input.TransAmount))
                ) && 
                (
                    this.TransStatus == input.TransStatus ||
                    (this.TransStatus != null &&
                    this.TransStatus.Equals(input.TransStatus))
                ) && 
                (
                    this.TransType == input.TransType ||
                    (this.TransType != null &&
                    this.TransType.Equals(input.TransType))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.AuthOptId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthOptId.GetHashCode();
                }
                if (this.GmtTrans != null)
                {
                    hashCode = (hashCode * 59) + this.GmtTrans.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OrderTitle != null)
                {
                    hashCode = (hashCode * 59) + this.OrderTitle.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.RestFreezeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RestFreezeAmount.GetHashCode();
                }
                if (this.SellerId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerId.GetHashCode();
                }
                if (this.TransAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TransAmount.GetHashCode();
                }
                if (this.TransStatus != null)
                {
                    hashCode = (hashCode * 59) + this.TransStatus.GetHashCode();
                }
                if (this.TransType != null)
                {
                    hashCode = (hashCode * 59) + this.TransType.GetHashCode();
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
