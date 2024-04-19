using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GfsmartpayExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GfsmartpayExtInfo : AopObject
    {
        /// <summary>
        /// 用户参数的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 用户自定义参数的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
