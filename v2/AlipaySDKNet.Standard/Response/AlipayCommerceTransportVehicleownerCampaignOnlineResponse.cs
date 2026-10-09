using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignOnlineResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignOnlineResponse : AopResponse
    {
        /// <summary>
        /// 审核状态：P（审核中）、S(审核通过)、F(审核驳回)、I（初始状态）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
