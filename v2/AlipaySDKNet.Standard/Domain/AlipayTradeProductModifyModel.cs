using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeProductModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeProductModifyModel : AopObject
    {
        /// <summary>
        /// 该商品默认价格id
        /// </summary>
        [XmlElement("default_price_id")]
        public string DefaultPriceId { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品元数据
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 本次更新的商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
