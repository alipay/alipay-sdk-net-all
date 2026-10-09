using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateComponentGenerateResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateComponentGenerateResponse : AopResponse
    {
        /// <summary>
        /// 模板创建结果
        /// </summary>
        [XmlElement("template_element_link_dto")]
        public TemplateElementLinkDTO TemplateElementLinkDto { get; set; }
    }
}
