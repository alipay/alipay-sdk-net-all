using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossAntlescenterPartcontractreviewApplyResponse.
    /// </summary>
    public class AlipayBossAntlescenterPartcontractreviewApplyResponse : AopResponse
    {
        /// <summary>
        /// 人工审核链接
        /// </summary>
        [XmlElement("apply_manual_review_url")]
        public string ApplyManualReviewUrl { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }
    }
}
