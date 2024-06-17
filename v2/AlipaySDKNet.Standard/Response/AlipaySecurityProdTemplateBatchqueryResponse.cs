using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 模版对象列表
        /// </summary>
        [XmlArray("template_dto_list")]
        [XmlArrayItem("template_d_t_o")]
        public List<TemplateDTO> TemplateDtoList { get; set; }
    }
}
