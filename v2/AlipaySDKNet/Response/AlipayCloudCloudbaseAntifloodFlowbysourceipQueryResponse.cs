using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseAntifloodFlowbysourceipQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseAntifloodFlowbysourceipQueryResponse : AopResponse
    {
        /// <summary>
        /// 流量统计信息
        /// </summary>
        [XmlArray("flowstats")]
        [XmlArrayItem("flow_stats_entry")]
        public List<FlowStatsEntry> Flowstats { get; set; }
    }
}
