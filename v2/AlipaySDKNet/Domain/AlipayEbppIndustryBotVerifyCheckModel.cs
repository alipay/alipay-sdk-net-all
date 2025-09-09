using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBotVerifyCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryBotVerifyCheckModel : AopObject
    {
        /// <summary>
        /// 问答机器人id。机构在光华平台配置智能体后可以获取到该字段值。
        /// </summary>
        [XmlElement("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 会话id。在机器人会话对话接口中会返回chat_id。
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 问答工具场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 会话id。在机器人会话创建接口中会返回session_id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 核身id由行业智能体调用机构的mcp接口时传递过去，机构获取到核身id后再请求支付宝校验用户核身结果
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
