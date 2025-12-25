using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmEquityorderCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmEquityorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
