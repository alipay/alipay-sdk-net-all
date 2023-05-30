using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModuleValueVO Data Structure.
    /// </summary>
    [Serializable]
    public class ModuleValueVO : AopObject
    {
        /// <summary>
        /// 模块属性值id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 模块属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
