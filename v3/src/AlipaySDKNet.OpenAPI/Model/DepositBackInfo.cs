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
    /// DepositBackInfo
    /// </summary>
    [DataContract(Name = "DepositBackInfo")]
    public partial class DepositBackInfo : IEquatable<DepositBackInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositBackInfo" /> class.
        /// </summary>
        /// <param name="bankAckTime">银行响应时间，格式为yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="dbackAmount">银行卡冲退金额。单位：元。.</param>
        /// <param name="dbackStatus">银行卡冲退状态。S-成功，F-失败，P-处理中。银行卡冲退失败，资金自动转入用户支付宝余额。.</param>
        /// <param name="estBankReceiptTime">预估银行到账时间，格式为yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="hasDepositBack">是否存在银行卡冲退信息。.</param>
        public DepositBackInfo(string bankAckTime = default(string), string dbackAmount = default(string), string dbackStatus = default(string), string estBankReceiptTime = default(string), string hasDepositBack = default(string))
        {
            this.BankAckTime = bankAckTime;
            this.DbackAmount = dbackAmount;
            this.DbackStatus = dbackStatus;
            this.EstBankReceiptTime = estBankReceiptTime;
            this.HasDepositBack = hasDepositBack;
        }

        /// <summary>
        /// 银行响应时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>银行响应时间，格式为yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "bank_ack_time", EmitDefaultValue = false)]
        public string BankAckTime { get; set; }

        /// <summary>
        /// 银行卡冲退金额。单位：元。
        /// </summary>
        /// <value>银行卡冲退金额。单位：元。</value>
        [DataMember(Name = "dback_amount", EmitDefaultValue = false)]
        public string DbackAmount { get; set; }

        /// <summary>
        /// 银行卡冲退状态。S-成功，F-失败，P-处理中。银行卡冲退失败，资金自动转入用户支付宝余额。
        /// </summary>
        /// <value>银行卡冲退状态。S-成功，F-失败，P-处理中。银行卡冲退失败，资金自动转入用户支付宝余额。</value>
        [DataMember(Name = "dback_status", EmitDefaultValue = false)]
        public string DbackStatus { get; set; }

        /// <summary>
        /// 预估银行到账时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>预估银行到账时间，格式为yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "est_bank_receipt_time", EmitDefaultValue = false)]
        public string EstBankReceiptTime { get; set; }

        /// <summary>
        /// 是否存在银行卡冲退信息。
        /// </summary>
        /// <value>是否存在银行卡冲退信息。</value>
        [DataMember(Name = "has_deposit_back", EmitDefaultValue = false)]
        public string HasDepositBack { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepositBackInfo {\n");
            sb.Append("  BankAckTime: ").Append(BankAckTime).Append("\n");
            sb.Append("  DbackAmount: ").Append(DbackAmount).Append("\n");
            sb.Append("  DbackStatus: ").Append(DbackStatus).Append("\n");
            sb.Append("  EstBankReceiptTime: ").Append(EstBankReceiptTime).Append("\n");
            sb.Append("  HasDepositBack: ").Append(HasDepositBack).Append("\n");
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
            return this.Equals(input as DepositBackInfo);
        }

        /// <summary>
        /// Returns true if DepositBackInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositBackInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositBackInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankAckTime == input.BankAckTime ||
                    (this.BankAckTime != null &&
                    this.BankAckTime.Equals(input.BankAckTime))
                ) && 
                (
                    this.DbackAmount == input.DbackAmount ||
                    (this.DbackAmount != null &&
                    this.DbackAmount.Equals(input.DbackAmount))
                ) && 
                (
                    this.DbackStatus == input.DbackStatus ||
                    (this.DbackStatus != null &&
                    this.DbackStatus.Equals(input.DbackStatus))
                ) && 
                (
                    this.EstBankReceiptTime == input.EstBankReceiptTime ||
                    (this.EstBankReceiptTime != null &&
                    this.EstBankReceiptTime.Equals(input.EstBankReceiptTime))
                ) && 
                (
                    this.HasDepositBack == input.HasDepositBack ||
                    (this.HasDepositBack != null &&
                    this.HasDepositBack.Equals(input.HasDepositBack))
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
                if (this.BankAckTime != null)
                {
                    hashCode = (hashCode * 59) + this.BankAckTime.GetHashCode();
                }
                if (this.DbackAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DbackAmount.GetHashCode();
                }
                if (this.DbackStatus != null)
                {
                    hashCode = (hashCode * 59) + this.DbackStatus.GetHashCode();
                }
                if (this.EstBankReceiptTime != null)
                {
                    hashCode = (hashCode * 59) + this.EstBankReceiptTime.GetHashCode();
                }
                if (this.HasDepositBack != null)
                {
                    hashCode = (hashCode * 59) + this.HasDepositBack.GetHashCode();
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
