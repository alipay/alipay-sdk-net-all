using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskGuardrailsAgentDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskGuardrailsAgentDetectModel : AopObject
    {
        /// <summary>
        /// agent标识
        /// </summary>
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 业务属性
        /// </summary>
        [XmlElement("agent_properties")]
        public Agentproperties AgentProperties { get; set; }

        /// <summary>
        /// 调用系统code
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 业务唯一ID
        /// </summary>
        [XmlElement("business_data_id")]
        public string BusinessDataId { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [XmlElement("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// 节点
        /// </summary>
        [XmlElement("business_node")]
        public string BusinessNode { get; set; }

        /// <summary>
        /// 基本信息、配置信息等细化操作节点分类
        /// </summary>
        [XmlElement("business_sub_scene")]
        public string BusinessSubScene { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("check_contents")]
        [XmlArrayItem("guardrails_content")]
        public List<GuardrailsContent> CheckContents { get; set; }
    }
}
