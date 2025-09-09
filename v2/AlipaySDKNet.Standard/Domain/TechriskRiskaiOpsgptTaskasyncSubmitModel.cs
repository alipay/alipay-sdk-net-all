using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskRiskaiOpsgptTaskasyncSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskRiskaiOpsgptTaskasyncSubmitModel : AopObject
    {
        /// <summary>
        /// 业务需求请求的具体智能体id，不同的智能体可以完成不同的工作，id 由服务提供方分配。
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 用户的意图，用于描述用户的问题或者疑问
        /// </summary>
        [XmlElement("intention")]
        public ChatMsg Intention { get; set; }

        /// <summary>
        /// 用户的 user_id 或者 open_id 或者商户系统中自己的用户标识
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 来源平台字段，用于统计和控制任务的来源，由服务提供方分配，仅合法的 task_source 才能通过校验。
        /// </summary>
        [XmlElement("task_source")]
        public string TaskSource { get; set; }
    }
}
