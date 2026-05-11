using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSmsMessageSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalSmsMessageSendResponse : AopResponse
    {
        /// <summary>
        /// 短信回执id，用于后续查询短信发送状态
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }
    }
}
