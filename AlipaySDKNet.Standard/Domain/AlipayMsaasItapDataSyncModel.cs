using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasItapDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasItapDataSyncModel : AopObject
    {
        /// <summary>
        /// 设备数据同步通知消息体
        /// </summary>
        [XmlElement("payload")]
        public DataSyncPayload Payload { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
