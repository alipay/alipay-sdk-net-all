using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockTrustMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockTrustMessageSendModel : AopObject
    {
        /// <summary>
        /// 消息ID，用来唯一标识一条消息
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息参数
        /// </summary>
        [XmlElement("message_params")]
        public Kv MessageParams { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// 用户ID，对于机构而言，对应蚂蚁域内的唯一用户
        /// </summary>
        [XmlElement("trust_user_id")]
        public string TrustUserId { get; set; }
    }
}
