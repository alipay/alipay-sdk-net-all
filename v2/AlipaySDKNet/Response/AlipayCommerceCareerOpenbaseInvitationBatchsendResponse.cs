using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseInvitationBatchsendResponse.
    /// </summary>
    public class AlipayCommerceCareerOpenbaseInvitationBatchsendResponse : AopResponse
    {
        /// <summary>
        /// 平台批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 当前批次执行状态
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 外部批次号
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }
    }
}
