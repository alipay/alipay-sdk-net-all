using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDirectModifySku Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDirectModifySku : AopObject
    {
        /// <summary>
        /// sku原价，分为单位。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧自定义sku ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// sku售价，分为单位，当更新商品为租赁套餐的商品时，售价字段不生效，需要填租赁套餐里的totalSalePrice代表商品售价
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// sku售卖状态，包含以下两种状态： 已下架(DELISTING) 可售卖(AVAILABLE) 已下架: DELISTING 可售卖: AVAILABLE
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 商品sku属性，当更新商品是租赁套餐商品时，sku_attrs必须传rent_commodity租赁套餐属性
        /// </summary>
        [XmlArray("sku_attrs")]
        [XmlArrayItem("item_sku_attr_v_o")]
        public List<ItemSkuAttrVO> SkuAttrs { get; set; }

        /// <summary>
        /// 支付宝平台侧sku ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品sku库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
