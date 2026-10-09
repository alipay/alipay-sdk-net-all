using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationIotnspoperationDeliveryStopResponse.
    /// </summary>
    public class AlipayCommerceOperationIotnspoperationDeliveryStopResponse : AopResponse
    {
        /// <summary>
        /// 碰一下推广计划id
        /// </summary>
        [XmlElement("n_delivery_id")]
        public string NDeliveryId { get; set; }
    }
}
