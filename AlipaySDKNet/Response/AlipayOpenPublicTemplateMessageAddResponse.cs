using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicTemplateMessageAddResponse.
    /// </summary>
    public class AlipayOpenPublicTemplateMessageAddResponse : AopResponse
    {
        /// <summary>
        /// 模板消息的详细信息
        /// </summary>
        [XmlElement("template")]
        public string Template { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
