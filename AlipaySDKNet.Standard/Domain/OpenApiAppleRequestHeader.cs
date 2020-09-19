using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiAppleRequestHeader Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiAppleRequestHeader : AopObject
    {
        /// <summary>
        /// 会话id，一般会在响应中带回给商户。
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 请求id，一般会在相应中带回给商户
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
