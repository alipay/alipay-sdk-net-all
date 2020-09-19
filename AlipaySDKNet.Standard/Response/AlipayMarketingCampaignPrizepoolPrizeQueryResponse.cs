using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizepoolPrizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 指定奖品id的详细配置
        /// </summary>
        [XmlElement("prize_config")]
        public PrizeConfig PrizeConfig { get; set; }
    }
}
