using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailActivitySendResponse.
    /// </summary>
    public class AlipayCommerceRetailActivitySendResponse : AopResponse
    {
        /// <summary>
        /// 奖品实例的信息
        /// </summary>
        [XmlElement("prize_instance_info")]
        public PrizeInstanceInfo PrizeInstanceInfo { get; set; }

        /// <summary>
        /// 权益发放状态
        /// </summary>
        [XmlElement("send_success")]
        public bool SendSuccess { get; set; }
    }
}
