using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGmsgSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatGmsgSendResponse : AopResponse
    {
        /// <summary>
        /// 消息索引号 会话ID_消息ID
        /// </summary>
        [XmlElement("msg_index")]
        public string MsgIndex { get; set; }
    }
}
