using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeadsMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LeadsMerchantInfo : AopObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }
    }
}
