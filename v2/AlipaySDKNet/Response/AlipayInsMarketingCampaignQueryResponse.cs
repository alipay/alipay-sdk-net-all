using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingCampaignQueryResponse.
    /// </summary>
    public class AlipayInsMarketingCampaignQueryResponse : AopResponse
    {
        /// <summary>
        /// 保险营销活动信息
        /// </summary>
        [XmlElement("mkt_campaign")]
        public InsMktCampaignDTO MktCampaign { get; set; }
    }
}
