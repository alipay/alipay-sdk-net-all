using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SummaryBillOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SummaryBillOpenApiDTO : AopObject
    {
        /// <summary>
        /// 调账金额
        /// </summary>
        [XmlElement("adjust_amount")]
        public MultiCurrencyMoneyOpenApi AdjustAmount { get; set; }

        /// <summary>
        /// 账单金额
        /// </summary>
        [XmlElement("bill_amount")]
        public MultiCurrencyMoneyOpenApi BillAmount { get; set; }

        /// <summary>
        /// 账单月份
        /// </summary>
        [XmlElement("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 账单编码
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// UNCHECKED("unchecked", "未出账"), PARTIAL_CHECK("partial_checked","部分出账"), CHECKED("checked", "已出账"), CONFIRMED("confirmed", "账单已确认");
        /// </summary>
        [XmlElement("bill_status")]
        public string BillStatus { get; set; }

        /// <summary>
        /// 业财身份编码
        /// </summary>
        [XmlElement("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 资金结算时点
        /// </summary>
        [XmlElement("fund_settle_time")]
        public string FundSettleTime { get; set; }

        /// <summary>
        /// 机构OU
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 收款方pid
        /// </summary>
        [XmlElement("payee_ip_role_id")]
        public string PayeeIpRoleId { get; set; }

        /// <summary>
        /// 真实账单金额 = 账单金额 + 调账金额
        /// </summary>
        [XmlElement("real_bill_amount")]
        public MultiCurrencyMoneyOpenApi RealBillAmount { get; set; }

        /// <summary>
        /// 结算对象pid
        /// </summary>
        [XmlElement("settle_ip_role_id")]
        public string SettleIpRoleId { get; set; }

        /// <summary>
        /// 结算状态 code 部分核销 partial_settled、未核销 none_settled、已核销 complelte_settled
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 结算时间类型 real、delayed
        /// </summary>
        [XmlElement("settle_time_type")]
        public string SettleTimeType { get; set; }

        /// <summary>
        /// 已结算金额
        /// </summary>
        [XmlElement("settled_amount")]
        public MultiCurrencyMoneyOpenApi SettledAmount { get; set; }

        /// <summary>
        /// 调用者系统名称
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
