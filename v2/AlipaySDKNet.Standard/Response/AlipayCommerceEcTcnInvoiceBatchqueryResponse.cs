using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTcnInvoiceBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcTcnInvoiceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 发票信息列表
        /// </summary>
        [XmlArray("invoice_info_list")]
        [XmlArrayItem("open_invoice_info")]
        public List<OpenInvoiceInfo> InvoiceInfoList { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
