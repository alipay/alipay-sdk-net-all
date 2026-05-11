using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalTransactionMessageSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalTransactionMessageSyncModel : AopObject
    {
        /// <summary>
        /// 会话卡片ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 聊天ID
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 会话意图
        /// </summary>
        [XmlElement("intent")]
        public string Intent { get; set; }

        /// <summary>
        /// 开放平台ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 阿福主体ID
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 阿福会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// medical_order_success
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
