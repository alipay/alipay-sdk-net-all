using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCreateResponse : AopResponse
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
