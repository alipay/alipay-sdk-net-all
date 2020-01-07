using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询返回结果：发票信息
        /// </summary>
        [XmlElement("result_set")]
        public ArInvoiceOpenApiResponse ResultSet { get; set; }
    }
}
