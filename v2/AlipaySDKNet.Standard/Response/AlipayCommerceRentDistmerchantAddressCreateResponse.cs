using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentDistmerchantAddressCreateResponse.
    /// </summary>
    public class AlipayCommerceRentDistmerchantAddressCreateResponse : AopResponse
    {
        /// <summary>
        /// 地址id
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }
    }
}
