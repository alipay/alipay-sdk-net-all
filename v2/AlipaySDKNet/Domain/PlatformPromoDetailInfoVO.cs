using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlatformPromoDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class PlatformPromoDetailInfoVO : AopObject
    {
        /// <summary>
        /// 立减优惠金额
        /// </summary>
        [XmlElement("discount_promo_amount")]
        public string DiscountPromoAmount { get; set; }

        /// <summary>
        /// 券优惠金额
        /// </summary>
        [XmlElement("voucher_promo_amount")]
        public string VoucherPromoAmount { get; set; }
    }
}
