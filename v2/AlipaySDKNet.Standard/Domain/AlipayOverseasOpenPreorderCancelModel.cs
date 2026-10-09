using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenPreorderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenPreorderCancelModel : AopObject
    {
        /// <summary>
        /// 机构信息
        /// </summary>
        [XmlElement("agent_info")]
        public TuitionISVAgentInfoDTO AgentInfo { get; set; }

        /// <summary>
        /// 单号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
