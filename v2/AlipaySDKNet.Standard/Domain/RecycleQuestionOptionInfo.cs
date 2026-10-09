using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQuestionOptionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQuestionOptionInfo : AopObject
    {
        /// <summary>
        /// 选项编码
        /// </summary>
        [XmlElement("option_code")]
        public string OptionCode { get; set; }

        /// <summary>
        /// 选项文案
        /// </summary>
        [XmlElement("option_value")]
        public string OptionValue { get; set; }

        /// <summary>
        /// 问题编码
        /// </summary>
        [XmlElement("question_code")]
        public string QuestionCode { get; set; }
    }
}
