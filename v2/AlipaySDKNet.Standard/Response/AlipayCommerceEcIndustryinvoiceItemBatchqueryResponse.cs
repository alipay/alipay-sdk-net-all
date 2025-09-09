using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceItemBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcIndustryinvoiceItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页实际数据大小
        /// </summary>
        [XmlElement("curr_page_size")]
        public long CurrPageSize { get; set; }

        /// <summary>
        /// 当前页的数据
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("company_item")]
        public List<CompanyItem> DataList { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 返回的数据总数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
