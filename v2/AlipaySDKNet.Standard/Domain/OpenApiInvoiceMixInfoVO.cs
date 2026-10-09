using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiInvoiceMixInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiInvoiceMixInfoVO : AopObject
    {
        /// <summary>
        /// 预览融合信息生成的发票列表
        /// </summary>
        [XmlArray("output_invoices")]
        [XmlArrayItem("open_api_output_invoice_v_o")]
        public List<OpenApiOutputInvoiceVO> OutputInvoices { get; set; }

        /// <summary>
        /// 预览融合信息请求ID
        /// </summary>
        [XmlElement("preview_order_id")]
        public string PreviewOrderId { get; set; }
    }
}
