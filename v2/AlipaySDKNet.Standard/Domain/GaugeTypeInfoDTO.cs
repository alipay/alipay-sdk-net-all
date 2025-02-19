using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GaugeTypeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GaugeTypeInfoDTO : AopObject
    {
        /// <summary>
        /// 量表唯一主键
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 量表名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 量表问题总数
        /// </summary>
        [XmlElement("ques_count")]
        public long QuesCount { get; set; }

        /// <summary>
        /// 具体的量表类型字类型
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 量表类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
