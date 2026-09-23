using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FollowQuestions Data Structure.
    /// </summary>
    [Serializable]
    public class FollowQuestions : AopObject
    {
        /// <summary>
        /// 追问回答
        /// </summary>
        [XmlElement("follow_answer")]
        public string FollowAnswer { get; set; }

        /// <summary>
        /// 追问题目
        /// </summary>
        [XmlElement("follow_question")]
        public string FollowQuestion { get; set; }

        /// <summary>
        /// 追问题序号
        /// </summary>
        [XmlElement("follow_question_no")]
        public string FollowQuestionNo { get; set; }

        /// <summary>
        /// 追问目标题题型编码
        /// </summary>
        [XmlElement("follow_question_type")]
        public string FollowQuestionType { get; set; }

        /// <summary>
        /// 追问题选项组
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("options")]
        public List<Options> Options { get; set; }
    }
}
