using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceTrendsMetric Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceTrendsMetric : AopObject
    {
        /// <summary>
        /// 趋势类型
        /// </summary>
        [XmlElement("aggr_day")]
        public string AggrDay { get; set; }

        /// <summary>
        /// 数据日期
        /// </summary>
        [XmlElement("data_dt")]
        public string DataDt { get; set; }

        /// <summary>
        /// 服务点击PV
        /// </summary>
        [XmlElement("service_pv")]
        public long ServicePv { get; set; }

        /// <summary>
        /// 服务UV
        /// </summary>
        [XmlElement("service_uv")]
        public long ServiceUv { get; set; }
    }
}
