using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceInfoQueryModel : AopObject
    {
        /// <summary>
        /// 查询入参
        /// </summary>
        [XmlElement("query_invoice_info_by_ou_open_api_dto")]
        public QueryInvoiceInfoByOuOpenApiDTO QueryInvoiceInfoByOuOpenApiDto { get; set; }
    }
}
