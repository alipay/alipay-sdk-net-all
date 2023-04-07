using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenidApplyorderCreateResponse.
    /// </summary>
    public class AlipayOpenAppOpenidApplyorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 工单的唯一标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
