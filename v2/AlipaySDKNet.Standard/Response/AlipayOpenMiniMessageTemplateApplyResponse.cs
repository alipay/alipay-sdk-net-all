using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMessageTemplateApplyResponse.
    /// </summary>
    public class AlipayOpenMiniMessageTemplateApplyResponse : AopResponse
    {
        /// <summary>
        /// 消息模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
