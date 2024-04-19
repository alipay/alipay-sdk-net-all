using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentScheduleLog Data Structure.
    /// </summary>
    [Serializable]
    public class AgentScheduleLog : AopObject
    {
        /// <summary>
        /// 客服id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 客服名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 状态变更发生时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 状态持续时长,单位秒
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 状态变更结束时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// isv或商户系统中对应的客服工号
        /// </summary>
        [XmlElement("external_user_no")]
        public string ExternalUserNo { get; set; }

        /// <summary>
        /// 客服状态变更流水id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 变更前状态
        /// </summary>
        [XmlElement("last_status")]
        public string LastStatus { get; set; }

        /// <summary>
        /// 状态变更开始时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 变更后状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
