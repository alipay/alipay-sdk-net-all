using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsCompetitionResultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsCompetitionResultSyncModel : AopObject
    {
        /// <summary>
        /// 参赛者号码布
        /// </summary>
        [XmlElement("bib")]
        public string Bib { get; set; }

        /// <summary>
        /// 赛事编号
        /// </summary>
        [XmlElement("competition_code")]
        public string CompetitionCode { get; set; }

        /// <summary>
        /// 参赛者
        /// </summary>
        [XmlElement("competitor_code")]
        public string CompetitorCode { get; set; }

        /// <summary>
        /// 参赛者类型
        /// </summary>
        [XmlElement("competitor_type")]
        public string CompetitorType { get; set; }

        /// <summary>
        /// 参赛的运动员
        /// </summary>
        [XmlElement("composition_athletes")]
        public string CompositionAthletes { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 与第一名相差
        /// </summary>
        [XmlElement("diff")]
        public string Diff { get; set; }

        /// <summary>
        /// 是否有违规
        /// </summary>
        [XmlElement("irm")]
        public string Irm { get; set; }

        /// <summary>
        /// 被罚次数
        /// </summary>
        [XmlElement("pty")]
        public string Pty { get; set; }

        /// <summary>
        /// 晋级标志
        /// </summary>
        [XmlElement("qualification_mark")]
        public string QualificationMark { get; set; }

        /// <summary>
        /// 排名
        /// </summary>
        [XmlElement("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 记录
        /// </summary>
        [XmlElement("record_indicators")]
        public string RecordIndicators { get; set; }

        /// <summary>
        /// 比赛结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 比赛成绩状态
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }

        /// <summary>
        /// 比赛结果类型
        /// </summary>
        [XmlElement("result_type")]
        public string ResultType { get; set; }

        /// <summary>
        /// 比赛结果排序
        /// </summary>
        [XmlElement("sort_order")]
        public long SortOrder { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("start_sort_order")]
        public long StartSortOrder { get; set; }

        /// <summary>
        /// 比赛项目赛程编号
        /// </summary>
        [XmlElement("unit_code")]
        public string UnitCode { get; set; }

        /// <summary>
        /// 胜W输L平T
        /// </summary>
        [XmlElement("wlt")]
        public string Wlt { get; set; }
    }
}
