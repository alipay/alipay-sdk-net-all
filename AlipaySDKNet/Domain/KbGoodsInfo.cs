using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbGoodsInfo : AopObject
    {
        /// <summary>
        /// 商品类目
        /// </summary>
        [XmlElement("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }
    }
}
