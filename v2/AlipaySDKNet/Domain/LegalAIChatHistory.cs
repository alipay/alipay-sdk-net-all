using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LegalAIChatHistory Data Structure.
    /// </summary>
    [Serializable]
    public class LegalAIChatHistory : AopObject
    {
        /// <summary>
        /// 模型回答
        /// </summary>
        [XmlElement("assistant")]
        public string Assistant { get; set; }

        /// <summary>
        /// 用户输入内容
        /// </summary>
        [XmlElement("user")]
        public string User { get; set; }
    }
}
