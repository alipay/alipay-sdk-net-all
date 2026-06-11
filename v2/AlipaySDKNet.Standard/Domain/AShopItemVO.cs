using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AShopItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class AShopItemVO : AopObject
    {
        /// <summary>
        /// 平台侧编码itemId
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品子类型
        /// </summary>
        [XmlElement("item_sub_type")]
        public string ItemSubType { get; set; }

        /// <summary>
        /// 商家编码out_item_id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 价格单位
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 售价,单位:元
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 售卖状态 AVAILABLE=出售中/DELISTING=已下架
        /// </summary>
        [XmlElement("sell_status")]
        public string SellStatus { get; set; }

        /// <summary>
        /// 售卖结束时间
        /// </summary>
        [XmlElement("sold_end_time")]
        public string SoldEndTime { get; set; }

        /// <summary>
        /// 售卖时间
        /// </summary>
        [XmlElement("sold_start_time")]
        public string SoldStartTime { get; set; }

        /// <summary>
        /// 商品的名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 库存总量,单位:个
        /// </summary>
        [XmlElement("total_quantity")]
        public long TotalQuantity { get; set; }
    }
}
