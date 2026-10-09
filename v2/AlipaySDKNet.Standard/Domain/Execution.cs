using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Execution Data Structure.
    /// </summary>
    [Serializable]
    public class Execution : AopObject
    {
        /// <summary>
        /// 耗时（毫秒）
        /// </summary>
        [XmlElement("cost")]
        public long Cost { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 执行状态  - SUCCESS  - FAIL  - DOING
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// trace ID
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
