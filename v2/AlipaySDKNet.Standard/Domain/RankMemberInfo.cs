using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RankMemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RankMemberInfo : AopObject
    {
        /// <summary>
        /// 分组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 排行榜成员名称如：中国
        /// </summary>
        [XmlElement("member_name")]
        public string MemberName { get; set; }

        /// <summary>
        /// 外部成员ID
        /// </summary>
        [XmlElement("out_member_id")]
        public string OutMemberId { get; set; }

        /// <summary>
        /// 排行值
        /// </summary>
        [XmlElement("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// W、D、L分别是 胜、平、负 GS代表进球 GA 代表失球 sortRank 代表排序 total 代表奖牌总数 GD代表净胜球 P代表是积分 gold代表金牌 silver代表银牌 bronze代表铜牌
        /// </summary>
        [XmlElement("rank_detail")]
        public string RankDetail { get; set; }
    }
}
