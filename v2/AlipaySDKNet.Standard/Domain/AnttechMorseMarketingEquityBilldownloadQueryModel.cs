using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingEquityBilldownloadQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingEquityBilldownloadQueryModel : AopObject
    {
        /// <summary>
        /// 发券活动的活动id，对应要发放的权益红包活动
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }
    }
}
