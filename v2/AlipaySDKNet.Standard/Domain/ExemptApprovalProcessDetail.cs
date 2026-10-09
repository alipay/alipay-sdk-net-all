using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExemptApprovalProcessDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ExemptApprovalProcessDetail : AopObject
    {
        /// <summary>
        /// 豁免申请流程状态
        /// </summary>
        [XmlElement("exempt_approval_process_state")]
        public string ExemptApprovalProcessState { get; set; }

        /// <summary>
        /// 豁免申请流程链接
        /// </summary>
        [XmlElement("exempt_approval_process_url")]
        public string ExemptApprovalProcessUrl { get; set; }
    }
}
