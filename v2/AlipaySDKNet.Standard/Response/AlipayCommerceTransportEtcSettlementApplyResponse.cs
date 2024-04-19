using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcSettlementApplyResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcSettlementApplyResponse : AopResponse
    {
        /// <summary>
        /// 行程描述：行程号xxx
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 行程单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 行程总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 行程扣款阶段性错误信息
        /// </summary>
        [XmlElement("trade_biz_code")]
        public string TradeBizCode { get; set; }

        /// <summary>
        /// 行程扣款阶段性错误信息
        /// </summary>
        [XmlElement("trade_biz_msg")]
        public string TradeBizMsg { get; set; }

        /// <summary>
        /// 支付宝交易号，只有交易支付成功后才会返回
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 行程交易处理状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 支付宝保存的ETC行程Id
        /// </summary>
        [XmlElement("trip_id")]
        public string TripId { get; set; }
    }
}
