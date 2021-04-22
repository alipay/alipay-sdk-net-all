using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateTradeCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateTradeCreateResponse : AopResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("edu_trade_no")]
        public string EduTradeNo { get; set; }
    }
}
