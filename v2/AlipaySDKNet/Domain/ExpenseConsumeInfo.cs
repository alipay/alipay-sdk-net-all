using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseConsumeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseConsumeInfo : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 实际出资企业支付宝账号
        /// </summary>
        [XmlElement("actual_account_number")]
        public string ActualAccountNumber { get; set; }

        /// <summary>
        /// 汇总批次ID(废弃)
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 支付流水号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单类型（CONSUME-消费账单、REFUND-退款、TRANSFER-转账）
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 账单行业分类（交通出行，餐饮美食，商业服务，日用百货等等）
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 账单金额（单位：元）
        /// </summary>
        [XmlElement("consume_amount")]
        public string ConsumeAmount { get; set; }

        /// <summary>
        /// 交易日期
        /// </summary>
        [XmlElement("consume_date")]
        public string ConsumeDate { get; set; }

        /// <summary>
        /// 账单展示标题
        /// </summary>
        [XmlElement("consume_title")]
        public string ConsumeTitle { get; set; }

        /// <summary>
        /// 所属员工支付宝uid
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 所属员工支付宝uid
        /// </summary>
        [XmlElement("employee_open_id")]
        public string EmployeeOpenId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("mshop_id")]
        public string MshopId { get; set; }

        /// <summary>
        /// 开票模式（汇总开：ENTERPRISE_AUTO_BATCH）
        /// </summary>
        [XmlElement("open_model")]
        public string OpenModel { get; set; }

        /// <summary>
        /// 退款交易关联正交易单号(对应正交易的bill_no)
        /// </summary>
        [XmlElement("original_voucher_id")]
        public string OriginalVoucherId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企业支付金额（单位：元）
        /// </summary>
        [XmlElement("p_pay_amount")]
        public string PPayAmount { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 费控规则中的项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 支付使用的项目号（成本中心）此字段废弃
        /// </summary>
        [XmlElement("projiect_id")]
        public string ProjiectId { get; set; }

        /// <summary>
        /// 消费账单的退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 消费账单的退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 费控规则ID
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 外部门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        [XmlElement("summary_id")]
        public string SummaryId { get; set; }

        /// <summary>
        /// 出资类型： PERSONAL:个人垫付 ENTERPRISE:企业垫资 TP:三方合作伙伴垫资 ACCOUNTING:记账
        /// </summary>
        [XmlElement("tp_sign")]
        public string TpSign { get; set; }

        /// <summary>
        /// 凭证ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
