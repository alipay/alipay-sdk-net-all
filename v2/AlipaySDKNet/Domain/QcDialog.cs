using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QcDialog Data Structure.
    /// </summary>
    [Serializable]
    public class QcDialog : AopObject
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 当前句对话完结时间到服务开始时间偏移量
        /// </summary>
        [XmlElement("end_offset")]
        public string EndOffset { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 句子的序列
        /// </summary>
        [XmlElement("index")]
        public long Index { get; set; }

        /// <summary>
        /// 当前语句的角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 当前句对话开始时间到服务开始时间偏移量
        /// </summary>
        [XmlElement("start_offset")]
        public string StartOffset { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
