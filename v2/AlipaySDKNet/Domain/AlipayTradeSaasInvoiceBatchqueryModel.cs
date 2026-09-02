using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasInvoiceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasInvoiceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 创建时间终点
        /// </summary>
        [XmlElement("gmt_create_end")]
        public string GmtCreateEnd { get; set; }

        /// <summary>
        /// 创建时间起点
        /// </summary>
        [XmlElement("gmt_create_start")]
        public string GmtCreateStart { get; set; }

        /// <summary>
        /// 发票状态
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// BLUE / RED；不传表示两类结果均可查询
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("out_request_no_list")]
        [XmlArrayItem("string")]
        public List<string> OutRequestNoList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小，建议最大 100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询模式
        /// </summary>
        [XmlElement("query_mode")]
        public string QueryMode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("saas_invoice_order_no_list")]
        [XmlArrayItem("string")]
        public List<string> SaasInvoiceOrderNoList { get; set; }
    }
}
