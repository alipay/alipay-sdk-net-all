using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingVoucherdetailListQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherdetailListQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前的页码数
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每一页的分页条数
        /// </summary>
        [XmlElement("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 当前总记录数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 券详情
        /// </summary>
        [XmlArray("vouchers")]
        [XmlArrayItem("voucher_query_info")]
        public List<VoucherQueryInfo> Vouchers { get; set; }
    }
}
