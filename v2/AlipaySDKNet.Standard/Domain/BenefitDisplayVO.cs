using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitDisplayVO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitDisplayVO : AopObject
    {
        /// <summary>
        /// 券生效时间
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 权益 ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 优惠来源
        /// </summary>
        [XmlElement("benefit_source")]
        public string BenefitSource { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public MultiCurrencyMoneyDTO DiscountAmount { get; set; }

        /// <summary>
        /// 权益描述
        /// </summary>
        [XmlElement("discount_desc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 权益图标
        /// </summary>
        [XmlElement("discount_icon_url")]
        public string DiscountIconUrl { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 优惠百分比
        /// </summary>
        [XmlElement("discount_percentage")]
        public long DiscountPercentage { get; set; }

        /// <summary>
        /// 券过期时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 该优惠对应的商品ID
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 使用门槛
        /// </summary>
        [XmlElement("threshold_amount")]
        public MultiCurrencyMoneyDTO ThresholdAmount { get; set; }

        /// <summary>
        /// 使用规则描述
        /// </summary>
        [XmlElement("usage_condition")]
        public string UsageCondition { get; set; }
    }
}
