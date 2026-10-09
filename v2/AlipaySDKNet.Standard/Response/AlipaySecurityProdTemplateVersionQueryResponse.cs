using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateVersionQueryResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateVersionQueryResponse : AopResponse
    {
        /// <summary>
        /// 模板版本查询返回结果
        /// </summary>
        [XmlElement("template_version_dto")]
        public TemplateVersionDTO TemplateVersionDto { get; set; }
    }
}
