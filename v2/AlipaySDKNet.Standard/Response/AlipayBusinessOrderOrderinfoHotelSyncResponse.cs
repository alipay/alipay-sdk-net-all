using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessOrderOrderinfoHotelSyncResponse.
    /// </summary>
    public class AlipayBusinessOrderOrderinfoHotelSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝酒店订单id
        /// </summary>
        [XmlElement("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 支付宝酒店订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
