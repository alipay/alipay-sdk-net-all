using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingVoucherBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        [XmlElement("items_per_page")]
        public string ItemsPerPage { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public string TotalPages { get; set; }

        /// <summary>
        /// 券列表
        /// </summary>
        [XmlArray("vouchers")]
        [XmlArrayItem("open_voucher_d_t_o")]
        public List<OpenVoucherDTO> Vouchers { get; set; }
    }
}
