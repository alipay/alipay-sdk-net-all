using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryAgencyMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryAgencyMerchantInfo : AopObject
    {
        /// <summary>
        /// 合作业务类型。
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户id类型。 限制: 服务商代运营模式必传
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }
    }
}
