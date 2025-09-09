using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistSrcfgestagecreditFirstApproveResponse.
    /// </summary>
    public class XingheLendassistSrcfgestagecreditFirstApproveResponse : AopResponse
    {
        /// <summary>
        /// 政企员工团购分期授信初审返回的唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 初审审核结果，APPROVE_PASS-审批通过、APPROVE_REJECT-审批拒绝
        /// </summary>
        [XmlElement("approve_result")]
        public string ApproveResult { get; set; }

        /// <summary>
        /// 审核通过时，通过类型有值；NEED_SC-需要走芝麻信用、NOT_NEED_SC-不走芝麻信用
        /// </summary>
        [XmlElement("pass_type")]
        public string PassType { get; set; }

        /// <summary>
        /// 授信审核拒绝返回拒绝原因
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }
    }
}
