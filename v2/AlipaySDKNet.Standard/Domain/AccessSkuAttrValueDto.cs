using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessSkuAttrValueDto Data Structure.
    /// </summary>
    [Serializable]
    public class AccessSkuAttrValueDto : AopObject
    {
        /// <summary>
        /// attr_name，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// attr_value_name，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("attr_value_name")]
        public string AttrValueName { get; set; }
    }
}
