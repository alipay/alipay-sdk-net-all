using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseInvoiceinfoBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseInvoiceinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 发票列表
        /// </summary>
        [XmlArray("invoice_info_list")]
        [XmlArrayItem("enterprise_invoice_info_d_t_o")]
        public List<EnterpriseInvoiceInfoDTO> InvoiceInfoList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
