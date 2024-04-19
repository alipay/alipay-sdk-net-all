using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoTextVoiceTransferResponse.
    /// </summary>
    public class AlipayEcoTextVoiceTransferResponse : AopResponse
    {
        /// <summary>
        /// 阿里云语音编号
        /// </summary>
        [XmlElement("call_id")]
        public string CallId { get; set; }

        /// <summary>
        /// 调用结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 调用结果描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
