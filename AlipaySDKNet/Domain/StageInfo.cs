using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StageInfo : AopObject
    {
        /// <summary>
        /// 分组 1: A 2: B 以此类推
        /// </summary>
        [XmlElement("group")]
        public long Group { get; set; }

        /// <summary>
        /// 阶段名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 轮次
        /// </summary>
        [XmlElement("round")]
        public long Round { get; set; }

        /// <summary>
        /// 阶段类型 1: 积分赛 2: 淘汰赛
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
