using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountBillQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 外部交易号
        /// </summary>
        [XmlElement("charge_no")]
        public string ChargeNo { get; set; }

        /// <summary>
        /// 分期服务费
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("pay_trade_no")]
        public string PayTradeNo { get; set; }

        /// <summary>
        /// 账单交易金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
