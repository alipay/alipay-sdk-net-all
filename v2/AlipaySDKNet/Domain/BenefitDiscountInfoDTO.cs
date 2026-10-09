using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitDiscountInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitDiscountInfoDTO : AopObject
    {
        /// <summary>
        /// discount_type=voucher，券ID discount_type=exchange，权益ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 如果是券，标识是否已膨胀
        /// </summary>
        [XmlElement("dilate")]
        public string Dilate { get; set; }

        /// <summary>
        /// 券金额中，商家侧优惠券的出资金额 单位：元
        /// </summary>
        [XmlElement("merchant_discount")]
        public string MerchantDiscount { get; set; }

        /// <summary>
        /// 券金额中，平台侧优惠券的出资金额 单位：元
        /// </summary>
        [XmlElement("platform_discount")]
        public string PlatformDiscount { get; set; }

        /// <summary>
        /// 券核销规则Key，支付下单的时候透传订单优惠标记（promo_params）
        /// </summary>
        [XmlElement("promo_rule_key")]
        public string PromoRuleKey { get; set; }

        /// <summary>
        /// 券核销规则Value，支付下单的时候透传订单优惠标记（promo_params）
        /// </summary>
        [XmlElement("promo_rule_value")]
        public string PromoRuleValue { get; set; }
    }
}
