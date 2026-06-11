using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthfulfillmentReportinterpretationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthfulfillmentReportinterpretationQueryModel : AopObject
    {
        /// <summary>
        /// 聊天ID：报告解读批次号
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
