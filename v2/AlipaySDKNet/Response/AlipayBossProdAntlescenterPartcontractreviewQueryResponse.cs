using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlescenterPartcontractreviewQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlescenterPartcontractreviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 审核结果，通过：true，拒绝：false。
        /// </summary>
        [XmlElement("audit_res")]
        public bool AuditRes { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [XmlElement("audit_time")]
        public string AuditTime { get; set; }

        /// <summary>
        /// 审核人工号
        /// </summary>
        [XmlElement("audit_work_no")]
        public string AuditWorkNo { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 审核不通过原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 签约任务流水号
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }

        /// <summary>
        /// 建议
        /// </summary>
        [XmlElement("suggest_info")]
        public string SuggestInfo { get; set; }
    }
}
