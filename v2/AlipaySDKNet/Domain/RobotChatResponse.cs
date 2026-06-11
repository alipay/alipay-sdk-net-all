using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RobotChatResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RobotChatResponse : AopObject
    {
        /// <summary>
        /// agent回答具体信息。
        /// </summary>
        [XmlElement("answer_content")]
        public string AnswerContent { get; set; }

        /// <summary>
        /// 具体回答的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
