using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTradeOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportTradeOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 异步代扣描述情况
        /// </summary>
        [XmlElement("async_pay_description")]
        public string AsyncPayDescription { get; set; }

        /// <summary>
        /// 代扣订单平台创建订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 是否异步代扣
        /// </summary>
        [XmlElement("is_async_pay")]
        public string IsAsyncPay { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 代扣订单交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
