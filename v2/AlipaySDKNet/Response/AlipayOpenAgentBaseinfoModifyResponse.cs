using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentBaseinfoModifyResponse.
    /// </summary>
    public class AlipayOpenAgentBaseinfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 安全驳回原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 安全驳回原因
        /// </summary>
        [XmlElement("reject_resion")]
        public string RejectResion { get; set; }

        /// <summary>
        /// 安全校验状态
        /// </summary>
        [XmlElement("safe_result")]
        public string SafeResult { get; set; }
    }
}
