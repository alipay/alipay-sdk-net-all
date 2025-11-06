using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenOrderCreateResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
