using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfItemAttrTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class AxfItemAttrTemplate : AopObject
    {
        /// <summary>
        /// 属性说明
        /// </summary>
        [XmlElement("attr_desc")]
        public string AttrDesc { get; set; }

        /// <summary>
        /// 属性key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// 商品属性
        /// </summary>
        [XmlElement("attr_type")]
        public string AttrType { get; set; }

        /// <summary>
        /// 所属类目编码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("enum_values")]
        [XmlArrayItem("axf_enum_value_item")]
        public List<AxfEnumValueItem> EnumValues { get; set; }

        /// <summary>
        /// 是否可枚举
        /// </summary>
        [XmlElement("enumerable")]
        public bool Enumerable { get; set; }

        /// <summary>
        /// 是否可输入
        /// </summary>
        [XmlElement("input")]
        public bool Input { get; set; }

        /// <summary>
        /// 是否多选
        /// </summary>
        [XmlElement("multiple")]
        public bool Multiple { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }
    }
}
