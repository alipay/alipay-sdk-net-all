using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnswerTextDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerTextDetail : AopObject
    {
        /// <summary>
        /// 机器人对话问答返回文本类型内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
