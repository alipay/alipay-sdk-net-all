using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerticalRiskVO Data Structure.
    /// </summary>
    [Serializable]
    public class VerticalRiskVO : AopObject
    {
        /// <summary>
        /// 预测用户在未来租赁周期内的履约能力，从0到5履约能力变高，风险更低
        /// </summary>
        [XmlElement("fulfillment_capacity_level")]
        public string FulfillmentCapacityLevel { get; set; }

        /// <summary>
        /// 刻画租赁订单与中介关联程度的风险等级
        /// </summary>
        [XmlElement("mediary_risk_level")]
        public string MediaryRiskLevel { get; set; }

        /// <summary>
        /// 刻画用户当前的实际在租笔数，评估用户租赁需求程度及履约压力
        /// </summary>
        [XmlElement("ongoing_rent_level")]
        public string OngoingRentLevel { get; set; }
    }
}
