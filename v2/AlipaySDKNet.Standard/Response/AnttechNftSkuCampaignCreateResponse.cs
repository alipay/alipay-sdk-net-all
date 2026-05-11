using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftSkuCampaignCreateResponse.
    /// </summary>
    public class AnttechNftSkuCampaignCreateResponse : AopResponse
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
