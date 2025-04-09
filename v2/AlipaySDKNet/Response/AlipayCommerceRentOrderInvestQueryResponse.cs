using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderInvestQueryResponse.
    /// </summary>
    public class AlipayCommerceRentOrderInvestQueryResponse : AopResponse
    {
        /// <summary>
        /// 租赁扩展信息
        /// </summary>
        [XmlElement("rent_ext_info")]
        public RentExtInfo RentExtInfo { get; set; }

        /// <summary>
        /// 租赁订单详情，包括业务订单详情、分期计划、分账计划、租赁订单信息
        /// </summary>
        [XmlElement("rent_info")]
        public RentInfo RentInfo { get; set; }

        /// <summary>
        /// 租赁风控信息
        /// </summary>
        [XmlArray("rent_risk_info")]
        [XmlArrayItem("rent_risk_info")]
        public List<RentRiskInfo> RentRiskInfo { get; set; }
    }
}
