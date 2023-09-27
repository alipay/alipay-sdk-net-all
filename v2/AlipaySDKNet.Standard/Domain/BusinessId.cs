using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessId Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessId : AopObject
    {
        /// <summary>
        /// 接入任务中心，系统分类二级code
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 接入任务中心，系统分类一级code
        /// </summary>
        [XmlElement("system_type")]
        public string SystemType { get; set; }
    }
}
