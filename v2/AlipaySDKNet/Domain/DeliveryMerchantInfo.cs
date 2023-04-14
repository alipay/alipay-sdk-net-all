using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryMerchantInfo : AopObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户id类型。  枚举值：  SMID： 间连商户  PID： 直连商户
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }
    }
}
