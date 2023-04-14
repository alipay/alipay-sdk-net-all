using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndexTrendVO Data Structure.
    /// </summary>
    [Serializable]
    public class IndexTrendVO : AopObject
    {
        /// <summary>
        /// 一个数据对应的结束日期（含边界），格式yyyymmdd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 指标描述tips
        /// </summary>
        [XmlElement("index_desc")]
        public string IndexDesc { get; set; }

        /// <summary>
        /// 指标key
        /// </summary>
        [XmlElement("index_key")]
        public string IndexKey { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [XmlElement("index_name")]
        public string IndexName { get; set; }

        /// <summary>
        /// 指标值
        /// </summary>
        [XmlElement("index_value")]
        public string IndexValue { get; set; }

        /// <summary>
        /// 数据产出日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 一个数据对应的开始日期（含边界），格式yyyymmdd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
