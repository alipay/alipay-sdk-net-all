using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignModifyResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignModifyResponse : AopResponse
    {
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
