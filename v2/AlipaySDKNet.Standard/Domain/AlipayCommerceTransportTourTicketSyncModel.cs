using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourTicketSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourTicketSyncModel : AopObject
    {
        /// <summary>
        /// 景点Id
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ticket_info_list")]
        [XmlArrayItem("tour_ticket_info")]
        public List<TourTicketInfo> TicketInfoList { get; set; }
    }
}
