using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryAttributeInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryAttributeInfoVO : AopObject
    {
        /// <summary>
        /// 属性code
        /// </summary>
        [XmlElement("attr_code")]
        public string AttrCode { get; set; }

        /// <summary>
        /// 属性KEY
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// 属性类型
        /// </summary>
        [XmlElement("attr_type")]
        public string AttrType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("attr_value_list")]
        [XmlArrayItem("attribute_value_info")]
        public List<AttributeValueInfo> AttrValueList { get; set; }

        /// <summary>
        /// 属性值类型
        /// </summary>
        [XmlElement("attr_value_type")]
        public string AttrValueType { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 提报商品时该属性是否支持自定义输入
        /// </summary>
        [XmlElement("custom_input")]
        public string CustomInput { get; set; }

        /// <summary>
        /// 提报商品时该属性是否支持多选
        /// </summary>
        [XmlElement("multi_select")]
        public string MultiSelect { get; set; }

        /// <summary>
        /// 提报商品时该属性是否必填
        /// </summary>
        [XmlElement("required")]
        public string Required { get; set; }

        /// <summary>
        /// 属性状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
