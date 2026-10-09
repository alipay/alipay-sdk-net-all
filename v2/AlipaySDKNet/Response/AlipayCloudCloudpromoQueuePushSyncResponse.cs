using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoQueuePushSyncResponse.
    /// </summary>
    public class AlipayCloudCloudpromoQueuePushSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步订单
        /// </summary>
        [XmlElement("queue_sync")]
        public string QueueSync { get; set; }
    }
}
