using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceInfoQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result_set")]
        public InvoiceInfoOpenApiResponseDTO ResultSet { get; set; }
    }
}
