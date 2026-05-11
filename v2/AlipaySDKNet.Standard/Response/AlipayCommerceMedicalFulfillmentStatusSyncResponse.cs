using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalFulfillmentStatusSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalFulfillmentStatusSyncResponse : AopResponse
    {
        /// <summary>
        /// 履约单ID
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }
    }
}
