using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HardeningTaskResponse Data Structure.
    /// </summary>
    [Serializable]
    public class HardeningTaskResponse : AopObject
    {
        /// <summary>
        /// 加固后的MD5
        /// </summary>
        [XmlElement("after_md_five")]
        public string AfterMdFive { get; set; }

        /// <summary>
        /// 加固后文件大小
        /// </summary>
        [XmlElement("after_size")]
        public long AfterSize { get; set; }

        /// <summary>
        /// 加固任务状态，0为队列中，200为加固成功，负数为加固失败，0到200为加固中间状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
