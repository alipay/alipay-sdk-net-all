using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RankSaleTrendResult Data Structure.
    /// </summary>
    [Serializable]
    public class RankSaleTrendResult : AopObject
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 周结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 上次销量数值
        /// </summary>
        [XmlElement("last_rank_value")]
        public string LastRankValue { get; set; }

        /// <summary>
        /// 月份
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 排名
        /// </summary>
        [XmlElement("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 销量数值
        /// </summary>
        [XmlElement("rank_value")]
        public string RankValue { get; set; }

        /// <summary>
        /// 周起始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
