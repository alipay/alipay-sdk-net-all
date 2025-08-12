using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerCobrandcardactivityQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerCobrandcardactivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动阶段
        /// </summary>
        [XmlElement("activity_phases")]
        public ActivityPhase ActivityPhases { get; set; }

        /// <summary>
        /// 当前查询用户完成的订单笔数
        /// </summary>
        [XmlElement("current_count")]
        public long CurrentCount { get; set; }
    }
}
