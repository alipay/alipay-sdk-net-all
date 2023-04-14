using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditQuotaDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CreditQuotaDetail : AopObject
    {
        /// <summary>
        /// 授信期限
        /// </summary>
        [XmlElement("credit_term")]
        public string CreditTerm { get; set; }

        /// <summary>
        /// 授信期限单位，DAY-日，MONTH-月，YEAR-年
        /// </summary>
        [XmlElement("credit_term_unit")]
        public string CreditTermUnit { get; set; }

        /// <summary>
        /// 授信有效期结束日，格式（yyyy-MM-dd）
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 额度类型，CREDIT - 信用，ORDER - 订单，MORTGAGE - 抵押，MAXIMUM - 最大额度
        /// </summary>
        [XmlElement("loan_quota_type")]
        public string LoanQuotaType { get; set; }

        /// <summary>
        /// 申请授信额度，币种最小单位，如果是CNY，则单位分
        /// </summary>
        [XmlElement("quota_amount")]
        public long QuotaAmount { get; set; }

        /// <summary>
        /// 申请授信额度币种
        /// </summary>
        [XmlElement("quota_amount_currency")]
        public string QuotaAmountCurrency { get; set; }

        /// <summary>
        /// 授信有效期开始日，格式（yyyy-MM-dd）
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
