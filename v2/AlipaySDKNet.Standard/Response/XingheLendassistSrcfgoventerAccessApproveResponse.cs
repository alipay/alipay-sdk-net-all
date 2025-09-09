using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistSrcfgoventerAccessApproveResponse.
    /// </summary>
    public class XingheLendassistSrcfgoventerAccessApproveResponse : AopResponse
    {
        /// <summary>
        /// 本次审核请求返回的唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 审核结果，WAIT_APPROVE-待审批、APPROVE_PASS-审批通过、APPROVE_REJECT-审批拒绝
        /// </summary>
        [XmlElement("approve_result")]
        public string ApproveResult { get; set; }

        /// <summary>
        /// 准入审核拒绝时，返回拒绝原因
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }
    }
}
