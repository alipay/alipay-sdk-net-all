using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleCrowdCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleCrowdCreateResponse : AopResponse
    {
        /// <summary>
        /// 圈人规则id
        /// </summary>
        [XmlElement("ruleid")]
        public string Ruleid { get; set; }
    }
}
