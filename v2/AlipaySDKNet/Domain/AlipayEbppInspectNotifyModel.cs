using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInspectNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInspectNotifyModel : AopObject
    {
        /// <summary>
        /// 引擎函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 检测日志链接
        /// </summary>
        [XmlElement("log_url")]
        public string LogUrl { get; set; }

        /// <summary>
        /// 引擎检测结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 任务执行状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 时间节点描述
        /// </summary>
        [XmlElement("timing")]
        public string Timing { get; set; }
    }
}
