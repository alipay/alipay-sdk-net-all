using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationIotnspoperationDeliveryCreateResponse.
    /// </summary>
    public class AlipayCommerceOperationIotnspoperationDeliveryCreateResponse : AopResponse
    {
        /// <summary>
        /// 碰一下推广计划id
        /// </summary>
        [XmlElement("n_delivery_id")]
        public string NDeliveryId { get; set; }
    }
}
