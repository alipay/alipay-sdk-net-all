using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundConfirmCommitActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundConfirmCommitActivityInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 退款前向商户确认退款结果列表
        /// </summary>
        [XmlArray("refund_confirm_commit_result_list")]
        [XmlArrayItem("refund_confirm_commit_result")]
        public List<RefundConfirmCommitResult> RefundConfirmCommitResultList { get; set; }
    }
}
