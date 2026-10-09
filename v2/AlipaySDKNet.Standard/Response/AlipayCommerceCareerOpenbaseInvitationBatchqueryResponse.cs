using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseInvitationBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceCareerOpenbaseInvitationBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("batch_details")]
        [XmlArrayItem("career_open_base_invitation_detail_result")]
        public List<CareerOpenBaseInvitationDetailResult> BatchDetails { get; set; }

        /// <summary>
        /// 平台批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批次状态
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 外部批次号，需要保证全局唯一，相同 out_batch_no 重复提交批次会被拒绝。
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }
    }
}
