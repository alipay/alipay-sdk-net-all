using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentDistmerchantAddressDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentDistmerchantAddressDeleteModel : AopObject
    {
        /// <summary>
        /// 地址ID
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }
    }
}
