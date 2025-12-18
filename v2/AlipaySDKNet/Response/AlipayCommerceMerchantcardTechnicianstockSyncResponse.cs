using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardTechnicianstockSyncResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardTechnicianstockSyncResponse : AopResponse
    {
        /// <summary>
        /// 手艺人id
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }
    }
}
