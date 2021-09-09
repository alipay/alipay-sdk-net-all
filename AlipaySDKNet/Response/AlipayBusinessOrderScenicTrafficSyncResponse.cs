using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessOrderScenicTrafficSyncResponse.
    /// </summary>
    public class AlipayBusinessOrderScenicTrafficSyncResponse : AopResponse
    {
        /// <summary>
        /// 行业侧入住单唯一标识。
        /// </summary>
        [XmlElement("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 订单最新状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
