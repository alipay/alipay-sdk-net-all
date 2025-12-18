using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationShangouAuthinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationShangouAuthinfoQueryModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
