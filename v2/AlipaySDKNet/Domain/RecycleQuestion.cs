using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQuestion Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQuestion : AopObject
    {
        /// <summary>
        /// 选项列表
        /// </summary>
        [XmlArray("option_list")]
        [XmlArrayItem("recycle_question_option_info")]
        public List<RecycleQuestionOptionInfo> OptionList { get; set; }

        /// <summary>
        /// 问题编码
        /// </summary>
        [XmlElement("question_code")]
        public string QuestionCode { get; set; }

        /// <summary>
        /// 问题名称
        /// </summary>
        [XmlElement("question_name")]
        public string QuestionName { get; set; }
    }
}
