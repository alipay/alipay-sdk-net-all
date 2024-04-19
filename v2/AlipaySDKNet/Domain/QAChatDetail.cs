using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QAChatDetail Data Structure.
    /// </summary>
    [Serializable]
    public class QAChatDetail : AopObject
    {
        /// <summary>
        /// 机器人回答详情
        /// </summary>
        [XmlElement("answer")]
        public RobotAnswer Answer { get; set; }

        /// <summary>
        /// DOCUMENT:大模型文档问答； KNOWLEDGE：知识点问答； DST：多轮问答； SORRY：致歉语；
        /// </summary>
        [XmlElement("answer_type")]
        public string AnswerType { get; set; }

        /// <summary>
        /// 本次机器人回答的id
        /// </summary>
        [XmlElement("chat_uuid")]
        public string ChatUuid { get; set; }

        /// <summary>
        /// 问题内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 未评价:0 好评:1 差评:-1
        /// </summary>
        [XmlElement("vote_type")]
        public string VoteType { get; set; }
    }
}
