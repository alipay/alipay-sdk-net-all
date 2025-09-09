using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMessageNotifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalMessageNotifyResponse : AopResponse
    {
        /// <summary>
        /// 消息发送ID
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }
    }
}
