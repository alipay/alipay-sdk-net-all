using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnswerContent Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerContent : AopObject
    {
        /// <summary>
        /// 数据内容
        /// </summary>
        [XmlElement("data_content")]
        public string DataContent { get; set; }

        /// <summary>
        /// 子agent能力
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// JSON,TEXT
        /// </summary>
        [XmlElement("meta_type")]
        public string MetaType { get; set; }
    }
}
