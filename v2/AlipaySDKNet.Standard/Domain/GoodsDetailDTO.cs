using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsDetailDTO : AopObject
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品单价。单位 元  精确到小数点后2位。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
