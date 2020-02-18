using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointAccountlogQueryResponse.
    /// </summary>
    public class AlipayAssetPointAccountlogQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 集分宝账户流水详情列表
        /// </summary>
        [XmlArray("point_account_logs")]
        [XmlArrayItem("point_account_log")]
        public List<PointAccountLog> PointAccountLogs { get; set; }

        /// <summary>
        /// 集分宝流水总条数,返回满足条件的集分宝流水的总条数。
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数，根据totalcount和pagesize计算出来
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
