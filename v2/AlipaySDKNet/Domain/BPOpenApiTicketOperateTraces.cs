using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BPOpenApiTicketOperateTraces Data Structure.
    /// </summary>
    [Serializable]
    public class BPOpenApiTicketOperateTraces : AopObject
    {
        /// <summary>
        /// 操作记录
        /// </summary>
        [XmlArray("operate_traces")]
        [XmlArrayItem("b_p_open_api_ticket_operate_trace")]
        public List<BPOpenApiTicketOperateTrace> OperateTraces { get; set; }
    }
}
