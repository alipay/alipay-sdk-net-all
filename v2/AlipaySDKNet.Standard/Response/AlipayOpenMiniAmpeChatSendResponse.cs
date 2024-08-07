using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeChatSendResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeChatSendResponse : AopResponse
    {
        /// <summary>
        /// 对话服务的回答，经过编码的字符串，只需要将该响应字符串交由支付宝客户端处理即可。
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 请求流水，回传
        /// </summary>
        [XmlElement("req_no")]
        public string ReqNo { get; set; }

        /// <summary>
        /// 会话id，回传
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
