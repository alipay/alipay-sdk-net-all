using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel : AopObject
    {
        /// <summary>
        /// 发票信息
        /// </summary>
        [XmlElement("invoice")]
        public Invoice Invoice { get; set; }

        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 开票请求流水号
        /// </summary>
        [XmlElement("out_invoice_request_no")]
        public string OutInvoiceRequestNo { get; set; }

        /// <summary>
        /// 即时配送运单列表
        /// </summary>
        [XmlArray("waybill_invoices")]
        [XmlArrayItem("waybill_invoice")]
        public List<WaybillInvoice> WaybillInvoices { get; set; }
    }
}
