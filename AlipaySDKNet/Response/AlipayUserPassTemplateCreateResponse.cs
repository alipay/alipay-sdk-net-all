using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserPassTemplateCreateResponse.
    /// </summary>
    public class AlipayUserPassTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝模版ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
