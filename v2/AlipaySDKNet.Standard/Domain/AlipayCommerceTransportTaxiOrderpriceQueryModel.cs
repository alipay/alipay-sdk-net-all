using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiOrderpriceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiOrderpriceQueryModel : AopObject
    {
        /// <summary>
        /// 订单渠道类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 出租车订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 请求时间，Unix Timestamp单位毫秒
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
