using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardBookingSyncResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardBookingSyncResponse : AopResponse
    {
        /// <summary>
        /// 预约单id
        /// </summary>
        [XmlElement("booking_id")]
        public string BookingId { get; set; }
    }
}
