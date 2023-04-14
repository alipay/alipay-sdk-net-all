using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignPublishResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignPublishResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
