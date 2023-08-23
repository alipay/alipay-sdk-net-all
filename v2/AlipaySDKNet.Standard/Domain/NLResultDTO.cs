using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NLResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class NLResultDTO : AopObject
    {
        /// <summary>
        /// 用户app token
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 处理结果值
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 任务使用次数
        /// </summary>
        [XmlElement("service_time_cost")]
        public string ServiceTimeCost { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        [XmlElement("service_token_cost")]
        public string ServiceTokenCost { get; set; }

        /// <summary>
        /// 约定的任务ID值
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务状态信息详细说明
        /// </summary>
        [XmlElement("task_msg")]
        public string TaskMsg { get; set; }

        /// <summary>
        /// 任务状态信息
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
