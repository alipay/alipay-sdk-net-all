using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationOpportunityLeadsCreateResponse.
    /// </summary>
    public class AlipayCommerceOperationOpportunityLeadsCreateResponse : AopResponse
    {
        /// <summary>
        /// 商机id
        /// </summary>
        [XmlElement("opportunity_id")]
        public string OpportunityId { get; set; }

        /// <summary>
        /// 商机ID的商机状态
        /// </summary>
        [XmlElement("opportunity_status")]
        public string OpportunityStatus { get; set; }

        /// <summary>
        /// 商机状态信息，在门店 Leads 创建失败时传入创建失败原因
        /// </summary>
        [XmlElement("opportunity_status_info")]
        public string OpportunityStatusInfo { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
