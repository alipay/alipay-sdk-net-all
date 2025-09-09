using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseInvoiceOrderQueryResponse.
    /// </summary>
    public class AnttechOceanbaseInvoiceOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 发票单列表
        /// </summary>
        [XmlArray("invoices")]
        [XmlArrayItem("obc_invoice_result")]
        public List<ObcInvoiceResult> Invoices { get; set; }

        /// <summary>
        /// 申请单状态备注，对该申请单开票状态的一些说明
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 发票申请单发票开具状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
