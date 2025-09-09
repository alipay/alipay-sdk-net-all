using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantInfo : AopObject
    {
        /// <summary>
        /// 直连传支付宝pid 间连传支付宝smid
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 支付宝商户类型
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }
    }
}
