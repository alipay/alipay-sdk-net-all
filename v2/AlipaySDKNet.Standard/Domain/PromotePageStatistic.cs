using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromotePageStatistic Data Structure.
    /// </summary>
    [Serializable]
    public class PromotePageStatistic : AopObject
    {
        /// <summary>
        /// 留资量
        /// </summary>
        [XmlElement("conversion_cnt")]
        public string ConversionCnt { get; set; }

        /// <summary>
        /// 留资页页面ID
        /// </summary>
        [XmlElement("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// 留资页名称
        /// </summary>
        [XmlElement("page_name")]
        public string PageName { get; set; }

        /// <summary>
        /// 页面浏览pv
        /// </summary>
        [XmlElement("pv")]
        public string Pv { get; set; }

        /// <summary>
        /// 格式YYYYMMdd
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 人均停留时长(秒)
        /// </summary>
        [XmlElement("residence_time")]
        public string ResidenceTime { get; set; }

        /// <summary>
        /// 页面浏览uv
        /// </summary>
        [XmlElement("uv")]
        public string Uv { get; set; }
    }
}
