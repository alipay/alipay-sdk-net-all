using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingVoucherBillQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前的页码数
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页分页条数
        /// </summary>
        [XmlElement("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 查询结果的总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 券账单信息
        /// </summary>
        [XmlArray("voucher_bills")]
        [XmlArrayItem("voucher_bill")]
        public List<VoucherBill> VoucherBills { get; set; }
    }
}
