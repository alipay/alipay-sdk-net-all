using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceTimeInfo : AopObject
    {
        /// <summary>
        /// 提前预约时间，单位分钟，大于0
        /// </summary>
        [XmlElement("advance_time")]
        public long AdvanceTime { get; set; }

        /// <summary>
        /// 时间节点，精确到分，“-” 分隔符
        /// </summary>
        [XmlArray("time_nodes")]
        [XmlArrayItem("string")]
        public List<string> TimeNodes { get; set; }
    }
}
