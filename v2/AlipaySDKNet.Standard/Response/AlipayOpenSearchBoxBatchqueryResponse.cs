using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchBoxBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchBoxBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 搜索直达基础信息
        /// </summary>
        [XmlArray("box_infos")]
        [XmlArrayItem("search_box_basic_info")]
        public List<SearchBoxBasicInfo> BoxInfos { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

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
