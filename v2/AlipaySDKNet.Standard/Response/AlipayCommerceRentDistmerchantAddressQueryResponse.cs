using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentDistmerchantAddressQueryResponse.
    /// </summary>
    public class AlipayCommerceRentDistmerchantAddressQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("addresses")]
        [XmlArrayItem("distribution_merchant_address_d_t_o")]
        public List<DistributionMerchantAddressDTO> Addresses { get; set; }
    }
}
