using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoActivityAttrVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoActivityAttrVO : AopObject
    {
        /// <summary>
        /// 属性的 key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 是否多选
        /// </summary>
        [XmlElement("multi")]
        public bool Multi { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 可选项列表
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("promo_activity_attr_option_v_o")]
        public List<PromoActivityAttrOptionVO> Options { get; set; }

        /// <summary>
        /// 该属性是否必填
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }
    }
}
