using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiUserScheduleVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiUserScheduleVO : AopObject
    {
        /// <summary>
        /// 是否到达行程天数上限
        /// </summary>
        [XmlElement("over_limit")]
        public bool OverLimit { get; set; }

        /// <summary>
        /// 行程内容，多天
        /// </summary>
        [XmlArray("schedule_content")]
        [XmlArrayItem("open_api_daily_schedule_v_o")]
        public List<OpenApiDailyScheduleVO> ScheduleContent { get; set; }

        /// <summary>
        /// 行程ID
        /// </summary>
        [XmlElement("schedule_id")]
        public string ScheduleId { get; set; }
    }
}
