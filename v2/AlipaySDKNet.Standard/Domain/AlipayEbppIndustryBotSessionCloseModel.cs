using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBotSessionCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryBotSessionCloseModel : AopObject
    {
        /// <summary>
        /// 机器人id
        /// </summary>
        [XmlElement("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 访客ID，由调用方提供，比如：自有app用户id、微信用户id等
        /// </summary>
        [XmlElement("identify_id")]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机器人问答会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
