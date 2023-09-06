using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceFinassistantcoreBotchatQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceFinassistantcoreBotchatQueryModel : AopObject
    {
        /// <summary>
        /// 用户问询的问题
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 会话唯一标识
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户类型标识
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
