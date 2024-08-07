using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnswerStreamDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerStreamDetail : AopObject
    {
        /// <summary>
        /// 流式回复前置文案
        /// </summary>
        [XmlElement("follow_question")]
        public string FollowQuestion { get; set; }

        /// <summary>
        /// 是否流式输出
        /// </summary>
        [XmlElement("stream_out")]
        public bool StreamOut { get; set; }
    }
}
