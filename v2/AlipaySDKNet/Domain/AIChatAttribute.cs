using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AIChatAttribute Data Structure.
    /// </summary>
    [Serializable]
    public class AIChatAttribute : AopObject
    {
        /// <summary>
        /// 甜度
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 五分糖
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
