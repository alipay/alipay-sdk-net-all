using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceSportsVenueOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
