using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemDirectModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemDirectModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。该字段特殊可选，与out_item_id不能同时为空，优先使用item_id。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品原价，分为单位。若填写了skus[]数组，此字段不填写。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。该字段特殊可选，与item_id不能同时为空，优先使用item_id。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品售价，分为单位。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 商品的售卖状态状态，包含以下两种状态已下架(DELISTING)可售卖(AVAILABLE)
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// sku数组
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("item_direct_modify_sku")]
        public List<ItemDirectModifySku> Skus { get; set; }

        /// <summary>
        /// 库存 若填写了skus[]数组，此字段不填写。 若未填写skus[]数组，此字段选填。 目前支持库存区间0~99999
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
