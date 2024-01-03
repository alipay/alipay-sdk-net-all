using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalGuideDialogDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalGuideDialogDTO : AopObject
    {
        /// <summary>
        /// 当前轮次对话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 对话内容
        /// </summary>
        [XmlElement("content")]
        public MedicalGuideContentDTO Content { get; set; }

        /// <summary>
        /// 当前轮次具体输入内容
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 当前轮次提问类型
        /// </summary>
        [XmlElement("question_type")]
        public string QuestionType { get; set; }
    }
}
