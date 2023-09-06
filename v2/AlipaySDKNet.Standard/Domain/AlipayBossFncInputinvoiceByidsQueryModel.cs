using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputinvoiceByidsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputinvoiceByidsQueryModel : AopObject
    {
        /// <summary>
        /// 发票查询入参
        /// </summary>
        [XmlElement("input_invoice_query_by_ids_open_api_dto")]
        public InputInvoiceQueryByIdsOpenApiDTO InputInvoiceQueryByIdsOpenApiDto { get; set; }
    }
}
