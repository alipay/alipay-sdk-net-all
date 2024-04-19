using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchBoxactivityBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchBoxactivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动明细列表
        /// </summary>
        [XmlArray("models")]
        [XmlArrayItem("search_box_activity")]
        public List<SearchBoxActivity> Models { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public long TotalPageCount { get; set; }
    }
}
