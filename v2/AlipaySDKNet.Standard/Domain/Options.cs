using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Options Data Structure.
    /// </summary>
    [Serializable]
    public class Options : AopObject
    {
        /// <summary>
        /// 选项内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 题库标准答案标记：true 表示该选项为该题标准答案（题目固有属性，随报告回显）
        /// </summary>
        [XmlElement("correct")]
        public bool Correct { get; set; }

        /// <summary>
        /// 选项ID
        /// </summary>
        [XmlElement("option_id")]
        public string OptionId { get; set; }

        /// <summary>
        /// 选项得分/淘汰规则(分)
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
