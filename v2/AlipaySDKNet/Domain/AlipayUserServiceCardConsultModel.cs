using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserServiceCardConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserServiceCardConsultModel : AopObject
    {
        /// <summary>
        /// 上下文信息
        /// </summary>
        [XmlElement("context")]
        public string Context { get; set; }

        /// <summary>
        /// 上下文id
        /// </summary>
        [XmlElement("context_id")]
        public string ContextId { get; set; }

        /// <summary>
        /// 意图场景
        /// </summary>
        [XmlElement("intent")]
        public string Intent { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 原始query
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
