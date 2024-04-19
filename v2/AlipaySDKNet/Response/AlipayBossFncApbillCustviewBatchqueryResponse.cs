using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncApbillCustviewBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncApbillCustviewBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("items_page")]
        public long ItemsPage { get; set; }

        /// <summary>
        /// 应付月账单客户视图
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("ap_monthly_bill_cust_open_api_response")]
        public List<ApMonthlyBillCustOpenApiResponse> ResultSet { get; set; }

        /// <summary>
        /// 查询到的结果总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
