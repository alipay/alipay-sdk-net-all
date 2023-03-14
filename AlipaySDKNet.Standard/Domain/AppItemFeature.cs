using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemFeature Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemFeature : AopObject
    {
        /// <summary>
        /// 属性key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
