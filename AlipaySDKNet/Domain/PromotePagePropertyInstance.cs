using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromotePagePropertyInstance Data Structure.
    /// </summary>
    [Serializable]
    public class PromotePagePropertyInstance : AopObject
    {
        /// <summary>
        /// 留资属性key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 留资属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 留资属性实例值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
