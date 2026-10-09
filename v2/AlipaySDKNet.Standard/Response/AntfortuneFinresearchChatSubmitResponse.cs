using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchChatSubmitResponse.
    /// </summary>
    public class AntfortuneFinresearchChatSubmitResponse : AopResponse
    {
        /// <summary>
        /// 消息id,可用于后续异步轮询查询消息结果
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }
    }
}
