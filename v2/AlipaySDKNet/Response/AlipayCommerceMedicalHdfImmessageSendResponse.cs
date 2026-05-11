using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfImmessageSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfImmessageSendResponse : AopResponse
    {
        /// <summary>
        /// 来源去重ID
        /// </summary>
        [XmlElement("app_msg_id")]
        public string AppMsgId { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("msg_id")]
        public long MsgId { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }
    }
}
