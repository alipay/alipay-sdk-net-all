using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmAgentSchedulelogQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmAgentSchedulelogQueryResponse : AopResponse
    {
        /// <summary>
        /// 客服状态变更流水日志集合
        /// </summary>
        [XmlElement("agent_schedule_logs")]
        public AgentScheduleLog AgentScheduleLogs { get; set; }
    }
}
