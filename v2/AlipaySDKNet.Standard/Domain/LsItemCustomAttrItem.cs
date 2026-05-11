using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LsItemCustomAttrItem Data Structure.
    /// </summary>
    [Serializable]
    public class LsItemCustomAttrItem : AopObject
    {
        /// <summary>
        /// 自定义属性的属性名
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// 自定义属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
