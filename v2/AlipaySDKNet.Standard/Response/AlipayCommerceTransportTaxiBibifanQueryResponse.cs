using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiBibifanQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiBibifanQueryResponse : AopResponse
    {
        /// <summary>
        /// 司机匹配的支付宝账户 现在暂时为伪uid
        /// </summary>
        [XmlElement("driver_id")]
        public string DriverId { get; set; }

        /// <summary>
        /// 是否报名笔笔返
        /// </summary>
        [XmlElement("is_enrolled")]
        public bool IsEnrolled { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("taxi_order_details")]
        [XmlArrayItem("taxi_order_detail")]
        public List<TaxiOrderDetail> TaxiOrderDetails { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("taxi_reward_details")]
        [XmlArrayItem("taxi_reward_detail")]
        public List<TaxiRewardDetail> TaxiRewardDetails { get; set; }
    }
}
