using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantIDInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantIDInfo : AopObject
    {
        /// <summary>
        /// 商户的partnerId;
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 淘系商户的支付宝收款账号id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 间连商户的进件Id
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
