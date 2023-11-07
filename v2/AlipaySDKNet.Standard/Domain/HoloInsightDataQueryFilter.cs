using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HoloInsightDataQueryFilter Data Structure.
    /// </summary>
    [Serializable]
    public class HoloInsightDataQueryFilter : AopObject
    {
        /// <summary>
        /// 主机名字符串
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 等于
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 主机名为 test-host
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
