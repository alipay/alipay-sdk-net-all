using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopContactWayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopContactWayInfo : AopObject
    {
        /// <summary>
        /// 联系类型
        /// </summary>
        [XmlElement("contact_type")]
        public string ContactType { get; set; }

        /// <summary>
        /// 联系值
        /// </summary>
        [XmlElement("contact_value")]
        public string ContactValue { get; set; }
    }
}
