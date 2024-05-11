using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsInfoDetail : AopObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("goods_desc")]
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 商品名称，由isv传入
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 商品单价 单位：元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 数量单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
