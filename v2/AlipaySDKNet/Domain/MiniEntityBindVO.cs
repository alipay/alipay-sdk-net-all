using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniEntityBindVO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniEntityBindVO : AopObject
    {
        /// <summary>
        /// 实体id，具体场景见产品文档
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 主体id，具体场景含义见产品文档
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 属性列表，具体属性见产品文档
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("mini_content_property")]
        public List<MiniContentProperty> PropertyList { get; set; }
    }
}
