using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplyorderCreateormodifyResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcApplyorderCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝ETC申请单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }
    }
}
