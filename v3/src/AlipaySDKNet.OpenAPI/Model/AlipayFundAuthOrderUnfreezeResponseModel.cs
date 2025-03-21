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
    /// AlipayFundAuthOrderUnfreezeResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundAuthOrderUnfreezeResponseModel")]
    public partial class AlipayFundAuthOrderUnfreezeResponseModel : IEquatable<AlipayFundAuthOrderUnfreezeResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAuthOrderUnfreezeResponseModel" /> class.
        /// </summary>
        /// <param name="amount">本次操作解冻的金额，单位为：元（人民币），精确到小数点后两位，取值范围：[0.01,100000000.00].</param>
        /// <param name="authNo">支付宝资金授权订单号.</param>
        /// <param name="creditAmount">本次解冻操作中信用解冻金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="fundAmount">本次解冻操作中自有资金解冻金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="gmtTrans">授权资金解冻成功时间，格式：YYYY-MM-DD HH:MM:SS.</param>
        /// <param name="operationId">支付宝资金操作流水号.</param>
        /// <param name="outOrderNo">商户的授权资金订单号.</param>
        /// <param name="outRequestNo">商户本次资金操作的请求流水号.</param>
        /// <param name="status">资金操作流水的状态 目前支持：SUCCESS：成功.</param>
        public AlipayFundAuthOrderUnfreezeResponseModel(string amount = default(string), string authNo = default(string), string creditAmount = default(string), string fundAmount = default(string), string gmtTrans = default(string), string operationId = default(string), string outOrderNo = default(string), string outRequestNo = default(string), string status = default(string))
        {
            this.Amount = amount;
            this.AuthNo = authNo;
            this.CreditAmount = creditAmount;
            this.FundAmount = fundAmount;
            this.GmtTrans = gmtTrans;
            this.OperationId = operationId;
            this.OutOrderNo = outOrderNo;
            this.OutRequestNo = outRequestNo;
            this.Status = status;
        }

        /// <summary>
        /// 本次操作解冻的金额，单位为：元（人民币），精确到小数点后两位，取值范围：[0.01,100000000.00]
        /// </summary>
        /// <value>本次操作解冻的金额，单位为：元（人民币），精确到小数点后两位，取值范围：[0.01,100000000.00]</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝资金授权订单号
        /// </summary>
        /// <value>支付宝资金授权订单号</value>
        [DataMember(Name = "auth_no", EmitDefaultValue = false)]
        public string AuthNo { get; set; }

        /// <summary>
        /// 本次解冻操作中信用解冻金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>本次解冻操作中信用解冻金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "credit_amount", EmitDefaultValue = false)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// 本次解冻操作中自有资金解冻金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>本次解冻操作中自有资金解冻金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "fund_amount", EmitDefaultValue = false)]
        public string FundAmount { get; set; }

        /// <summary>
        /// 授权资金解冻成功时间，格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        /// <value>授权资金解冻成功时间，格式：YYYY-MM-DD HH:MM:SS</value>
        [DataMember(Name = "gmt_trans", EmitDefaultValue = false)]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 支付宝资金操作流水号
        /// </summary>
        /// <value>支付宝资金操作流水号</value>
        [DataMember(Name = "operation_id", EmitDefaultValue = false)]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户的授权资金订单号
        /// </summary>
        /// <value>商户的授权资金订单号</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户本次资金操作的请求流水号
        /// </summary>
        /// <value>商户本次资金操作的请求流水号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 资金操作流水的状态 目前支持：SUCCESS：成功
        /// </summary>
        /// <value>资金操作流水的状态 目前支持：SUCCESS：成功</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAuthOrderUnfreezeResponseModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AuthNo: ").Append(AuthNo).Append("\n");
            sb.Append("  CreditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  FundAmount: ").Append(FundAmount).Append("\n");
            sb.Append("  GmtTrans: ").Append(GmtTrans).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
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
            return this.Equals(input as AlipayFundAuthOrderUnfreezeResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAuthOrderUnfreezeResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAuthOrderUnfreezeResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAuthOrderUnfreezeResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AuthNo == input.AuthNo ||
                    (this.AuthNo != null &&
                    this.AuthNo.Equals(input.AuthNo))
                ) && 
                (
                    this.CreditAmount == input.CreditAmount ||
                    (this.CreditAmount != null &&
                    this.CreditAmount.Equals(input.CreditAmount))
                ) && 
                (
                    this.FundAmount == input.FundAmount ||
                    (this.FundAmount != null &&
                    this.FundAmount.Equals(input.FundAmount))
                ) && 
                (
                    this.GmtTrans == input.GmtTrans ||
                    (this.GmtTrans != null &&
                    this.GmtTrans.Equals(input.GmtTrans))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.AuthNo != null)
                {
                    hashCode = (hashCode * 59) + this.AuthNo.GetHashCode();
                }
                if (this.CreditAmount != null)
                {
                    hashCode = (hashCode * 59) + this.CreditAmount.GetHashCode();
                }
                if (this.FundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FundAmount.GetHashCode();
                }
                if (this.GmtTrans != null)
                {
                    hashCode = (hashCode * 59) + this.GmtTrans.GetHashCode();
                }
                if (this.OperationId != null)
                {
                    hashCode = (hashCode * 59) + this.OperationId.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
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
