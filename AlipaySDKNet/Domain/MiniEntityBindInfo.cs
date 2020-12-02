using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniEntityBindInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniEntityBindInfo : AopObject
    {
        /// <summary>
        /// 实体id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 属性列表
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("mini_content_property_info")]
        public List<MiniContentPropertyInfo> PropertyList { get; set; }
    }
}
