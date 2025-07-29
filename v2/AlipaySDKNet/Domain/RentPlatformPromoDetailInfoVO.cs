using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPlatformPromoDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPlatformPromoDetailInfoVO : AopObject
    {
        /// <summary>
        /// 立减优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("discount_promo_amount")]
        public string DiscountPromoAmount { get; set; }

        /// <summary>
        /// 券优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("voucher_promo_amount")]
        public string VoucherPromoAmount { get; set; }
    }
}
