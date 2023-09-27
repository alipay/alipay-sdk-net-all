using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsCompetitionScheduleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsCompetitionScheduleSyncModel : AopObject
    {
        /// <summary>
        /// 实际结束时间
        /// </summary>
        [XmlElement("actual_end_date")]
        public string ActualEndDate { get; set; }

        /// <summary>
        /// 实际开始时间
        /// </summary>
        [XmlElement("actual_start_date")]
        public string ActualStartDate { get; set; }

        /// <summary>
        /// 赛程中文名称
        /// </summary>
        [XmlElement("cn_name")]
        public string CnName { get; set; }

        /// <summary>
        /// 赛事编号
        /// </summary>
        [XmlElement("competition_code")]
        public string CompetitionCode { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 大项
        /// </summary>
        [XmlElement("discipline")]
        public string Discipline { get; set; }

        /// <summary>
        /// Men's 100m Backstroke - Heats
        /// </summary>
        [XmlElement("en_name")]
        public string EnName { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 小项场次类型
        /// </summary>
        [XmlElement("event_unit_type")]
        public string EventUnitType { get; set; }

        /// <summary>
        /// 热度标签
        /// </summary>
        [XmlElement("hot_label")]
        public string HotLabel { get; set; }

        /// <summary>
        /// 热度值
        /// </summary>
        [XmlElement("hot_level")]
        public long HotLevel { get; set; }

        /// <summary>
        /// 举办地点code
        /// </summary>
        [XmlElement("location_code")]
        public string LocationCode { get; set; }

        /// <summary>
        /// location_name
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 奖牌标识
        /// </summary>
        [XmlElement("medal_flag")]
        public string MedalFlag { get; set; }

        /// <summary>
        /// 赛程状态
        /// </summary>
        [XmlElement("schedule_status")]
        public string ScheduleStatus { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 比赛编号
        /// </summary>
        [XmlElement("unit_code")]
        public string UnitCode { get; set; }

        /// <summary>
        /// 举办场馆code
        /// </summary>
        [XmlElement("venue_code")]
        public string VenueCode { get; set; }

        /// <summary>
        /// 举办场馆名称
        /// </summary>
        [XmlElement("venue_name")]
        public string VenueName { get; set; }
    }
}
