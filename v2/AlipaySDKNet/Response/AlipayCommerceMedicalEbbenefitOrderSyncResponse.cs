using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalEbbenefitOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalEbbenefitOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
