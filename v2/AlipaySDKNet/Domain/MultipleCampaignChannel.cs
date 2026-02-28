using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultipleCampaignChannel Data Structure.
    /// </summary>
    [Serializable]
    public class MultipleCampaignChannel : AopObject
    {
        /// <summary>
        /// 优惠渠道描述优惠来源信息
        /// </summary>
        [XmlElement("campaign_channel")]
        public string CampaignChannel { get; set; }

        /// <summary>
        /// 活动渠道码信息，用于标识活动渠道，主要是简称
        /// </summary>
        [XmlElement("campaign_channel_code")]
        public string CampaignChannelCode { get; set; }
    }
}
