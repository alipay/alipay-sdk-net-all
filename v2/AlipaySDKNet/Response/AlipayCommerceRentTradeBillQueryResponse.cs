using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentTradeBillQueryResponse.
    /// </summary>
    public class AlipayCommerceRentTradeBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 分账明细
        /// </summary>
        [XmlElement("rent_royalty_detail")]
        public RentBillRoyaltyDetailDto RentRoyaltyDetail { get; set; }
    }
}
