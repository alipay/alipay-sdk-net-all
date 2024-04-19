using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskComplaintProcessFinishResponse.
    /// </summary>
    public class AlipaySecurityRiskComplaintProcessFinishResponse : AopResponse
    {
        /// <summary>
        /// 本次投诉处理是否成功，表示系统后台是否成功收到本次请求并完成处理流程
        /// </summary>
        [XmlElement("complaint_process_success")]
        public bool ComplaintProcessSuccess { get; set; }
    }
}
