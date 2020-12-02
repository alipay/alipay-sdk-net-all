using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpuDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SpuDetail : AopObject
    {
        /// <summary>
        /// 商品品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 商品链接
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
