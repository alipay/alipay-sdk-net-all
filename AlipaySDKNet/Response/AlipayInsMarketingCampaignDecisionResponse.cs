using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingCampaignDecisionResponse.
    /// </summary>
    public class AlipayInsMarketingCampaignDecisionResponse : AopResponse
    {
        /// <summary>
        /// 保险营销标的关联的活动列表
        /// </summary>
        [XmlArray("mkt_campaigns")]
        [XmlArrayItem("ins_mkt_campaign_d_t_o")]
        public List<InsMktCampaignDTO> MktCampaigns { get; set; }
    }
}
