using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthServiceItem Data Structure.
    /// </summary>
    [Serializable]
    public class HealthServiceItem : AopObject
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商家的商品条形码
        /// </summary>
        [XmlElement("merchant_item_bar_code")]
        public string MerchantItemBarCode { get; set; }

        /// <summary>
        /// 商家的商品编码
        /// </summary>
        [XmlElement("merchant_item_code")]
        public string MerchantItemCode { get; set; }

        /// <summary>
        /// 售价 单位：分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品的sku列表（已废弃，使用skus字段）
        /// </summary>
        [XmlElement("sku_list")]
        public HealthServiceSku SkuList { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("health_service_sku")]
        public List<HealthServiceSku> Skus { get; set; }
    }
}
