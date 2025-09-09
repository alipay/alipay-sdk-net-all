using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBotSessionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryBotSessionCreateModel : AopObject
    {
        /// <summary>
        /// 问答工具机器人id
        /// </summary>
        [XmlElement("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 业务请求的来源。 alipay：支付宝端内请求 pc：pc端内请求 app：业务机构自研app请求
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

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
        /// 问答工具聊天窗场景。目前只需要传default。
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 访问者ip地址
        /// </summary>
        [XmlElement("visitor_ip")]
        public string VisitorIp { get; set; }
    }
}
