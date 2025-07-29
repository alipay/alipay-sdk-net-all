using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentInstallmentPlanPromoDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentInstallmentPlanPromoDetailInfoVO : AopObject
    {
        /// <summary>
        /// 商家优惠金额，不区分出资方式，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("merchant_promo_amount")]
        public string MerchantPromoAmount { get; set; }

        /// <summary>
        /// 商家优惠详情
        /// </summary>
        [XmlElement("merchant_promo_detail")]
        public RentMerchantPromoDetailInfoVO MerchantPromoDetail { get; set; }

        /// <summary>
        /// 计划付款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("plan_pay_amount")]
        public string PlanPayAmount { get; set; }

        /// <summary>
        /// 对应当前阶段的分期期数，如1、2
        /// </summary>
        [XmlElement("plan_pay_no")]
        public string PlanPayNo { get; set; }

        /// <summary>
        /// 平台优惠金额，不区分出资方式，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("platform_promo_amount")]
        public string PlatformPromoAmount { get; set; }

        /// <summary>
        /// 平台优惠详情
        /// </summary>
        [XmlElement("platform_promo_detail")]
        public RentPlatformPromoDetailInfoVO PlatformPromoDetail { get; set; }

        /// <summary>
        /// 优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("promo_amount")]
        public string PromoAmount { get; set; }
    }
}
