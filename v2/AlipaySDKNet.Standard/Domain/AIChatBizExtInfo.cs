using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AIChatBizExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AIChatBizExtInfo : AopObject
    {
        /// <summary>
        /// 键
        /// </summary>
        [XmlElement("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [XmlElement("ext_value")]
        public string ExtValue { get; set; }
    }
}
