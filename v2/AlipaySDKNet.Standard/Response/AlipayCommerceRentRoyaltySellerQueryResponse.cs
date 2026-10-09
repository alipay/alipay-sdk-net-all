using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentRoyaltySellerQueryResponse.
    /// </summary>
    public class AlipayCommerceRentRoyaltySellerQueryResponse : AopResponse
    {
        /// <summary>
        /// 分账详情信息
        /// </summary>
        [XmlElement("royalty_info")]
        public RentRoyaltyInfo RoyaltyInfo { get; set; }
    }
}
