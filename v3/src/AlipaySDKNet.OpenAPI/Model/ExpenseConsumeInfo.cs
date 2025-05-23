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
    /// ExpenseConsumeInfo
    /// </summary>
    [DataContract(Name = "ExpenseConsumeInfo")]
    public partial class ExpenseConsumeInfo : IEquatable<ExpenseConsumeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseConsumeInfo" /> class.
        /// </summary>
        /// <param name="accountId">企业ID.</param>
        /// <param name="actualAccountNumber">实际出资企业支付宝账号.</param>
        /// <param name="batchId">汇总批次ID(废弃).</param>
        /// <param name="billNo">支付流水号.</param>
        /// <param name="billType">账单类型（CONSUME-消费账单、REFUND-退款、TRANSFER-转账）.</param>
        /// <param name="categoryName">账单行业分类（交通出行，餐饮美食，商业服务，日用百货等等）.</param>
        /// <param name="consumeAmount">账单金额（单位：元）.</param>
        /// <param name="consumeDate">交易日期.</param>
        /// <param name="consumeTitle">账单展示标题.</param>
        /// <param name="employeeId">所属员工支付宝uid.</param>
        /// <param name="employeeOpenId">所属员工支付宝uid.</param>
        /// <param name="merchantId">商户id.</param>
        /// <param name="mshopId">门店id.</param>
        /// <param name="openModel">开票模式（汇总开：ENTERPRISE_AUTO_BATCH）.</param>
        /// <param name="originalVoucherId">退款交易关联正交易单号(对应正交易的bill_no).</param>
        /// <param name="outBizNo">外部流水号.</param>
        /// <param name="pPayAmount">企业支付金额（单位：元）.</param>
        /// <param name="payeeName">商家名称.</param>
        /// <param name="projectId">费控规则中的项目ID.</param>
        /// <param name="projiectId">支付使用的项目号（成本中心）此字段废弃.</param>
        /// <param name="refundAmount">消费账单的退款金额（元）.</param>
        /// <param name="refundStatus">消费账单的退款状态.</param>
        /// <param name="standardId">费控规则ID.</param>
        /// <param name="storeId">外部门店id.</param>
        /// <param name="summaryId">批次id.</param>
        /// <param name="tpSign">出资类型： PERSONAL:个人垫付 ENTERPRISE:企业垫资 TP:三方合作伙伴垫资 ACCOUNTING:记账.</param>
        /// <param name="voucherId">凭证ID.</param>
        public ExpenseConsumeInfo(string accountId = default(string), string actualAccountNumber = default(string), string batchId = default(string), string billNo = default(string), string billType = default(string), string categoryName = default(string), string consumeAmount = default(string), string consumeDate = default(string), string consumeTitle = default(string), string employeeId = default(string), string employeeOpenId = default(string), string merchantId = default(string), string mshopId = default(string), string openModel = default(string), string originalVoucherId = default(string), string outBizNo = default(string), string pPayAmount = default(string), string payeeName = default(string), string projectId = default(string), string projiectId = default(string), string refundAmount = default(string), string refundStatus = default(string), string standardId = default(string), string storeId = default(string), string summaryId = default(string), string tpSign = default(string), string voucherId = default(string))
        {
            this.AccountId = accountId;
            this.ActualAccountNumber = actualAccountNumber;
            this.BatchId = batchId;
            this.BillNo = billNo;
            this.BillType = billType;
            this.CategoryName = categoryName;
            this.ConsumeAmount = consumeAmount;
            this.ConsumeDate = consumeDate;
            this.ConsumeTitle = consumeTitle;
            this.EmployeeId = employeeId;
            this.EmployeeOpenId = employeeOpenId;
            this.MerchantId = merchantId;
            this.MshopId = mshopId;
            this.OpenModel = openModel;
            this.OriginalVoucherId = originalVoucherId;
            this.OutBizNo = outBizNo;
            this.PPayAmount = pPayAmount;
            this.PayeeName = payeeName;
            this.ProjectId = projectId;
            this.ProjiectId = projiectId;
            this.RefundAmount = refundAmount;
            this.RefundStatus = refundStatus;
            this.StandardId = standardId;
            this.StoreId = storeId;
            this.SummaryId = summaryId;
            this.TpSign = tpSign;
            this.VoucherId = voucherId;
        }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 实际出资企业支付宝账号
        /// </summary>
        /// <value>实际出资企业支付宝账号</value>
        [DataMember(Name = "actual_account_number", EmitDefaultValue = false)]
        public string ActualAccountNumber { get; set; }

        /// <summary>
        /// 汇总批次ID(废弃)
        /// </summary>
        /// <value>汇总批次ID(废弃)</value>
        [DataMember(Name = "batch_id", EmitDefaultValue = false)]
        public string BatchId { get; set; }

        /// <summary>
        /// 支付流水号
        /// </summary>
        /// <value>支付流水号</value>
        [DataMember(Name = "bill_no", EmitDefaultValue = false)]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单类型（CONSUME-消费账单、REFUND-退款、TRANSFER-转账）
        /// </summary>
        /// <value>账单类型（CONSUME-消费账单、REFUND-退款、TRANSFER-转账）</value>
        [DataMember(Name = "bill_type", EmitDefaultValue = false)]
        public string BillType { get; set; }

        /// <summary>
        /// 账单行业分类（交通出行，餐饮美食，商业服务，日用百货等等）
        /// </summary>
        /// <value>账单行业分类（交通出行，餐饮美食，商业服务，日用百货等等）</value>
        [DataMember(Name = "category_name", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// 账单金额（单位：元）
        /// </summary>
        /// <value>账单金额（单位：元）</value>
        [DataMember(Name = "consume_amount", EmitDefaultValue = false)]
        public string ConsumeAmount { get; set; }

        /// <summary>
        /// 交易日期
        /// </summary>
        /// <value>交易日期</value>
        [DataMember(Name = "consume_date", EmitDefaultValue = false)]
        public string ConsumeDate { get; set; }

        /// <summary>
        /// 账单展示标题
        /// </summary>
        /// <value>账单展示标题</value>
        [DataMember(Name = "consume_title", EmitDefaultValue = false)]
        public string ConsumeTitle { get; set; }

        /// <summary>
        /// 所属员工支付宝uid
        /// </summary>
        /// <value>所属员工支付宝uid</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 所属员工支付宝uid
        /// </summary>
        /// <value>所属员工支付宝uid</value>
        [DataMember(Name = "employee_open_id", EmitDefaultValue = false)]
        public string EmployeeOpenId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        /// <value>商户id</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        /// <value>门店id</value>
        [DataMember(Name = "mshop_id", EmitDefaultValue = false)]
        public string MshopId { get; set; }

        /// <summary>
        /// 开票模式（汇总开：ENTERPRISE_AUTO_BATCH）
        /// </summary>
        /// <value>开票模式（汇总开：ENTERPRISE_AUTO_BATCH）</value>
        [DataMember(Name = "open_model", EmitDefaultValue = false)]
        public string OpenModel { get; set; }

        /// <summary>
        /// 退款交易关联正交易单号(对应正交易的bill_no)
        /// </summary>
        /// <value>退款交易关联正交易单号(对应正交易的bill_no)</value>
        [DataMember(Name = "original_voucher_id", EmitDefaultValue = false)]
        public string OriginalVoucherId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        /// <value>外部流水号</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企业支付金额（单位：元）
        /// </summary>
        /// <value>企业支付金额（单位：元）</value>
        [DataMember(Name = "p_pay_amount", EmitDefaultValue = false)]
        public string PPayAmount { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        /// <value>商家名称</value>
        [DataMember(Name = "payee_name", EmitDefaultValue = false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// 费控规则中的项目ID
        /// </summary>
        /// <value>费控规则中的项目ID</value>
        [DataMember(Name = "project_id", EmitDefaultValue = false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 支付使用的项目号（成本中心）此字段废弃
        /// </summary>
        /// <value>支付使用的项目号（成本中心）此字段废弃</value>
        [DataMember(Name = "projiect_id", EmitDefaultValue = false)]
        public string ProjiectId { get; set; }

        /// <summary>
        /// 消费账单的退款金额（元）
        /// </summary>
        /// <value>消费账单的退款金额（元）</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 消费账单的退款状态
        /// </summary>
        /// <value>消费账单的退款状态</value>
        [DataMember(Name = "refund_status", EmitDefaultValue = false)]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 费控规则ID
        /// </summary>
        /// <value>费控规则ID</value>
        [DataMember(Name = "standard_id", EmitDefaultValue = false)]
        public string StandardId { get; set; }

        /// <summary>
        /// 外部门店id
        /// </summary>
        /// <value>外部门店id</value>
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        /// <value>批次id</value>
        [DataMember(Name = "summary_id", EmitDefaultValue = false)]
        public string SummaryId { get; set; }

        /// <summary>
        /// 出资类型： PERSONAL:个人垫付 ENTERPRISE:企业垫资 TP:三方合作伙伴垫资 ACCOUNTING:记账
        /// </summary>
        /// <value>出资类型： PERSONAL:个人垫付 ENTERPRISE:企业垫资 TP:三方合作伙伴垫资 ACCOUNTING:记账</value>
        [DataMember(Name = "tp_sign", EmitDefaultValue = false)]
        public string TpSign { get; set; }

        /// <summary>
        /// 凭证ID
        /// </summary>
        /// <value>凭证ID</value>
        [DataMember(Name = "voucher_id", EmitDefaultValue = false)]
        public string VoucherId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpenseConsumeInfo {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ActualAccountNumber: ").Append(ActualAccountNumber).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  BillNo: ").Append(BillNo).Append("\n");
            sb.Append("  BillType: ").Append(BillType).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  ConsumeAmount: ").Append(ConsumeAmount).Append("\n");
            sb.Append("  ConsumeDate: ").Append(ConsumeDate).Append("\n");
            sb.Append("  ConsumeTitle: ").Append(ConsumeTitle).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmployeeOpenId: ").Append(EmployeeOpenId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MshopId: ").Append(MshopId).Append("\n");
            sb.Append("  OpenModel: ").Append(OpenModel).Append("\n");
            sb.Append("  OriginalVoucherId: ").Append(OriginalVoucherId).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PPayAmount: ").Append(PPayAmount).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProjiectId: ").Append(ProjiectId).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  RefundStatus: ").Append(RefundStatus).Append("\n");
            sb.Append("  StandardId: ").Append(StandardId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  SummaryId: ").Append(SummaryId).Append("\n");
            sb.Append("  TpSign: ").Append(TpSign).Append("\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
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
            return this.Equals(input as ExpenseConsumeInfo);
        }

        /// <summary>
        /// Returns true if ExpenseConsumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseConsumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseConsumeInfo input)
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
                    this.ActualAccountNumber == input.ActualAccountNumber ||
                    (this.ActualAccountNumber != null &&
                    this.ActualAccountNumber.Equals(input.ActualAccountNumber))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.BillNo == input.BillNo ||
                    (this.BillNo != null &&
                    this.BillNo.Equals(input.BillNo))
                ) && 
                (
                    this.BillType == input.BillType ||
                    (this.BillType != null &&
                    this.BillType.Equals(input.BillType))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.ConsumeAmount == input.ConsumeAmount ||
                    (this.ConsumeAmount != null &&
                    this.ConsumeAmount.Equals(input.ConsumeAmount))
                ) && 
                (
                    this.ConsumeDate == input.ConsumeDate ||
                    (this.ConsumeDate != null &&
                    this.ConsumeDate.Equals(input.ConsumeDate))
                ) && 
                (
                    this.ConsumeTitle == input.ConsumeTitle ||
                    (this.ConsumeTitle != null &&
                    this.ConsumeTitle.Equals(input.ConsumeTitle))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.EmployeeOpenId == input.EmployeeOpenId ||
                    (this.EmployeeOpenId != null &&
                    this.EmployeeOpenId.Equals(input.EmployeeOpenId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MshopId == input.MshopId ||
                    (this.MshopId != null &&
                    this.MshopId.Equals(input.MshopId))
                ) && 
                (
                    this.OpenModel == input.OpenModel ||
                    (this.OpenModel != null &&
                    this.OpenModel.Equals(input.OpenModel))
                ) && 
                (
                    this.OriginalVoucherId == input.OriginalVoucherId ||
                    (this.OriginalVoucherId != null &&
                    this.OriginalVoucherId.Equals(input.OriginalVoucherId))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PPayAmount == input.PPayAmount ||
                    (this.PPayAmount != null &&
                    this.PPayAmount.Equals(input.PPayAmount))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjiectId == input.ProjiectId ||
                    (this.ProjiectId != null &&
                    this.ProjiectId.Equals(input.ProjiectId))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.RefundStatus == input.RefundStatus ||
                    (this.RefundStatus != null &&
                    this.RefundStatus.Equals(input.RefundStatus))
                ) && 
                (
                    this.StandardId == input.StandardId ||
                    (this.StandardId != null &&
                    this.StandardId.Equals(input.StandardId))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.SummaryId == input.SummaryId ||
                    (this.SummaryId != null &&
                    this.SummaryId.Equals(input.SummaryId))
                ) && 
                (
                    this.TpSign == input.TpSign ||
                    (this.TpSign != null &&
                    this.TpSign.Equals(input.TpSign))
                ) && 
                (
                    this.VoucherId == input.VoucherId ||
                    (this.VoucherId != null &&
                    this.VoucherId.Equals(input.VoucherId))
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
                if (this.ActualAccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ActualAccountNumber.GetHashCode();
                }
                if (this.BatchId != null)
                {
                    hashCode = (hashCode * 59) + this.BatchId.GetHashCode();
                }
                if (this.BillNo != null)
                {
                    hashCode = (hashCode * 59) + this.BillNo.GetHashCode();
                }
                if (this.BillType != null)
                {
                    hashCode = (hashCode * 59) + this.BillType.GetHashCode();
                }
                if (this.CategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryName.GetHashCode();
                }
                if (this.ConsumeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeAmount.GetHashCode();
                }
                if (this.ConsumeDate != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeDate.GetHashCode();
                }
                if (this.ConsumeTitle != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeTitle.GetHashCode();
                }
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.EmployeeOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeOpenId.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.MshopId != null)
                {
                    hashCode = (hashCode * 59) + this.MshopId.GetHashCode();
                }
                if (this.OpenModel != null)
                {
                    hashCode = (hashCode * 59) + this.OpenModel.GetHashCode();
                }
                if (this.OriginalVoucherId != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalVoucherId.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PPayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PPayAmount.GetHashCode();
                }
                if (this.PayeeName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeName.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.ProjiectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjiectId.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.RefundStatus != null)
                {
                    hashCode = (hashCode * 59) + this.RefundStatus.GetHashCode();
                }
                if (this.StandardId != null)
                {
                    hashCode = (hashCode * 59) + this.StandardId.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.SummaryId != null)
                {
                    hashCode = (hashCode * 59) + this.SummaryId.GetHashCode();
                }
                if (this.TpSign != null)
                {
                    hashCode = (hashCode * 59) + this.TpSign.GetHashCode();
                }
                if (this.VoucherId != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherId.GetHashCode();
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
