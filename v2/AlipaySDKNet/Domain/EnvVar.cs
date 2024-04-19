using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnvVar Data Structure.
    /// </summary>
    [Serializable]
    public class EnvVar : AopObject
    {
        /// <summary>
        /// 自定义环境变量Key值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 自定义环境变量value值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
