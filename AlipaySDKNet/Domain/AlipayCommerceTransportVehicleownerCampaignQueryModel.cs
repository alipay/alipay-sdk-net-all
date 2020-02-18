using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVehicleownerCampaignQueryModel : AopObject
    {
        /// <summary>
        /// 活动id的列表
        /// </summary>
        [XmlArray("activity_id")]
        [XmlArrayItem("string")]
        public List<string> ActivityId { get; set; }
    }
}
