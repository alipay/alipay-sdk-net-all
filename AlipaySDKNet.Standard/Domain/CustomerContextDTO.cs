using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerContextDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerContextDTO : AopObject
    {
        /// <summary>
        /// 自定义业务参数的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 自定义业务参数的value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
