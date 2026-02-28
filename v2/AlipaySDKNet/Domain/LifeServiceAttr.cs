using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceAttr Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceAttr : AopObject
    {
        /// <summary>
        /// 生活服务属性key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 生活服务属性value
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
