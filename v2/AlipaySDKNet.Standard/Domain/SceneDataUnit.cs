using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneDataUnit Data Structure.
    /// </summary>
    [Serializable]
    public class SceneDataUnit : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 实际值：例如name是应用名   那么 value值就是对应的aone的应用英文名
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
