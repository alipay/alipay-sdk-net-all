using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateVersionBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateVersionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分页查询结果
        /// </summary>
        [XmlElement("page_dto")]
        public PageDTO PageDto { get; set; }
    }
}
