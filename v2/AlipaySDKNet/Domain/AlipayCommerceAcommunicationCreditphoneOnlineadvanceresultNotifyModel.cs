using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneOnlineadvanceresultNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphoneOnlineadvanceresultNotifyModel : AopObject
    {
        /// <summary>
        /// 支付宝在线提前结清测算单号
        /// </summary>
        [XmlElement("alipay_online_advance_pay_order_no")]
        public string AlipayOnlineAdvancePayOrderNo { get; set; }

        /// <summary>
        /// 机构侧测算单号
        /// </summary>
        [XmlElement("inst_pay_order_no")]
        public string InstPayOrderNo { get; set; }

        /// <summary>
        /// 机构侧支付单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易金额，单位 元
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [XmlElement("trade_finish_time")]
        public string TradeFinishTime { get; set; }

        /// <summary>
        /// 支付宝侧支付单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
