using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseControlQuotaPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseControlQuotaPayInfo : AopObject
    {
        /// <summary>
        /// 金额（分）
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 对应的规则ID
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 已扣减 - DEDUCTED 已恢复 - RECOVERED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝正向交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
