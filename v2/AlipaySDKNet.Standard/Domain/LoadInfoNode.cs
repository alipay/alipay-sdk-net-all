using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoadInfoNode Data Structure.
    /// </summary>
    [Serializable]
    public class LoadInfoNode : AopObject
    {
        /// <summary>
        /// 节点结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 负荷信息，单位 kw
        /// </summary>
        [XmlElement("load")]
        public string Load { get; set; }

        /// <summary>
        /// 节点开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
