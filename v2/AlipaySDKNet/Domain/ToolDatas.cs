using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ToolDatas Data Structure.
    /// </summary>
    [Serializable]
    public class ToolDatas : AopObject
    {
        /// <summary>
        /// 诊断关键词
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 问题原因
        /// </summary>
        [XmlElement("problem")]
        public string Problem { get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        [XmlElement("solution")]
        public string Solution { get; set; }

        /// <summary>
        /// 返回的内容格式
        /// </summary>
        [XmlElement("solution_type")]
        public string SolutionType { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
