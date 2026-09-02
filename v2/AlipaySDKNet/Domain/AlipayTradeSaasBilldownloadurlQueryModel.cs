using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasBilldownloadurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasBilldownloadurlQueryModel : AopObject
    {
        /// <summary>
        /// 账单日期，格式为 yyyy-MM-dd，且必须早于当前日期。
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单类型。支持银行资金账单、SaaS交易账单、支付宝交易账单和支付宝资金账单。
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }
    }
}
