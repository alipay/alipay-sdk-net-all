using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KyaAgentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KyaAgentInfo : AopObject
    {
        /// <summary>
        /// 支付宝侧智能体唯一ID。
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 审核通过时智能体状态固定为ONLINE。
        /// </summary>
        [XmlElement("agent_status")]
        public string AgentStatus { get; set; }

        /// <summary>
        /// 审核通过时审核状态固定为CONFIRM。
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 智能体载体，字段格式由platform决定。
        /// </summary>
        [XmlElement("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// 审核通过后自动推进为认证通过，状态固定为CONFIRM。
        /// </summary>
        [XmlElement("cert_status")]
        public string CertStatus { get; set; }

        /// <summary>
        /// 智能体Logo，支持AFTS fileId或HTTPS地址。
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 智能体名称。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 智能体所在端：WEB表示网页或MCP智能体，APP表示移动应用智能体。
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 智能体简介，用于智能体信息展示。
        /// </summary>
        [XmlElement("sub_name")]
        public string SubName { get; set; }
    }
}
