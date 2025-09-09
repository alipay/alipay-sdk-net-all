using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorpusPublishTaskResult Data Structure.
    /// </summary>
    [Serializable]
    public class CorpusPublishTaskResult : AopObject
    {
        /// <summary>
        /// 知识语料类型
        /// </summary>
        [XmlElement("corpus_type")]
        public string CorpusType { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 处理完成数量
        /// </summary>
        [XmlElement("process_success_count")]
        public long ProcessSuccessCount { get; set; }

        /// <summary>
        /// 总共处理数量
        /// </summary>
        [XmlElement("process_total_count")]
        public long ProcessTotalCount { get; set; }

        /// <summary>
        /// 用于说明发布任务信息，需要注明是哪种语料，上线还是下线，尽量描述的清晰准确
        /// </summary>
        [XmlElement("publish_name")]
        public string PublishName { get; set; }

        /// <summary>
        /// 知识发布类型
        /// </summary>
        [XmlElement("publish_type")]
        public string PublishType { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }
    }
}
