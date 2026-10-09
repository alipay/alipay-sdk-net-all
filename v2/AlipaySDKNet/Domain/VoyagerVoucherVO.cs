using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerVoucherVO Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerVoucherVO : AopObject
    {
        /// <summary>
        /// 生效时间，时间戳
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 领取时间，时间戳
        /// </summary>
        [XmlElement("claim_time")]
        public string ClaimTime { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("coupon_discount_type")]
        public string CouponDiscountType { get; set; }

        /// <summary>
        /// 过期时间，时间戳
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 如何使用
        /// </summary>
        [XmlElement("how_to_use")]
        public string HowToUse { get; set; }

        /// <summary>
        /// 行业
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// logo链接
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 最大优惠金额（折扣券封顶场景，可选）
        /// </summary>
        [XmlElement("max_discount")]
        public string MaxDiscount { get; set; }

        /// <summary>
        /// 最大优惠金额单位（ISO 4217 币种）
        /// </summary>
        [XmlElement("max_discount_unit")]
        public string MaxDiscountUnit { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 营销码
        /// </summary>
        [XmlElement("promo_code")]
        public string PromoCode { get; set; }

        /// <summary>
        /// 核销时间，时间戳
        /// </summary>
        [XmlElement("redeem_time")]
        public string RedeemTime { get; set; }

        /// <summary>
        /// 券状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模版ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 门槛值（如满 100 可用传 10000）
        /// </summary>
        [XmlElement("threshold")]
        public string Threshold { get; set; }

        /// <summary>
        /// 门槛单位（一般为 ISO 4217 币种），展示如"满20可用"
        /// </summary>
        [XmlElement("threshold_unit")]
        public string ThresholdUnit { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 使用规则
        /// </summary>
        [XmlElement("use_rule")]
        public string UseRule { get; set; }

        /// <summary>
        /// 优惠值（纯数值字符串）：金额券 500（分）、折扣券 8（8 折）、次数券 3
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// 优惠单位：金额类为币种（ISO 4217），非金额权益为 折/次 等
        /// </summary>
        [XmlElement("value_unit")]
        public string ValueUnit { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
