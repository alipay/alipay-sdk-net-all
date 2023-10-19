using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPlaysigninCountQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPlaysigninCountQueryResponse : AopResponse
    {
        /// <summary>
        /// 连续签到次数
        /// </summary>
        [XmlElement("continuous_num")]
        public long ContinuousNum { get; set; }

        /// <summary>
        /// 累计签到次数
        /// </summary>
        [XmlElement("cumulative_num")]
        public long CumulativeNum { get; set; }
    }
}
