using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SoundNodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SoundNodeInfo : AopObject
    {
        /// <summary>
        /// 声音某个时间节点的内容概要
        /// </summary>
        [XmlElement("node_desc")]
        public string NodeDesc { get; set; }

        /// <summary>
        /// 声音的某个时间节点，格式是hh:mm:ss
        /// </summary>
        [XmlElement("node_time")]
        public string NodeTime { get; set; }
    }
}
