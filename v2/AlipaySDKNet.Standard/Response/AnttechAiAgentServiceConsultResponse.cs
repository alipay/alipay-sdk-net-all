using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiAgentServiceConsultResponse.
    /// </summary>
    public class AnttechAiAgentServiceConsultResponse : AopResponse
    {
        /// <summary>
        /// 回答文本内容
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 流式响应，当输出内容未结束时，isEnd为false，最后次一次输出时，isEnd为true
        /// </summary>
        [XmlElement("answer_end")]
        public bool AnswerEnd { get; set; }

        /// <summary>
        /// 当次响应的唯一标识
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }
    }
}
