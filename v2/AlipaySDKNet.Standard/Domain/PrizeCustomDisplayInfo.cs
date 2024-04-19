using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeCustomDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeCustomDisplayInfo : AopObject
    {
        /// <summary>
        /// 面额单位
        /// </summary>
        [XmlElement("amount_unit_text")]
        public string AmountUnitText { get; set; }

        /// <summary>
        /// 上限面额，单位分
        /// </summary>
        [XmlElement("ceil_money_amount")]
        public long CeilMoneyAmount { get; set; }

        /// <summary>
        /// 折扣信息
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 常见属性： "BUTTON_TEXT": 奖品按钮 "PRIZE_AMOUNT": 单个奖品数量或金额 "BUTTON_REDIRECT_URL": 奖品图片 "PRIZE_UNIT": 奖品单位 "PRIZE_LOGO": 奖品LOGO "PRIZE_DISPLAY_NAME": 奖品展示名称 "PRIZE_HINT_TEXT": 奖品描述
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("key_value_map")]
        public List<KeyValueMap> ExtInfo { get; set; }

        /// <summary>
        /// 奖品权益类型 "VOUCHER", "券" "MEMBER_CARD", "会员卡" "SALE_GIFT_PACKAGE", "券包" "SKIN", "皮肤"
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
        /// "PLATFORM","平台", "ISV", "ISV", "MERCHANT", "商户", "PLAN", "新方案", "PROMOORDER", "权益平台", "AUTO", "自动"
        /// </summary>
        [XmlElement("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 优惠信息，单位分
        /// </summary>
        [XmlElement("preferential_money_amount")]
        public long PreferentialMoneyAmount { get; set; }

        /// <summary>
        /// 奖品背景图url
        /// </summary>
        [XmlElement("prize_background_pic_url")]
        public string PrizeBackgroundPicUrl { get; set; }

        /// <summary>
        /// 奖品展示名称（短）
        /// </summary>
        [XmlElement("prize_display_name")]
        public string PrizeDisplayName { get; set; }

        /// <summary>
        /// 奖品图标地址
        /// </summary>
        [XmlElement("prize_icon")]
        public string PrizeIcon { get; set; }

        /// <summary>
        /// 奖品权益单品优惠类型
        /// </summary>
        [XmlElement("prize_item_type")]
        public string PrizeItemType { get; set; }

        /// <summary>
        /// 品牌Logo图片
        /// </summary>
        [XmlElement("prize_logo")]
        public string PrizeLogo { get; set; }

        /// <summary>
        /// 奖品展示名称（长）
        /// </summary>
        [XmlElement("prize_long_name")]
        public string PrizeLongName { get; set; }

        /// <summary>
        /// 奖品展示名称（中）
        /// </summary>
        [XmlElement("prize_medium_name")]
        public string PrizeMediumName { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("prize_merchant_name")]
        public string PrizeMerchantName { get; set; }

        /// <summary>
        /// 奖品展示名称(短,无金额信息)
        /// </summary>
        [XmlElement("prize_name_without_amount")]
        public string PrizeNameWithoutAmount { get; set; }

        /// <summary>
        /// 对奖品的使用规则说明，如使用限制等
        /// </summary>
        [XmlElement("prize_rule_desc")]
        public string PrizeRuleDesc { get; set; }

        /// <summary>
        /// 描述奖品的使用说明，如消费满1000元可用
        /// </summary>
        [XmlElement("prize_usage_desc")]
        public string PrizeUsageDesc { get; set; }

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
        /// 无特殊需求用 showAmountText + amountUnitText 表达 减几元、打几折、特价金额 即可
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
