using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdSummary Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdSummary : AopObject
    {
        /// <summary>
        /// 人群数量
        /// </summary>
        [XmlElement("crowd_count")]
        public long CrowdCount { get; set; }

        /// <summary>
        /// 生活号人群id
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 人群状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
