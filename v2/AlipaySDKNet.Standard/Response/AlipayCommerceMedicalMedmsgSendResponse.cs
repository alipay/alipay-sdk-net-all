using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedmsgSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedmsgSendResponse : AopResponse
    {
        /// <summary>
        /// 内部消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 模板Code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
