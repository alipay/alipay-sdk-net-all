using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyclerkBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceCompanyclerkBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页实际数据条数
        /// </summary>
        [XmlElement("curr_page_size")]
        public long CurrPageSize { get; set; }

        /// <summary>
        /// 营业员列表信息
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("company_clerk_query_open_result")]
        public List<CompanyClerkQueryOpenResult> DataList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数量（条）
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
