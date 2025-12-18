using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCsfufinanceAntmcceventSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCsfufinanceAntmcceventSyncModel : AopObject
    {
        /// <summary>
        /// 事件数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// im分配的环境id
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
        /// im分配的应用id
        /// </summary>
        [XmlElement("im_app_id")]
        public string ImAppId { get; set; }

        /// <summary>
        /// 服务渠道类型
        /// </summary>
        [XmlElement("service_channel")]
        public string ServiceChannel { get; set; }

        /// <summary>
        /// 来源系统，默认为ccmimplus
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// im分配的租户id
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
