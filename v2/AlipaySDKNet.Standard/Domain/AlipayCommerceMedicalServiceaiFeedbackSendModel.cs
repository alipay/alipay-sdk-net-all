using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceaiFeedbackSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceaiFeedbackSendModel : AopObject
    {
        /// <summary>
        /// 智能体ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// AI生成内容
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 对话ID
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 用户主动反馈内容
        /// </summary>
        [XmlElement("feedback")]
        public string Feedback { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部用户的唯一ID
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 当out_user_id为2088uid时，需将这个值设置为：ALIPAY_UID；当out_user_id为其他值时，可将这个值设置为：OTHER_UID，当传入out_open_id时，out_user_type对应的值为ALIPAY_OPENID
        /// </summary>
        [XmlElement("out_user_type")]
        public string OutUserType { get; set; }

        /// <summary>
        /// AI Query
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// AI生成后用户针对AI生成内容做出部分改写后采用
        /// </summary>
        [XmlElement("rewrite")]
        public string Rewrite { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 支付宝链路id
        /// </summary>
        [XmlElement("trace_no")]
        public string TraceNo { get; set; }
    }
}
