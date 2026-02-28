using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfItemAttr Data Structure.
    /// </summary>
    [Serializable]
    public class AxfItemAttr : AopObject
    {
        /// <summary>
        /// 商品属性key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 商品属性key对应的名称
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// 商品属性value
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }

        /// <summary>
        /// 根据商品描述信息和商品属性value生成，如每张清洗X小时，对应属性值是1，则返回的是每张清洗1小时
        /// </summary>
        [XmlElement("show_text")]
        public string ShowText { get; set; }
    }
}
