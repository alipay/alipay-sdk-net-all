using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpuDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpuDetailInfo : AopObject
    {
        /// <summary>
        /// 商品分类
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品分类id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品goods id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品可售状态
        /// </summary>
        [XmlElement("sales_status")]
        public string SalesStatus { get; set; }

        /// <summary>
        /// 商品可售状态
        /// </summary>
        [XmlElement("sales_status_desc")]
        public string SalesStatusDesc { get; set; }

        /// <summary>
        /// 商品spuid
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }
    }
}
