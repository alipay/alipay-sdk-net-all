using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityBean Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityBean : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 价格，单位：元
        /// </summary>
        [XmlElement("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 折扣skuId
        /// </summary>
        [XmlElement("discount_sku_id")]
        public string DiscountSkuId { get; set; }

        /// <summary>
        /// ID值
        /// </summary>
        [XmlElement("id_value")]
        public string IdValue { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 原始skuId
        /// </summary>
        [XmlElement("origin_sku_id")]
        public string OriginSkuId { get; set; }

        /// <summary>
        /// 展示价格，单位：元
        /// </summary>
        [XmlElement("show_amt")]
        public string ShowAmt { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
