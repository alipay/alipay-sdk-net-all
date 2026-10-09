using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExperimentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExperimentInfo : AopObject
    {
        /// <summary>
        /// 算法组按日的明细数据
        /// </summary>
        [XmlArray("algo_group_detail_data")]
        [XmlArrayItem("date_data")]
        public List<DateData> AlgoGroupDetailData { get; set; }

        /// <summary>
        /// 对照组按日的明细数据
        /// </summary>
        [XmlArray("control_group_detail_data")]
        [XmlArrayItem("date_data")]
        public List<DateData> ControlGroupDetailData { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 实验Id
        /// </summary>
        [XmlElement("experiment_id")]
        public string ExperimentId { get; set; }

        /// <summary>
        /// 实验流量百分比
        /// </summary>
        [XmlElement("flow")]
        public string Flow { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
