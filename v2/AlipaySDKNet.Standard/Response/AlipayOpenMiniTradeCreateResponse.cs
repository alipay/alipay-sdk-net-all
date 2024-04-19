using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniTradeCreateResponse.
    /// </summary>
    public class AlipayOpenMiniTradeCreateResponse : AopResponse
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("mini_trade_no")]
        public string MiniTradeNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
