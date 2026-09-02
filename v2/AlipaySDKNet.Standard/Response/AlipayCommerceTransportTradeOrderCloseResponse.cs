using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTradeOrderCloseResponse.
    /// </summary>
    public class AlipayCommerceTransportTradeOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 恒星平台订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 商户侧业务流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户侧业务子流水号
        /// </summary>
        [XmlElement("out_sub_biz_no")]
        public string OutSubBizNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
