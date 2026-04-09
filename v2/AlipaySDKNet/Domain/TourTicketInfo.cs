using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourTicketInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TourTicketInfo : AopObject
    {
        /// <summary>
        /// 门票信息
        /// </summary>
        [XmlElement("ticket_name")]
        public string TicketName { get; set; }

        /// <summary>
        /// 门票价格 分
        /// </summary>
        [XmlElement("ticket_price")]
        public string TicketPrice { get; set; }

        /// <summary>
        /// 门票适用人群
        /// </summary>
        [XmlElement("ticket_target_audience")]
        public string TicketTargetAudience { get; set; }
    }
}
