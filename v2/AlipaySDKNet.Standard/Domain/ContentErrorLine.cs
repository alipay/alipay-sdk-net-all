using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentErrorLine Data Structure.
    /// </summary>
    [Serializable]
    public class ContentErrorLine : AopObject
    {
        /// <summary>
        /// N品检后原本正确的值
        /// </summary>
        [XmlElement("correct_value")]
        public string CorrectValue { get; set; }

        /// <summary>
        /// 品检的错误项字段
        /// </summary>
        [XmlElement("error_field")]
        public string ErrorField { get; set; }

        /// <summary>
        /// 品检后错误值
        /// </summary>
        [XmlElement("error_value")]
        public string ErrorValue { get; set; }
    }
}
