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
        /// 是否是支付宝通用知识回答，是true，否false。
        /// </summary>
        [XmlElement("general_bottom_line_answer")]
        public bool GeneralBottomLineAnswer { get; set; }

        /// <summary>
        /// 通用回答提示语，general_bottom_line_answer=true时才有值。
        /// </summary>
        [XmlElement("general_bottom_line_answer_hint")]
        public string GeneralBottomLineAnswerHint { get; set; }

        /// <summary>
        /// 是否流式输出
        /// </summary>
        [XmlElement("stream_out")]
        public bool StreamOut { get; set; }
    }
}
