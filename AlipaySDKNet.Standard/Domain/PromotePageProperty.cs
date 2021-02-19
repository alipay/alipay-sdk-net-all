using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromotePageProperty Data Structure.
    /// </summary>
    [Serializable]
    public class PromotePageProperty : AopObject
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
    }
}
