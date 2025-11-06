using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenReferenceCreateResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenReferenceCreateResponse : AopResponse
    {
        /// <summary>
        /// 流水id，整个订单处理过程中串联整个链路的id
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId { get; set; }
    }
}
