using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessOrderOrderinfoSyncResponse.
    /// </summary>
    public class AlipayBusinessOrderOrderinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
