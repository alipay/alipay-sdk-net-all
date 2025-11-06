using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniPriceInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniPriceInfoDTO : AopObject
    {
        /// <summary>
        /// 分摊到凭证次序号维度的商家侧优惠，单位：元
        /// </summary>
        [XmlElement("merchant_discount_amount")]
        public string MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 分摊到凭证次序号维度的平台侧优惠，单位：元
        /// </summary>
        [XmlElement("platform_discount_amount")]
        public string PlatformDiscountAmount { get; set; }
    }
}
