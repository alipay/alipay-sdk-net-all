using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationOpportunityBizQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationOpportunityBizQueryModel : AopObject
    {
        /// <summary>
        /// 商机 ID
        /// </summary>
        [XmlElement("opportunity_id")]
        public string OpportunityId { get; set; }

        /// <summary>
        /// 业务申请编号。业务自定义，保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
