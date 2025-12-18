using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveAnchorResourceAuditResponse.
    /// </summary>
    public class AlipayContentLiveAnchorResourceAuditResponse : AopResponse
    {
        /// <summary>
        /// 用于全链路排查问题的追踪标识
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("reject_item_list")]
        [XmlArrayItem("resource_audit_result")]
        public List<ResourceAuditResult> RejectItemList { get; set; }
    }
}
