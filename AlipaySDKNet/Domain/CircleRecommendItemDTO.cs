using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CircleRecommendItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CircleRecommendItemDTO : AopObject
    {
        /// <summary>
        /// 生活圈aoi信息
        /// </summary>
        [XmlElement("aoi_info")]
        public AoiInfoDTO AoiInfo { get; set; }

        /// <summary>
        /// 商品折扣
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 商品主图/封面图
        /// </summary>
        [XmlElement("item_cover")]
        public string ItemCover { get; set; }

        /// <summary>
        /// 商品详情链接，根据入参display_channel信息，获取对应端小程序链接，默认支付宝小程序链接
        /// </summary>
        [XmlElement("item_detail_url")]
        public string ItemDetailUrl { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品标签（三选一：新品/爆品/超赞）
        /// </summary>
        [XmlElement("item_label")]
        public string ItemLabel { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品所属门店信息
        /// </summary>
        [XmlElement("item_store")]
        public ItemStoreDTO ItemStore { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 销量 “已售xxx份”，销量大于9999："已售XX万份"
        /// </summary>
        [XmlElement("sales_info")]
        public string SalesInfo { get; set; }

        /// <summary>
        /// 节省X元，originalPrice - salesPrice
        /// </summary>
        [XmlElement("saved_money")]
        public string SavedMoney { get; set; }

        /// <summary>
        /// 描述：节省X元
        /// </summary>
        [XmlElement("saved_money_info")]
        public string SavedMoneyInfo { get; set; }

        /// <summary>
        /// 商品售卖价格
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 商品总销量
        /// </summary>
        [XmlElement("sold_quantity")]
        public string SoldQuantity { get; set; }

        /// <summary>
        /// 商品所属门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
