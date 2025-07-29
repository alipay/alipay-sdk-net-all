using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOptionConstraint Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOptionConstraint : AopObject
    {
        /// <summary>
        /// 受影响问题code
        /// </summary>
        [XmlElement("question_code")]
        public string QuestionCode { get; set; }

        /// <summary>
        /// 保留的选项code集合
        /// </summary>
        [XmlArray("retain_options")]
        [XmlArrayItem("string")]
        public List<string> RetainOptions { get; set; }

        /// <summary>
        /// 选择选项code
        /// </summary>
        [XmlElement("selected_option_code")]
        public string SelectedOptionCode { get; set; }
    }
}
