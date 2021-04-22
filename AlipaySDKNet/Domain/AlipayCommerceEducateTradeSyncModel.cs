using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTradeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTradeSyncModel : AopObject
    {
        /// <summary>
        /// 教育账单编号
        /// </summary>
        [XmlElement("edu_trade_no")]
        public string EduTradeNo { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 实际支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 实际支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态：1-等待支付；2-超时关闭；3-支付成功；4-交易结束（不可退款）;5-已退款
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
