using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardBookingtechnicianSyncResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardBookingtechnicianSyncResponse : AopResponse
    {
        /// <summary>
        /// 手艺人id
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }
    }
}
