using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerPayPrecreateResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerPayPrecreateResponse : AopResponse
    {
        /// <summary>
        /// 行业支付订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
