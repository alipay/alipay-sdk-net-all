using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSkuInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSkuInfoVO : AopObject
    {
        /// <summary>
        /// 商家侧商品属性信息
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("merchant_item_attr_v_o")]
        public List<MerchantItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 商家侧sku ID，APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// sku售价，分为单位。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// sku售卖状态，包含以下两种状态： 已下架(DELISTING) 可售卖(AVAILABLE) 已下架: DELISTING 可售卖: AVAILABLE。
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 当前sku在商家侧实际剩余的库存值。
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
