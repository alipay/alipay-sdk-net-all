using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskComplaintInfoBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityRiskComplaintInfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 投诉详情信息列表
        /// </summary>
        [XmlArray("complaint_list")]
        [XmlArrayItem("complaint_info_query_response")]
        public List<ComplaintInfoQueryResponse> ComplaintList { get; set; }

        /// <summary>
        /// 分页查询时的当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 分页查询时每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 满足条件的数据总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
