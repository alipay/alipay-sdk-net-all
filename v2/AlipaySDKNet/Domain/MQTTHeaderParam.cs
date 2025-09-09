using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MQTTHeaderParam Data Structure.
    /// </summary>
    [Serializable]
    public class MQTTHeaderParam : AopObject
    {
        /// <summary>
        /// MQTT协议请求头参数名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// MQTT协议 请求头取值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
