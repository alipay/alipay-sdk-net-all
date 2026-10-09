using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPointHistoryQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationPointHistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否存在下一页
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 积分明细
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }

        /// <summary>
        /// 详细数据
        /// </summary>
        [XmlArray("point_log_list")]
        [XmlArrayItem("point_log_info")]
        public List<PointLogInfo> PointLogList { get; set; }

        /// <summary>
        /// 总分页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
