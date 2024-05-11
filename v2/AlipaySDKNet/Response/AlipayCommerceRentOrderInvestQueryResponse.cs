using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderInvestQueryResponse.
    /// </summary>
    public class AlipayCommerceRentOrderInvestQueryResponse : AopResponse
    {
        /// <summary>
        /// 租赁订单详情，包括业务订单详情、分期计划、分账计划、租赁订单信息
        /// </summary>
        [XmlElement("rent_info")]
        public RentInfo RentInfo { get; set; }
    }
}
