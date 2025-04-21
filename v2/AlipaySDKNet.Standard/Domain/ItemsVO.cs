using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemsVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemsVO : AopObject
    {
        /// <summary>
        /// 商品总价
        /// </summary>
        [XmlElement("amount_item")]
        public string AmountItem { get; set; }

        /// <summary>
        /// APP方商品编码，对应商品接口的sku_code｜商品编码
        /// </summary>
        [XmlElement("app_item_code")]
        public string AppItemCode { get; set; }

        /// <summary>
        /// 是否医保商品
        /// </summary>
        [XmlElement("is_mi_item")]
        public long IsMiItem { get; set; }

        /// <summary>
        /// 1是处方药品，2不是处方药品
        /// </summary>
        [XmlElement("is_rx_item")]
        public long IsRxItem { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品医保编码
        /// </summary>
        [XmlElement("mi_code")]
        public string MiCode { get; set; }

        /// <summary>
        /// 商品原价，单位：元
        /// </summary>
        [XmlElement("price_original")]
        public string PriceOriginal { get; set; }

        /// <summary>
        /// 商品单价，单位：元
        /// </summary>
        [XmlElement("price_sale")]
        public string PriceSale { get; set; }

        /// <summary>
        /// 购买数量，单位：件
        /// </summary>
        [XmlElement("quantity_item")]
        public long QuantityItem { get; set; }

        /// <summary>
        /// 货架码
        /// </summary>
        [XmlElement("shelf_code")]
        public string ShelfCode { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// UPC码
        /// </summary>
        [XmlElement("upc")]
        public string Upc { get; set; }

        /// <summary>
        /// 商品重量，保留小数点后3位，单位固定两种（g/ml）
        /// </summary>
        [XmlElement("weight_item")]
        public long WeightItem { get; set; }

        /// <summary>
        /// 重量单位
        /// </summary>
        [XmlElement("weight_unit")]
        public string WeightUnit { get; set; }
    }
}
