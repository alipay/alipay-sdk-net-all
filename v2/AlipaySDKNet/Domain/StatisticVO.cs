using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StatisticVO Data Structure.
    /// </summary>
    [Serializable]
    public class StatisticVO : AopObject
    {
        /// <summary>
        /// 指标是否有异常值
        /// </summary>
        [XmlElement("abnormal")]
        public bool Abnormal { get; set; }

        /// <summary>
        /// 统计指标数据结束时间（毫秒时间戳）
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 指标编码
        /// </summary>
        [XmlElement("indicator")]
        public string Indicator { get; set; }

        /// <summary>
        /// 统计数据的时间范围粒度
        /// </summary>
        [XmlElement("range_type")]
        public string RangeType { get; set; }

        /// <summary>
        /// 统计指标数据开始时间（毫秒时间戳）
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 指标字段
        /// </summary>
        [XmlElement("sub_indicator")]
        public string SubIndicator { get; set; }

        /// <summary>
        /// 指标值，单位根据指标字段而定
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
