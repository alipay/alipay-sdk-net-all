using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalLlmAnswerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalLlmAnswerDTO : AopObject
    {
        /// <summary>
        /// 对话内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 当前轮次具体输入内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 当前轮次对话顺序
        /// </summary>
        [XmlElement("seq_num")]
        public string SeqNum { get; set; }
    }
}
