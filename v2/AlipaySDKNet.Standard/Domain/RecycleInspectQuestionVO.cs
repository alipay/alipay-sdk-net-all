using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleInspectQuestionVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleInspectQuestionVO : AopObject
    {
        /// <summary>
        /// 问题答案列表
        /// </summary>
        [XmlArray("answer_list")]
        [XmlArrayItem("recycle_inspect_answer_v_o")]
        public List<RecycleInspectAnswerVO> AnswerList { get; set; }

        /// <summary>
        /// 问题编码
        /// </summary>
        [XmlElement("question_code")]
        public string QuestionCode { get; set; }

        /// <summary>
        /// 问题的中文描述
        /// </summary>
        [XmlElement("question_name")]
        public string QuestionName { get; set; }
    }
}
