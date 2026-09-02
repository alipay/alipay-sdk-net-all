using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentDistmerchantAddressCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentDistmerchantAddressCreateModel : AopObject
    {
        /// <summary>
        /// 销商户归还地址
        /// </summary>
        [XmlElement("address")]
        public DistributionMerchantAddressDTO Address { get; set; }
    }
}
