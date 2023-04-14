using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityMerchantInfo : AopObject
    {
        /// <summary>
        /// 商户支付宝id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户支付宝id类型。 枚举值 PID 直连pid SMID 间连SMID
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }
    }
}
