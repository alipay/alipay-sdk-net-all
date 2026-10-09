using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistSrcfgestagecreditSecondApproveResponse.
    /// </summary>
    public class XingheLendassistSrcfgestagecreditSecondApproveResponse : AopResponse
    {
        /// <summary>
        /// 初审审核结果，APPROVE_PASS-审批通过、APPROVE_REJECT-审批拒绝
        /// </summary>
        [XmlElement("approve_result")]
        public string ApproveResult { get; set; }

        /// <summary>
        /// 授信审核拒绝时，返回拒绝原因
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }
    }
}
