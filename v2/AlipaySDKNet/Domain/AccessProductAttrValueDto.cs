using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessProductAttrValueDto Data Structure.
    /// </summary>
    [Serializable]
    public class AccessProductAttrValueDto : AopObject
    {
        /// <summary>
        /// attr_name，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// attr_value_name_list，用于商品同步，由调用方传入
        /// </summary>
        [XmlArray("attr_value_name_list")]
        [XmlArrayItem("string")]
        public List<string> AttrValueNameList { get; set; }
    }
}
