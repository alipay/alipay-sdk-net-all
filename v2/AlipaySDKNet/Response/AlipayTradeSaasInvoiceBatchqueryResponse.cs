using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasInvoiceBatchqueryResponse.
    /// </summary>
    public class AlipayTradeSaasInvoiceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 发票详细信息列表
        /// </summary>
        [XmlElement("invoice_detail_info_list")]
        public InvoiceDetailInfo InvoiceDetailInfoList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 符合条件的总记录数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
