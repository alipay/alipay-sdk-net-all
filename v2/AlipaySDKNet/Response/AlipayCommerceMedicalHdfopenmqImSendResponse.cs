using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfopenmqImSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfopenmqImSendResponse : AopResponse
    {
        /// <summary>
        /// 同步消息内容
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("msgid")]
        public string Msgid { get; set; }
    }
}
