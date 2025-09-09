using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsightDistItem Data Structure.
    /// </summary>
    [Serializable]
    public class InsightDistItem : AopObject
    {
        /// <summary>
        /// 分布区间的名字，比如男女，年龄段等
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分布区间的值，代表百分比
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
