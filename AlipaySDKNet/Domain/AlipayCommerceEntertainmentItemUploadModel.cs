using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEntertainmentItemUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEntertainmentItemUploadModel : AopObject
    {
        /// <summary>
        /// 业务场景码，不填默认为娱乐会员业务，可选枚举： CONSUME_GOLD（消费金积分兑换） DEFAULT_CAMP（默认-娱乐会员优惠商品） CAMP_FEEDS （商品内容投放）
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 商品是否启用（上架展示），true/false
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 商品描述（作为副标题展示）
        /// </summary>
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 商品扩展信息，具体传值根据商户及商品类型不同另行约定。 json格式，请将需要传递的key和value字段放入map中，转成json string传入。  通用扩展参数： merchant_display_priority 商品排序字段，正整数，数字越大优先级越高
        /// </summary>
        [XmlElement("item_extended_info")]
        public string ItemExtendedInfo { get; set; }

        /// <summary>
        /// 商户侧商品ID，同商户下需唯一
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 客户点击商品后跳转到商户的地址
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 商品图片通过 alipay.open.file.upload 接口上传获得的文件ID
        /// </summary>
        [XmlElement("pic_file_id")]
        public string PicFileId { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        [XmlElement("pic_source_url")]
        public string PicSourceUrl { get; set; }

        /// <summary>
        /// 商品计价类型: 其他：OTHER 天卡：DAY 周卡：WEEK 月卡：MONTH 季卡：QUARTER 半年卡：SEMI_YEAR 年卡：YEAR 连续包周：CW 连续包月：CM 连续包季：CQ 连续包半年：CSY 连续包年：CY
        /// </summary>
        [XmlElement("pricing_type")]
        public string PricingType { get; set; }

        /// <summary>
        /// 优惠价，积分部分
        /// </summary>
        [XmlElement("promote_point")]
        public long PromotePoint { get; set; }

        /// <summary>
        /// 优惠价，现金部分（元）
        /// </summary>
        [XmlElement("promote_price")]
        public string PromotePrice { get; set; }

        /// <summary>
        /// 优惠定价方式，不填默认为现金，可选枚举CASH（纯现金），CASH_POINT（现金加积分），POINT（纯积分），FREE（免费）
        /// </summary>
        [XmlElement("promote_price_mode")]
        public string PromotePriceMode { get; set; }

        /// <summary>
        /// 剩余库存
        /// </summary>
        [XmlElement("remain_inventory")]
        public long RemainInventory { get; set; }

        /// <summary>
        /// 积分商品规则ID，积分商品必填
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 可选类型有： 影视 VIDEO, 游戏 GAME, 音乐 MUSIC, 在线阅读 ONLINE_READING, 社交媒体 SOCIAL_MEDIA, 工具 TOOLS, 其他 OTHER
        /// </summary>
        [XmlElement("service_category")]
        public string ServiceCategory { get; set; }

        /// <summary>
        /// 商品标签，用于召回时筛选商品，积分场景必填
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 总库存
        /// </summary>
        [XmlElement("total_inventory")]
        public long TotalInventory { get; set; }

        /// <summary>
        /// 商品原价，单位元（人民币）
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 失效时间，不填默认长期有效
        /// </summary>
        [XmlElement("valid_time_end")]
        public string ValidTimeEnd { get; set; }

        /// <summary>
        /// 生效时间，不填默认立即生效
        /// </summary>
        [XmlElement("valid_time_start")]
        public string ValidTimeStart { get; set; }
    }
}
