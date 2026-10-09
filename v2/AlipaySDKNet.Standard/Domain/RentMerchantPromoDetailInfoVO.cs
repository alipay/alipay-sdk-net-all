using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentMerchantPromoDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentMerchantPromoDetailInfoVO : AopObject
    {
        /// <summary>
        /// 芝麻差异化定价优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("sesame_promo_amount")]
        public string SesamePromoAmount { get; set; }

        /// <summary>
        /// 商家满减券优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("voucher_promo_amount")]
        public string VoucherPromoAmount { get; set; }
    }
}
