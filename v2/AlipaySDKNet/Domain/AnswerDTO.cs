using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnswerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerDTO : AopObject
    {
        /// <summary>
        /// 答题内容的默认值
        /// </summary>
        [XmlElement("initial_value")]
        public string InitialValue { get; set; }

        /// <summary>
        /// 问题描述
        /// </summary>
        [XmlElement("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 答题结果
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
