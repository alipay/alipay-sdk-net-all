using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantPromoDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantPromoDetailInfoVO : AopObject
    {
        /// <summary>
        /// 芝麻差异化定价优惠金额
        /// </summary>
        [XmlElement("sesame_promo_amount")]
        public string SesamePromoAmount { get; set; }

        /// <summary>
        /// 商家满减券优惠金额
        /// </summary>
        [XmlElement("voucher_promo_amount")]
        public string VoucherPromoAmount { get; set; }
    }
}
