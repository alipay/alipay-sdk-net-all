using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfinvoiceOutputproformanobillApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfinvoiceOutputproformanobillApplyModel : AopObject
    {
        /// <summary>
        /// 国际新增发票OpenApiOrder
        /// </summary>
        [XmlElement("proforma_invoice_add_order")]
        public OpenApiProformaInvoiceAddOrder ProformaInvoiceAddOrder { get; set; }
    }
}
