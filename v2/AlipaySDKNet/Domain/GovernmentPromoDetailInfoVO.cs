using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GovernmentPromoDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class GovernmentPromoDetailInfoVO : AopObject
    {
        /// <summary>
        /// 政府满减优惠金额
        /// </summary>
        [XmlElement("discount_promo_amount")]
        public string DiscountPromoAmount { get; set; }

        /// <summary>
        /// 政府券优惠金额
        /// </summary>
        [XmlElement("voucher_promo_amount")]
        public string VoucherPromoAmount { get; set; }
    }
}
