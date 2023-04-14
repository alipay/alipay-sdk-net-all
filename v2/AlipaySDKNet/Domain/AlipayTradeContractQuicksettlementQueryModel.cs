using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeContractQuicksettlementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeContractQuicksettlementQueryModel : AopObject
    {
        /// <summary>
        /// 二级商户smid
        /// </summary>
        [XmlElement("secondary_merchant_id")]
        public string SecondaryMerchantId { get; set; }
    }
}
