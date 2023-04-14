using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseInstanceOperatetraceQueryResponse.
    /// </summary>
    public class AlipayBossBaseInstanceOperatetraceQueryResponse : AopResponse
    {
        /// <summary>
        /// 操作记录
        /// </summary>
        [XmlElement("operate_traces")]
        public BPOpenApiTicketOperateTraces OperateTraces { get; set; }
    }
}
