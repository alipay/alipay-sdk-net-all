using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppMiniTemplatemessageBatchsendResponse.
    /// </summary>
    public class AlipayOpenAppMiniTemplatemessageBatchsendResponse : AopResponse
    {
        /// <summary>
        /// 批量发送记录ID，唯一标识一次消息模板批量发送
        /// </summary>
        [XmlElement("batch_msg_id")]
        public string BatchMsgId { get; set; }
    }
}
