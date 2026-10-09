using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OuterProductVO Data Structure.
    /// </summary>
    [Serializable]
    public class OuterProductVO : AopObject
    {
        /// <summary>
        /// 模块列表
        /// </summary>
        [XmlArray("module_items")]
        [XmlArrayItem("module_v_o")]
        public List<ModuleVO> ModuleItems { get; set; }

        /// <summary>
        /// 对外产品code
        /// </summary>
        [XmlElement("outer_product_code")]
        public string OuterProductCode { get; set; }

        /// <summary>
        /// 对外产品id
        /// </summary>
        [XmlElement("outer_product_id")]
        public string OuterProductId { get; set; }
    }
}
