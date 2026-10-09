using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdReportMetricDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AdReportMetricDetail : AopObject
    {
        /// <summary>
        /// 指标对客描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 指标code(唯一值)
        /// </summary>
        [XmlElement("metric_code")]
        public string MetricCode { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [XmlElement("metric_name")]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标转化类型num
        /// </summary>
        [XmlElement("metric_num")]
        public long MetricNum { get; set; }

        /// <summary>
        /// 指标类型-BASE:基础指标｜NATIVE:原生指标｜NATIVE@THREE:原生3天指标｜NATIVE@SEVEN：原生7天指标｜EXTEND：扩展指标
        /// </summary>
        [XmlElement("metric_type")]
        public string MetricType { get; set; }
    }
}
