using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkPattern Data Structure.
    /// </summary>
    [Serializable]
    public class WorkPattern : AopObject
    {
        /// <summary>
        /// 线路方向
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 最大工作时长，单位：小时
        /// </summary>
        [XmlElement("max_work_time")]
        public string MaxWorkTime { get; set; }

        /// <summary>
        /// 使用该班型的班次数量
        /// </summary>
        [XmlElement("work_count")]
        public long WorkCount { get; set; }

        /// <summary>
        /// 班型明细列表
        /// </summary>
        [XmlArray("work_pattern_detail_list")]
        [XmlArrayItem("work_pattern_detail")]
        public List<WorkPatternDetail> WorkPatternDetailList { get; set; }

        /// <summary>
        /// 班型编号
        /// </summary>
        [XmlElement("work_pattern_id")]
        public string WorkPatternId { get; set; }
    }
}
