using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardBookingserviceSyncResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardBookingserviceSyncResponse : AopResponse
    {
        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
