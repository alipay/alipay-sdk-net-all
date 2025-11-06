using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCsfuWecomSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCsfuWecomSyncModel : AopObject
    {
        /// <summary>
        /// 业务数据
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
        /// source
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// tntInst_id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// type
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
