using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MutipleCurrencyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MutipleCurrencyDetail : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付金额，单位为该币种基础计价单位，如人民币为：元
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 支付币种
        /// </summary>
        [XmlElement("payment_currency")]
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// 清算金额，单位为该币种基础计价单位，如人民币为：元
        /// </summary>
        [XmlElement("settlement_amount")]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// 清算币种
        /// </summary>
        [XmlElement("settlement_currency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// 转账金额，单位为该币种基础计价单位，如人民币为：元
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 转账币种
        /// </summary>
        [XmlElement("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
