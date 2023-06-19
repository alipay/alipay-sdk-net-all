using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMiniappofflineQueryResponse.
    /// </summary>
    public class AlipayDataMdaMiniappofflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 累计行程规划人数
        /// </summary>
        [XmlElement("journey_planning")]
        public long JourneyPlanning { get; set; }

        /// <summary>
        /// 累计行程规划人数趋势
        /// </summary>
        [XmlElement("journey_planning_trend")]
        public string JourneyPlanningTrend { get; set; }

        /// <summary>
        /// 赛事关注TOP5
        /// </summary>
        [XmlElement("match_focus")]
        public string MatchFocus { get; set; }

        /// <summary>
        /// 票+服务
        /// </summary>
        [XmlElement("ticket_service")]
        public string TicketService { get; set; }

        /// <summary>
        /// 亚运PASS
        /// </summary>
        [XmlElement("use_pass")]
        public long UsePass { get; set; }

        /// <summary>
        /// 用户分布城市TOP5
        /// </summary>
        [XmlElement("user_distribution")]
        public string UserDistribution { get; set; }
    }
}
