using System;
using System.Xml.Serialization;
using System.Collections.Generic;
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
        [XmlArray("activity_phases")]
        [XmlArrayItem("activity_phase")]
        public List<ActivityPhase> ActivityPhases { get; set; }

        /// <summary>
        /// 开卡权益信息
        /// </summary>
        [XmlElement("card_open_reward_info")]
        public CardOpenRewardInfo CardOpenRewardInfo { get; set; }

        /// <summary>
        /// 当前查询用户完成的订单笔数
        /// </summary>
        [XmlElement("current_count")]
        public long CurrentCount { get; set; }
    }
}
