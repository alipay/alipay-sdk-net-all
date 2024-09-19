using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactWayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContactWayInfo : AopObject
    {
        /// <summary>
        /// 联系方式的类型，枚举
        /// </summary>
        [XmlElement("contact_type")]
        public string ContactType { get; set; }

        /// <summary>
        /// 联系方式具体的值
        /// </summary>
        [XmlElement("contact_value")]
        public string ContactValue { get; set; }
    }
}
