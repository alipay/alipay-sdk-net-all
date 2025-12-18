using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAntmcceventOutboundcallSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmAntmcceventOutboundcallSyncModel : AopObject
    {
        /// <summary>
        /// 标准事件业务数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// envId
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("event_timestamp")]
        public long EventTimestamp { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// appId
        /// </summary>
        [XmlElement("im_app_id")]
        public string ImAppId { get; set; }

        /// <summary>
        /// 服务渠道类型，ONLINE-在线，HOTLINE-热线
        /// </summary>
        [XmlElement("service_channel")]
        public string ServiceChannel { get; set; }

        /// <summary>
        /// antmcc
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 标准事件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
