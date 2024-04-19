using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceApplyPreviewModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncOutputinvoiceApplyPreviewModel : AopObject
    {
        /// <summary>
        /// openapi 申请开票order集合
        /// </summary>
        [XmlArray("open_api_apply_invoice_orders")]
        [XmlArrayItem("open_api_apply_invoice_order")]
        public List<OpenApiApplyInvoiceOrder> OpenApiApplyInvoiceOrders { get; set; }
    }
}
