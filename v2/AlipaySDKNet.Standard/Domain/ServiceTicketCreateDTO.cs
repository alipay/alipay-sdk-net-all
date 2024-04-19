using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceTicketCreateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceTicketCreateDTO : AopObject
    {
        /// <summary>
        /// 坐席id
        /// </summary>
        [XmlElement("seat_id")]
        public string SeatId { get; set; }

        /// <summary>
        /// 坐席类型
        /// </summary>
        [XmlElement("seat_type")]
        public string SeatType { get; set; }
    }
}
