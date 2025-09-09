using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateDetailsQueryResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateDetailsQueryResponse : AopResponse
    {
        /// <summary>
        /// 模板查询结果dto
        /// </summary>
        [XmlElement("template_dto")]
        public TemplateDTO TemplateDto { get; set; }
    }
}
