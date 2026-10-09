using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnswerSelectDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerSelectDTO : AopObject
    {
        /// <summary>
        /// 选择元素的标签提示
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 选择元素对应的value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
