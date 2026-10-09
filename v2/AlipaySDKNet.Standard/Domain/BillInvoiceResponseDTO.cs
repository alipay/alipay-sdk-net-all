using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillInvoiceResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BillInvoiceResponseDTO : AopObject
    {
        /// <summary>
        /// 关联的金额1
        /// </summary>
        [XmlElement("bill_relate_amount")]
        public MultiCurrencyMoneyOpenApi BillRelateAmount { get; set; }

        /// <summary>
        /// 发票信息
        /// </summary>
        [XmlElement("invoice")]
        public InvoiceAllResponseDTO Invoice { get; set; }
    }
}
