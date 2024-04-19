using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmOlsLeavemessageQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmOlsLeavemessageQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否存在未读的消息
        /// </summary>
        [XmlElement("exist_unread_message")]
        public bool ExistUnreadMessage { get; set; }

        /// <summary>
        /// 未读消息条数
        /// </summary>
        [XmlElement("unread_message_number")]
        public long UnreadMessageNumber { get; set; }
    }
}
