using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AcmeKeyConfig Data Structure.
    /// </summary>
    [Serializable]
    public class AcmeKeyConfig : AopObject
    {
        /// <summary>
        /// key详情
        /// </summary>
        [XmlElement("key_description")]
        public string KeyDescription { get; set; }

        /// <summary>
        /// key名称
        /// </summary>
        [XmlElement("key_name")]
        public string KeyName { get; set; }

        /// <summary>
        /// key的值
        /// </summary>
        [XmlElement("key_value")]
        public string KeyValue { get; set; }
    }
}
