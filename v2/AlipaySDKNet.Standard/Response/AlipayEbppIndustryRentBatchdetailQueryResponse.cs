using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRentBatchdetailQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryRentBatchdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 对账单列表
        /// </summary>
        [XmlArray("bill_detail_list")]
        [XmlArrayItem("rent_pay_query_bill_detail_list_response")]
        public List<RentPayQueryBillDetailListResponse> BillDetailList { get; set; }

        /// <summary>
        /// 对账单当前页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 对账单当前页记录数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 对账单总页数
        /// </summary>
        [XmlElement("total_page")]
        public string TotalPage { get; set; }
    }
}
