using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentIsvCreateResponse.
    /// </summary>
    public class AlipayOpenAgentIsvCreateResponse : AopResponse
    {
        /// <summary>
        /// 智能体代创建订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
