using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalCateProperty Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalCateProperty : AopObject
    {
        /// <summary>
        /// 条件必填说明
        /// </summary>
        [XmlElement("condition_note")]
        public string ConditionNote { get; set; }

        /// <summary>
        /// 配置信息
        /// </summary>
        [XmlElement("config")]
        public string Config { get; set; }

        /// <summary>
        /// 属性别名
        /// </summary>
        [XmlElement("property_alias")]
        public string PropertyAlias { get; set; }

        /// <summary>
        /// 属性ID
        /// </summary>
        [XmlElement("property_id")]
        public string PropertyId { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("property_name")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 属性类型
        /// </summary>
        [XmlElement("property_type")]
        public string PropertyType { get; set; }

        /// <summary>
        /// 属性值列表
        /// </summary>
        [XmlArray("property_value_list")]
        [XmlArrayItem("external_cate_property_value")]
        public List<ExternalCatePropertyValue> PropertyValueList { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [XmlElement("required")]
        public string Required { get; set; }

        /// <summary>
        /// 属性值类型
        /// </summary>
        [XmlElement("value_type")]
        public string ValueType { get; set; }
    }
}
