using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportCarbonDataQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportCarbonDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回碳积分记录数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
