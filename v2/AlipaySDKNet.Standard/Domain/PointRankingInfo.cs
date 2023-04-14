using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PointRankingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PointRankingInfo : AopObject
    {
        /// <summary>
        /// 当前排名
        /// </summary>
        [XmlElement("current_ranking")]
        public long CurrentRanking { get; set; }

        /// <summary>
        /// 排名详情
        /// </summary>
        [XmlArray("ranking_list")]
        [XmlArrayItem("ranking_detail_info")]
        public List<RankingDetailInfo> RankingList { get; set; }

        /// <summary>
        /// 排名总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
