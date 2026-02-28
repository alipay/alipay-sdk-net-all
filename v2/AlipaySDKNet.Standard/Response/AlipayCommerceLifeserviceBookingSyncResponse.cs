using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceBookingSyncResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceBookingSyncResponse : AopResponse
    {
        /// <summary>
        /// 预约单id
        /// </summary>
        [XmlElement("booking_id")]
        public string BookingId { get; set; }
    }
}
