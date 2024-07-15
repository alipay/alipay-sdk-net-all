using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDetailInfo : AopObject
    {
        /// <summary>
        /// 商品扩展信息，目前只有单品补贴金额
        /// </summary>
        [XmlElement("ext_info")]
        public PromoItemExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 商家侧商品ID，是商户侧商品的唯一标识，由商家自定义，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部skuid
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品的单价（元）
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
