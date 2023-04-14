using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoicerelateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodInvoicerelateCreateModel : AopObject
    {
        /// <summary>
        /// 关联发票请求
        /// </summary>
        [XmlElement("relate_input_invoice_order_dto")]
        public RelateInputInvoiceOrderDTO RelateInputInvoiceOrderDto { get; set; }
    }
}
