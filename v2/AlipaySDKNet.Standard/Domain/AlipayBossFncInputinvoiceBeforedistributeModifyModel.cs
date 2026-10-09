using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputinvoiceBeforedistributeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputinvoiceBeforedistributeModifyModel : AopObject
    {
        /// <summary>
        /// 批量修改入参
        /// </summary>
        [XmlElement("input_invoice_batch_modify_open_api_dto")]
        public InputInvoiceBatchModifyOpenApiDTO InputInvoiceBatchModifyOpenApiDto { get; set; }
    }
}
