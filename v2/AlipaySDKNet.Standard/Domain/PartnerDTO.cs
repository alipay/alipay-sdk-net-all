using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PartnerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PartnerDTO : AopObject
    {
        /// <summary>
        /// 二级商户id
        /// </summary>
        [XmlElement("secondary_merchant_id")]
        public string SecondaryMerchantId { get; set; }
    }
}
