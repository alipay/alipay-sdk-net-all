using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpuInfo : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品提供方，店铺或品牌方
        /// </summary>
        [XmlElement("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }
    }
}
