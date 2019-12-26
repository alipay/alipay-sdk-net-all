using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEprintTaskSubmitResponse.
    /// </summary>
    public class AlipayEcoEprintTaskSubmitResponse : AopResponse
    {
        /// <summary>
        /// 云平台订单ID
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }
    }
}
