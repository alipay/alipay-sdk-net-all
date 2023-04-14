using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryItemSkuSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryItemSkuSyncRequest : AopObject
    {
        /// <summary>
        /// sku扩展属性
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("ext_info_pair")]
        public List<ExtInfoPair> ExtInfo { get; set; }

        /// <summary>
        /// sku商品原价（划线价）
        /// </summary>
        [XmlElement("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 商品价格（标价/刊例价）
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品价格类型（件/次/日/年）
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 商品营销玩法信息
        /// </summary>
        [XmlArray("promo_infos")]
        [XmlArrayItem("item_promo_info_sync_request")]
        public List<ItemPromoInfoSyncRequest> PromoInfos { get; set; }

        /// <summary>
        /// 商品售卖状态，AVAILABLE：上架，DELISTING，下架
        /// </summary>
        [XmlElement("sell_status")]
        public string SellStatus { get; set; }

        /// <summary>
        /// sku的售卖特征，list<kv>类型
        /// </summary>
        [XmlArray("sku_attrs")]
        [XmlArrayItem("ext_info_pair")]
        public List<ExtInfoPair> SkuAttrs { get; set; }

        /// <summary>
        /// 商户侧skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku主图通过alipay.open.file.upload上传得到的fileId
        /// </summary>
        [XmlElement("sku_image")]
        public string SkuImage { get; set; }

        /// <summary>
        /// sku商品名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// sku商品的库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
