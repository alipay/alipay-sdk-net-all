using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduPrizeCustomDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduPrizeCustomDisplayInfo : AopObject
    {
        /// <summary>
        /// 面额单位
        /// </summary>
        [XmlElement("amount_unit_text")]
        public string AmountUnitText { get; set; }

        /// <summary>
        /// 奖品背景图 url
        /// </summary>
        [XmlElement("benefit_background_pic_url")]
        public string BenefitBackgroundPicUrl { get; set; }

        /// <summary>
        /// 奖品图标地址
        /// </summary>
        [XmlElement("benefit_icon")]
        public string BenefitIcon { get; set; }

        /// <summary>
        /// 奖品权益单品优惠类型
        /// </summary>
        [XmlElement("benefit_item_type")]
        public string BenefitItemType { get; set; }

        /// <summary>
        /// 品牌Logo图片
        /// </summary>
        [XmlElement("benefit_logo")]
        public string BenefitLogo { get; set; }

        /// <summary>
        /// 奖品展示名称（长）
        /// </summary>
        [XmlElement("benefit_long_name")]
        public string BenefitLongName { get; set; }

        /// <summary>
        /// 奖品展示名称（中）
        /// </summary>
        [XmlElement("benefit_medium_name")]
        public string BenefitMediumName { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("benefit_merchant_name")]
        public string BenefitMerchantName { get; set; }

        /// <summary>
        /// 奖品展示名称（短）
        /// </summary>
        [XmlElement("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 奖品展示名称（短，无金额信息）
        /// </summary>
        [XmlElement("benefit_name_without_amount")]
        public string BenefitNameWithoutAmount { get; set; }

        /// <summary>
        /// 奖品使用规则说明，如使用限制等
        /// </summary>
        [XmlElement("benefit_rule_desc")]
        public string BenefitRuleDesc { get; set; }

        /// <summary>
        /// 奖品使用说明，如消费满 1000 元可用
        /// </summary>
        [XmlElement("benefit_usage_desc")]
        public string BenefitUsageDesc { get; set; }

        /// <summary>
        /// 上限面额，单位分
        /// </summary>
        [XmlElement("ceil_money_amount")]
        public long CeilMoneyAmount { get; set; }

        /// <summary>
        /// 折扣信息，数值表示折扣比例，单位为"折"，如8表示8折（即原价的80%），7.5表示7.5折
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 奖品权益类型
        /// </summary>
        [XmlElement("form_type")]
        public string FormType { get; set; }

        /// <summary>
        /// 单品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 总使用次数
        /// </summary>
        [XmlElement("max_use_count")]
        public long MaxUseCount { get; set; }

        /// <summary>
        /// 原面额，单位分
        /// </summary>
        [XmlElement("original_money_amount")]
        public long OriginalMoneyAmount { get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        [XmlElement("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 优惠信息，单位分
        /// </summary>
        [XmlElement("preferential_money_amount")]
        public long PreferentialMoneyAmount { get; set; }

        /// <summary>
        /// 投放链接
        /// </summary>
        [XmlElement("promo_link")]
        public string PromoLink { get; set; }

        /// <summary>
        /// 使用范围
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 展示金额数值，单位由配套字段amountUnitText指定（如"元"表示人民币元、"折"表示折扣比例），取值随单位不同而异：当单位为"元"时取值为金额数字（如"0.1"表示0.1元），当单位为"折"时取值为折扣数值（如"8"表示8折）。本字段为纯数值，不含单位
        /// </summary>
        [XmlElement("show_amount_text")]
        public string ShowAmountText { get; set; }

        /// <summary>
        /// 特价信息，单位分
        /// </summary>
        [XmlElement("specified_money_amount")]
        public long SpecifiedMoneyAmount { get; set; }

        /// <summary>
        /// 奖品权益子类型
        /// </summary>
        [XmlElement("sub_form_type")]
        public string SubFormType { get; set; }

        /// <summary>
        /// 使用门槛文案
        /// </summary>
        [XmlElement("threshold_amount_text")]
        public string ThresholdAmountText { get; set; }

        /// <summary>
        /// 门槛金额，单位分
        /// </summary>
        [XmlElement("threshold_money_amount")]
        public long ThresholdMoneyAmount { get; set; }
    }
}
