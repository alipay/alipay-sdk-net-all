using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBotSessionConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryBotSessionConsultModel : AopObject
    {
        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [XmlElement("biz_info")]
        public BotBizInfo BizInfo { get; set; }

        /// <summary>
        /// 问答机器人id。机构在光华平台配置智能体后可以获取到该字段值。
        /// </summary>
        [XmlElement("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 机构用户在政务AI开放平台录入服务数据时选择的渠道参数，如：alipay。由于各机构数据有差异渠道数据不可枚举，具体以导入数据为准。
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
        /// 用户提问的问题
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 提问关联的问答id。在上一轮对话接口中会返回chat_id字段，取该字段值即可。
        /// </summary>
        [XmlElement("ref_chat_id")]
        public string RefChatId { get; set; }

        /// <summary>
        /// 问答工具聊天窗场景。目前只需要传default。
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 会话id。在机器人会话创建接口中会返回session_id。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 大模型问答时是否以消息流的方式推送。默认为：true
        /// </summary>
        [XmlElement("stream_output")]
        public bool StreamOutput { get; set; }

        /// <summary>
        /// true为用户选择「深度思考」，在回答内容中会返回思维链内容，具体解析逻辑参考spi：spi.alipay.ebpp.industry.bot.answer.send接口说明。
        /// </summary>
        [XmlElement("think_output")]
        public bool ThinkOutput { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
