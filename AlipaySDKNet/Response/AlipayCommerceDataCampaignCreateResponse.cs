using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDataCampaignCreateResponse.
    /// </summary>
    public class AlipayCommerceDataCampaignCreateResponse : AopResponse
    {
        /// <summary>
        /// 集点活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
