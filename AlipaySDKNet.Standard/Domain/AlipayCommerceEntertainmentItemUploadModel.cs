using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEntertainmentItemUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEntertainmentItemUploadModel : AopObject
    {
        /// <summary>
        /// 商品是否启用（对客展示），true/false
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 商品扩展信息，具体传值根据商户及商品类型不同另行约定。 json格式，请将需要传递的key和value字段放入map中，转成json string传入。
        /// </summary>
        [XmlElement("item_extended_info")]
        public string ItemExtendedInfo { get; set; }

        /// <summary>
        /// 商品Id,用于后续spi查询时关联
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 优惠商品名，对客展示的商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 客户点击商品后跳转到商户的地址
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        [XmlElement("pic_source_url")]
        public string PicSourceUrl { get; set; }

        /// <summary>
        /// 商品计价类型: 天卡：DAY 周卡：WEEK 月卡：MONTH 季卡：QUARTER 年卡：YEAR 连续包周：CW 连续包月：CM 连续包季：CQ 连续包年：CY
        /// </summary>
        [XmlElement("pricing_type")]
        public string PricingType { get; set; }

        /// <summary>
        /// 可选类型有： VIDEO:影视 MUSIC:音乐
        /// </summary>
        [XmlElement("service_category")]
        public string ServiceCategory { get; set; }

        /// <summary>
        /// 商品单价，单位元（人民币）
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
