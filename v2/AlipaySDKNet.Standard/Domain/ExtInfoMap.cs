using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtInfoMap Data Structure.
    /// </summary>
    [Serializable]
    public class ExtInfoMap : AopObject
    {
        /// <summary>
        /// 键值对的key，{"orderId":"123456"}中的orderId
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 键值对的value，{"orderId":"123456"} 中的123456
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
