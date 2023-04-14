using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoardIndex Data Structure.
    /// </summary>
    [Serializable]
    public class BoardIndex : AopObject
    {
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
        /// 数据产出日期，格式yyyyMMdd
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
