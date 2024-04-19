using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleOdItem : AopObject
    {
        /// <summary>
        /// 客流聚类结果分段（通常为1~6）
        /// </summary>
        [XmlElement("cluster_class")]
        public string ClusterClass { get; set; }

        /// <summary>
        /// 线路方向枚举   0：上行  1 下行
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 日均下车人数
        /// </summary>
        [XmlElement("end_load")]
        public string EndLoad { get; set; }

        /// <summary>
        /// 下车人数比例
        /// </summary>
        [XmlElement("end_load_percent")]
        public string EndLoadPercent { get; set; }

        /// <summary>
        /// 下车站点名称
        /// </summary>
        [XmlElement("end_name")]
        public string EndName { get; set; }

        /// <summary>
        /// 下车站点序号
        /// </summary>
        [XmlElement("end_num")]
        public long EndNum { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 日均上车人数
        /// </summary>
        [XmlElement("start_load")]
        public string StartLoad { get; set; }

        /// <summary>
        /// 杭州东
        /// </summary>
        [XmlElement("start_name")]
        public string StartName { get; set; }

        /// <summary>
        /// 上车站点序号
        /// </summary>
        [XmlElement("start_num")]
        public long StartNum { get; set; }

        /// <summary>
        /// 发车时段，若time_span为30，则06:00:00表示06:00:00-06:30:00的时段
        /// </summary>
        [XmlElement("time_period")]
        public string TimePeriod { get; set; }
    }
}
