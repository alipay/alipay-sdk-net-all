using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentSubmerchantCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentSubmerchantCreateModel : AopObject
    {
        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户统一社会信用代码
        /// </summary>
        [XmlElement("merchant_uscc")]
        public string MerchantUscc { get; set; }

        /// <summary>
        /// 支付宝二级商户编号。由直付通进件返回。
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
