using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsRankSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsRankSyncModel : AopObject
    {
        /// <summary>
        /// 外部排行榜Id，用于区分不同场景下的排行榜信息
        /// </summary>
        [XmlElement("out_ranking_id")]
        public string OutRankingId { get; set; }

        /// <summary>
        /// 榜单成员列表
        /// </summary>
        [XmlArray("rank_members")]
        [XmlArrayItem("rank_member_info")]
        public List<RankMemberInfo> RankMembers { get; set; }

        /// <summary>
        /// 榜单名称 如：亚运奖牌排行榜
        /// </summary>
        [XmlElement("ranking_name")]
        public string RankingName { get; set; }
    }
}
