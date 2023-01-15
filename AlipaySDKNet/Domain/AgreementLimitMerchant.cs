using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreementLimitMerchant Data Structure.
    /// </summary>
    [Serializable]
    public class AgreementLimitMerchant : AopObject
    {
        /// <summary>
        /// 授权商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// PID - 直联商户 SMID - 间联商户
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }
    }
}
