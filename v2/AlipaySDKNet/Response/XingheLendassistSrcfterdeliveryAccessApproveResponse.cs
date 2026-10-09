using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistSrcfterdeliveryAccessApproveResponse.
    /// </summary>
    public class XingheLendassistSrcfterdeliveryAccessApproveResponse : AopResponse
    {
        /// <summary>
        /// 审核结果，APPROVE_PASS-审批通过、APPROVE_REJECT-审批拒绝
        /// </summary>
        [XmlElement("approve_result")]
        public string ApproveResult { get; set; }

        /// <summary>
        /// 终端交付申请返回的唯一申请单号
        /// </summary>
        [XmlElement("delivery_apply_no")]
        public string DeliveryApplyNo { get; set; }

        /// <summary>
        /// 终端交付审核拒绝时，返回拒绝原因
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }
    }
}
