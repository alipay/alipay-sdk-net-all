using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DialogueParam Data Structure.
    /// </summary>
    [Serializable]
    public class DialogueParam : AopObject
    {
        /// <summary>
        /// 阿里云文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 阿里云任务id 和文件id配合构建双方交互唯一标识
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
