using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationOpportunityBizQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationOpportunityBizQueryResponse : AopResponse
    {
        /// <summary>
        /// 商机ID
        /// </summary>
        [XmlElement("opportunity_id")]
        public string OpportunityId { get; set; }

        /// <summary>
        /// 商机ID的商机状态
        /// </summary>
        [XmlElement("opportunity_status")]
        public string OpportunityStatus { get; set; }

        /// <summary>
        /// 业务唯一流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
