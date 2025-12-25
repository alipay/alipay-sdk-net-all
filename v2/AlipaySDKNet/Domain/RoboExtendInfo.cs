using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboExtendInfo : AopObject
    {
        /// <summary>
        /// 补充属性key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 补充属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
