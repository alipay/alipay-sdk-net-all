using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallSkuAttrValue Data Structure.
    /// </summary>
    [Serializable]
    public class MallSkuAttrValue : AopObject
    {
        /// <summary>
        /// 规格报价上的属性英文名称
        /// </summary>
        [XmlElement("attr_en_name")]
        public string AttrEnName { get; set; }

        /// <summary>
        /// 属性值名称的英文版本
        /// </summary>
        [XmlElement("attr_en_value")]
        public string AttrEnValue { get; set; }

        /// <summary>
        /// 商品规格报价属性Id
        /// </summary>
        [XmlElement("attr_id")]
        public long AttrId { get; set; }

        /// <summary>
        /// 属性中文名称
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// 用户勾选（或填写）的属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }

        /// <summary>
        /// 属性值ID
        /// </summary>
        [XmlElement("attr_value_id")]
        public long AttrValueId { get; set; }

        /// <summary>
        /// 商品规格主键
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }
    }
}
