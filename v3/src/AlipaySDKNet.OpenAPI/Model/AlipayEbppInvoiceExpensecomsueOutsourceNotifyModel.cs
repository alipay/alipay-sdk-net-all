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
    /// AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel")]
    public partial class AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel : IEquatable<AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel" /> class.
        /// </summary>
        /// <param name="accountId">企业共同账户id.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="amount">消费金额.</param>
        /// <param name="dealTime">交易发生时间.</param>
        /// <param name="employeeId">员工id.</param>
        /// <param name="employeeIdType">员工账号类型.</param>
        /// <param name="employeeOpenId">员工开放id.</param>
        /// <param name="enterpriseId">企业id.</param>
        /// <param name="extend">拓展参数.</param>
        /// <param name="isOffSet">交易类型.</param>
        /// <param name="outSourceId">外部交易支付单号.</param>
        /// <param name="platform">外部平台编码.</param>
        /// <param name="relateNo">外部交易退款单号.</param>
        /// <param name="standardId">费控规则ID.</param>
        public AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel(string accountId = default(string), string agreementNo = default(string), int amount = default(int), string dealTime = default(string), string employeeId = default(string), int employeeIdType = default(int), string employeeOpenId = default(string), string enterpriseId = default(string), string extend = default(string), int isOffSet = default(int), string outSourceId = default(string), string platform = default(string), string relateNo = default(string), string standardId = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.Amount = amount;
            this.DealTime = dealTime;
            this.EmployeeId = employeeId;
            this.EmployeeIdType = employeeIdType;
            this.EmployeeOpenId = employeeOpenId;
            this.EnterpriseId = enterpriseId;
            this.Extend = extend;
            this.IsOffSet = isOffSet;
            this.OutSourceId = outSourceId;
            this.Platform = platform;
            this.RelateNo = relateNo;
            this.StandardId = standardId;
        }

        /// <summary>
        /// 企业共同账户id
        /// </summary>
        /// <value>企业共同账户id</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        /// <value>消费金额</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// 交易发生时间
        /// </summary>
        /// <value>交易发生时间</value>
        [DataMember(Name = "deal_time", EmitDefaultValue = false)]
        public string DealTime { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        /// <value>员工id</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工账号类型
        /// </summary>
        /// <value>员工账号类型</value>
        [DataMember(Name = "employee_id_type", EmitDefaultValue = false)]
        public int EmployeeIdType { get; set; }

        /// <summary>
        /// 员工开放id
        /// </summary>
        /// <value>员工开放id</value>
        [DataMember(Name = "employee_open_id", EmitDefaultValue = false)]
        public string EmployeeOpenId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        /// <value>拓展参数</value>
        [DataMember(Name = "extend", EmitDefaultValue = false)]
        public string Extend { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        /// <value>交易类型</value>
        [DataMember(Name = "is_off_set", EmitDefaultValue = false)]
        public int IsOffSet { get; set; }

        /// <summary>
        /// 外部交易支付单号
        /// </summary>
        /// <value>外部交易支付单号</value>
        [DataMember(Name = "out_source_id", EmitDefaultValue = false)]
        public string OutSourceId { get; set; }

        /// <summary>
        /// 外部平台编码
        /// </summary>
        /// <value>外部平台编码</value>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// 外部交易退款单号
        /// </summary>
        /// <value>外部交易退款单号</value>
        [DataMember(Name = "relate_no", EmitDefaultValue = false)]
        public string RelateNo { get; set; }

        /// <summary>
        /// 费控规则ID
        /// </summary>
        /// <value>费控规则ID</value>
        [DataMember(Name = "standard_id", EmitDefaultValue = false)]
        public string StandardId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DealTime: ").Append(DealTime).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmployeeIdType: ").Append(EmployeeIdType).Append("\n");
            sb.Append("  EmployeeOpenId: ").Append(EmployeeOpenId).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  Extend: ").Append(Extend).Append("\n");
            sb.Append("  IsOffSet: ").Append(IsOffSet).Append("\n");
            sb.Append("  OutSourceId: ").Append(OutSourceId).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  RelateNo: ").Append(RelateNo).Append("\n");
            sb.Append("  StandardId: ").Append(StandardId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.DealTime == input.DealTime ||
                    (this.DealTime != null &&
                    this.DealTime.Equals(input.DealTime))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.EmployeeIdType == input.EmployeeIdType ||
                    this.EmployeeIdType.Equals(input.EmployeeIdType)
                ) && 
                (
                    this.EmployeeOpenId == input.EmployeeOpenId ||
                    (this.EmployeeOpenId != null &&
                    this.EmployeeOpenId.Equals(input.EmployeeOpenId))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.Extend == input.Extend ||
                    (this.Extend != null &&
                    this.Extend.Equals(input.Extend))
                ) && 
                (
                    this.IsOffSet == input.IsOffSet ||
                    this.IsOffSet.Equals(input.IsOffSet)
                ) && 
                (
                    this.OutSourceId == input.OutSourceId ||
                    (this.OutSourceId != null &&
                    this.OutSourceId.Equals(input.OutSourceId))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.RelateNo == input.RelateNo ||
                    (this.RelateNo != null &&
                    this.RelateNo.Equals(input.RelateNo))
                ) && 
                (
                    this.StandardId == input.StandardId ||
                    (this.StandardId != null &&
                    this.StandardId.Equals(input.StandardId))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.DealTime != null)
                {
                    hashCode = (hashCode * 59) + this.DealTime.GetHashCode();
                }
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EmployeeIdType.GetHashCode();
                if (this.EmployeeOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeOpenId.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.Extend != null)
                {
                    hashCode = (hashCode * 59) + this.Extend.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsOffSet.GetHashCode();
                if (this.OutSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.OutSourceId.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.RelateNo != null)
                {
                    hashCode = (hashCode * 59) + this.RelateNo.GetHashCode();
                }
                if (this.StandardId != null)
                {
                    hashCode = (hashCode * 59) + this.StandardId.GetHashCode();
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
