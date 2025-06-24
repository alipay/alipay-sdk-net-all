using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQcMetadata Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQcMetadata : AopObject
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
