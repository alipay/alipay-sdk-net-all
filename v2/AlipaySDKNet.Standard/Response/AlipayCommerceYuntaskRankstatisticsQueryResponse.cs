using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskRankstatisticsQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskRankstatisticsQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 云店排名统计信息
        /// </summary>
        [XmlArray("rank_statistic")]
        [XmlArrayItem("yun_task_rank_statistic")]
        public List<YunTaskRankStatistic> RankStatistic { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
