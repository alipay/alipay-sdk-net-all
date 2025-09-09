using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationPointClearResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationPointClearResponse : AopResponse
    {
        /// <summary>
        /// 积分id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 实际扣减的积分数，单位为个
        /// </summary>
        [XmlElement("real_point")]
        public long RealPoint { get; set; }
    }
}
