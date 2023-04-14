using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderGoodsInfo : AopObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("goods_desc")]
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 光华服务编码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品图标
        /// </summary>
        [XmlElement("goods_pic")]
        public string GoodsPic { get; set; }

        /// <summary>
        /// 单位描述
        /// </summary>
        [XmlElement("goods_specs")]
        public string GoodsSpecs { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
