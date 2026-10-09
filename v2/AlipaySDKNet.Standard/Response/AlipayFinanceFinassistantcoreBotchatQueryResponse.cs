using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceFinassistantcoreBotchatQueryResponse.
    /// </summary>
    public class AlipayFinanceFinassistantcoreBotchatQueryResponse : AopResponse
    {
        /// <summary>
        /// 支小宝的回复内容
        /// </summary>
        [XmlElement("zxb_chat_response")]
        public ZXBBotChatResult ZxbChatResponse { get; set; }
    }
}
