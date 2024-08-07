using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBotVoteSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryBotVoteSubmitModel : AopObject
    {
        /// <summary>
        /// 机器人id，机构用户在政务智能助理开放平台创建的机器人id，若获取不到，可联系相关人员获取
        /// </summary>
        [XmlElement("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 对话id。在对话接口中会返回该参数。每次对话返回不同的对话id。
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 访客ID，由调用方提供，例如：自有app用户id
        /// </summary>
        [XmlElement("identify_id")]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机器人会话id。在会话创建接口中会返回该参数。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户对机器人回答点踩时，选择点踩原因
        /// </summary>
        [XmlElement("vote_reason")]
        public string VoteReason { get; set; }

        /// <summary>
        /// 对机器人回答内容的投票。点赞、点踩。
        /// </summary>
        [XmlElement("vote_type")]
        public string VoteType { get; set; }
    }
}
