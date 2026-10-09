using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PresetQuesiton Data Structure.
    /// </summary>
    [Serializable]
    public class PresetQuesiton : AopObject
    {
        /// <summary>
        /// 问题的父id
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 问题内容
        /// </summary>
        [XmlElement("question_content")]
        public string QuestionContent { get; set; }

        /// <summary>
        /// 问题唯一id
        /// </summary>
        [XmlElement("question_id")]
        public string QuestionId { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [XmlElement("question_type")]
        public string QuestionType { get; set; }
    }
}
