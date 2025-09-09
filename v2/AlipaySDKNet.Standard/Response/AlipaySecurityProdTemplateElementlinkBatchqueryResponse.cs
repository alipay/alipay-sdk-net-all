using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateElementlinkBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateElementlinkBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 元素列表
        /// </summary>
        [XmlArray("element_link_dto_list")]
        [XmlArrayItem("template_element_link_d_t_o")]
        public List<TemplateElementLinkDTO> ElementLinkDtoList { get; set; }
    }
}
