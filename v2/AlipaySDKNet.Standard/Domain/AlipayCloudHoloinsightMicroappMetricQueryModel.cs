using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudHoloinsightMicroappMetricQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudHoloinsightMicroappMetricQueryModel : AopObject
    {
        /// <summary>
        /// 聚合方式：平均值
        /// </summary>
        [XmlElement("aggregator")]
        public string Aggregator { get; set; }

        /// <summary>
        /// 返回数据为 1m 时间粒度的数据
        /// </summary>
        [XmlElement("downsample")]
        public string Downsample { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end")]
        public long End { get; set; }

        /// <summary>
        /// 补0
        /// </summary>
        [XmlElement("fillpolicy")]
        public string Fillpolicy { get; set; }

        /// <summary>
        /// 过滤条件
        /// </summary>
        [XmlArray("filters")]
        [XmlArrayItem("holo_insight_data_query_filter")]
        public List<HoloInsightDataQueryFilter> Filters { get; set; }

        /// <summary>
        /// 按照appId 进行聚合
        /// </summary>
        [XmlArray("groupby")]
        [XmlArrayItem("string")]
        public List<string> Groupby { get; set; }

        /// <summary>
        /// pod cpu 使用率
        /// </summary>
        [XmlElement("metric")]
        public string Metric { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start")]
        public long Start { get; set; }
    }
}
