using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherBelongMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherBelongMerchantInfo : AopObject
    {
        /// <summary>
        /// 商户支付宝id，默认品牌名和品牌logo将从该商户信息中获取
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户支付宝id类型。
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }
    }
}
