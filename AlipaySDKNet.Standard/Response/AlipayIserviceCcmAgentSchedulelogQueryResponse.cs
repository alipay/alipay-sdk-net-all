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

        /// <summary>
        /// 查询结果的页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
