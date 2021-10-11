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
        /// 公司账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 实际出资账号（实际出资人实名认证名称)
        /// </summary>
        [XmlElement("actual_account_number")]
        public string ActualAccountNumber { get; set; }

        /// <summary>
        /// 汇总批次id
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
        /// 账单金额
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
        /// 开票模式
        /// </summary>
        [XmlElement("open_model")]
        public string OpenModel { get; set; }

        /// <summary>
        /// 退款交易关联正交易单号
        /// </summary>
        [XmlElement("original_voucher_id")]
        public string OriginalVoucherId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企业代付金额
        /// </summary>
        [XmlElement("p_pay_amount")]
        public string PPayAmount { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 费控制度中的项目编号
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 支付使用的项目号（成本中心）此字段废弃
        /// </summary>
        [XmlElement("projiect_id")]
        public string ProjiectId { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// tp标志位
        /// </summary>
        [XmlElement("tp_sign")]
        public string TpSign { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
