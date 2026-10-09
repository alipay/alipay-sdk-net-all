using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiDailyScheduleVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiDailyScheduleVO : AopObject
    {
        /// <summary>
        /// 单天行程ID
        /// </summary>
        [XmlElement("daily_schedule_id")]
        public string DailyScheduleId { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 用户自定义
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否超出长度
        /// </summary>
        [XmlElement("over_limit")]
        public bool OverLimit { get; set; }

        /// <summary>
        /// 环节列表
        /// </summary>
        [XmlArray("step_list")]
        [XmlArrayItem("string")]
        public List<string> StepList { get; set; }
    }
}
