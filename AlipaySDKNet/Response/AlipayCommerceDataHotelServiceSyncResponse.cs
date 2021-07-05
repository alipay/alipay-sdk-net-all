using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDataHotelServiceSyncResponse.
    /// </summary>
    public class AlipayCommerceDataHotelServiceSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝行业侧服务的标识
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
