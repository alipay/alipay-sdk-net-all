using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttrExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AttrExtInfoDTO : AopObject
    {
        /// <summary>
        /// 属性key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 行业属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
