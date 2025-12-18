using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceaiStreamchatQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceaiStreamchatQueryModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 业务信息
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 当out_user_id为2088uid时，需将这个值设置为：ALIPAY_UID；当out_user_id为其他值时，可将这个值设置为：OTHER_UID，当传入out_open_id时，out_user_type对应的值为ALIPAY_OPENID
        /// </summary>
        [XmlElement("out_user_type")]
        public string OutUserType { get; set; }

        /// <summary>
        /// 用户问题描述，初始化时无query
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 用户提问类型
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 区分当前对话场景意图 待分配后传入固定值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
