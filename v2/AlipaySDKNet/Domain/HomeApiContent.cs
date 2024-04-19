using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HomeApiContent Data Structure.
    /// </summary>
    [Serializable]
    public class HomeApiContent : AopObject
    {
        /// <summary>
        /// 参数的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数value值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
