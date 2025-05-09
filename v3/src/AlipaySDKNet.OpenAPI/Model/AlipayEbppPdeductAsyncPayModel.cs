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
    /// AlipayEbppPdeductAsyncPayModel
    /// </summary>
    [DataContract(Name = "AlipayEbppPdeductAsyncPayModel")]
    public partial class AlipayEbppPdeductAsyncPayModel : IEquatable<AlipayEbppPdeductAsyncPayModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductAsyncPayModel" /> class.
        /// </summary>
        /// <param name="agentChannel">分配给外部机构发起扣款时的渠道码。朗新为LANGXIN.</param>
        /// <param name="agentCode">二级渠道码，预留字段.</param>
        /// <param name="agreementId">支付宝代扣协议Id.</param>
        /// <param name="billDate">账期.</param>
        /// <param name="billKey">户号.</param>
        /// <param name="extendField">扩展字段.</param>
        /// <param name="fineAmount">滞纳金.</param>
        /// <param name="memo">备注信息.</param>
        /// <param name="openId">用户UserId在应用AppId下的唯一用户标识.</param>
        /// <param name="outOrderNo">商户外部业务流水号.</param>
        /// <param name="payAmount">扣款金额，支付总金额，包含滞纳金.</param>
        /// <param name="pid">商户partnerId.</param>
        /// <param name="userId">用户ID.</param>
        public AlipayEbppPdeductAsyncPayModel(string agentChannel = default(string), string agentCode = default(string), string agreementId = default(string), string billDate = default(string), string billKey = default(string), string extendField = default(string), string fineAmount = default(string), string memo = default(string), string openId = default(string), string outOrderNo = default(string), string payAmount = default(string), string pid = default(string), string userId = default(string))
        {
            this.AgentChannel = agentChannel;
            this.AgentCode = agentCode;
            this.AgreementId = agreementId;
            this.BillDate = billDate;
            this.BillKey = billKey;
            this.ExtendField = extendField;
            this.FineAmount = fineAmount;
            this.Memo = memo;
            this.OpenId = openId;
            this.OutOrderNo = outOrderNo;
            this.PayAmount = payAmount;
            this.Pid = pid;
            this.UserId = userId;
        }

        /// <summary>
        /// 分配给外部机构发起扣款时的渠道码。朗新为LANGXIN
        /// </summary>
        /// <value>分配给外部机构发起扣款时的渠道码。朗新为LANGXIN</value>
        [DataMember(Name = "agent_channel", EmitDefaultValue = false)]
        public string AgentChannel { get; set; }

        /// <summary>
        /// 二级渠道码，预留字段
        /// </summary>
        /// <value>二级渠道码，预留字段</value>
        [DataMember(Name = "agent_code", EmitDefaultValue = false)]
        public string AgentCode { get; set; }

        /// <summary>
        /// 支付宝代扣协议Id
        /// </summary>
        /// <value>支付宝代扣协议Id</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        /// <value>账期</value>
        [DataMember(Name = "bill_date", EmitDefaultValue = false)]
        public string BillDate { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        /// <value>户号</value>
        [DataMember(Name = "bill_key", EmitDefaultValue = false)]
        public string BillKey { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        /// <value>扩展字段</value>
        [DataMember(Name = "extend_field", EmitDefaultValue = false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        /// <value>滞纳金</value>
        [DataMember(Name = "fine_amount", EmitDefaultValue = false)]
        public string FineAmount { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        /// <value>备注信息</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 用户UserId在应用AppId下的唯一用户标识
        /// </summary>
        /// <value>用户UserId在应用AppId下的唯一用户标识</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户外部业务流水号
        /// </summary>
        /// <value>商户外部业务流水号</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 扣款金额，支付总金额，包含滞纳金
        /// </summary>
        /// <value>扣款金额，支付总金额，包含滞纳金</value>
        [DataMember(Name = "pay_amount", EmitDefaultValue = false)]
        public string PayAmount { get; set; }

        /// <summary>
        /// 商户partnerId
        /// </summary>
        /// <value>商户partnerId</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        /// <value>用户ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppPdeductAsyncPayModel {\n");
            sb.Append("  AgentChannel: ").Append(AgentChannel).Append("\n");
            sb.Append("  AgentCode: ").Append(AgentCode).Append("\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  BillDate: ").Append(BillDate).Append("\n");
            sb.Append("  BillKey: ").Append(BillKey).Append("\n");
            sb.Append("  ExtendField: ").Append(ExtendField).Append("\n");
            sb.Append("  FineAmount: ").Append(FineAmount).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayEbppPdeductAsyncPayModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppPdeductAsyncPayModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppPdeductAsyncPayModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppPdeductAsyncPayModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgentChannel == input.AgentChannel ||
                    (this.AgentChannel != null &&
                    this.AgentChannel.Equals(input.AgentChannel))
                ) && 
                (
                    this.AgentCode == input.AgentCode ||
                    (this.AgentCode != null &&
                    this.AgentCode.Equals(input.AgentCode))
                ) && 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.BillDate == input.BillDate ||
                    (this.BillDate != null &&
                    this.BillDate.Equals(input.BillDate))
                ) && 
                (
                    this.BillKey == input.BillKey ||
                    (this.BillKey != null &&
                    this.BillKey.Equals(input.BillKey))
                ) && 
                (
                    this.ExtendField == input.ExtendField ||
                    (this.ExtendField != null &&
                    this.ExtendField.Equals(input.ExtendField))
                ) && 
                (
                    this.FineAmount == input.FineAmount ||
                    (this.FineAmount != null &&
                    this.FineAmount.Equals(input.FineAmount))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AgentChannel != null)
                {
                    hashCode = (hashCode * 59) + this.AgentChannel.GetHashCode();
                }
                if (this.AgentCode != null)
                {
                    hashCode = (hashCode * 59) + this.AgentCode.GetHashCode();
                }
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.BillDate != null)
                {
                    hashCode = (hashCode * 59) + this.BillDate.GetHashCode();
                }
                if (this.BillKey != null)
                {
                    hashCode = (hashCode * 59) + this.BillKey.GetHashCode();
                }
                if (this.ExtendField != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendField.GetHashCode();
                }
                if (this.FineAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FineAmount.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.PayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PayAmount.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
