using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiBenefitOrderCloseResponse.
    /// </summary>
    public class AlipayPcreditHuabeiBenefitOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 权益订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户侧唯一请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
