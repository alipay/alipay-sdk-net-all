using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DirectionVO Data Structure.
    /// </summary>
    [Serializable]
    public class DirectionVO : AopObject
    {
        /// <summary>
        /// 运行方向。枚举：UP=上行，DOWN=下行。
        /// </summary>
        [XmlElement("dir")]
        public string Dir { get; set; }

        /// <summary>
        /// 终点站方向名称，用于对客展示「往 XXX 方向」。
        /// </summary>
        [XmlElement("dir_name")]
        public string DirName { get; set; }

        /// <summary>
        /// 当前站点前后各 1 站（含当前站）的实时时刻。直线型通常 3 个元素（首/末站 2 个）；Y 型 4 个。
        /// </summary>
        [XmlArray("schedules")]
        [XmlArrayItem("schedule_station_v_o")]
        public List<ScheduleStationVO> Schedules { get; set; }

        /// <summary>
        /// 该方向的终点站编码。
        /// </summary>
        [XmlElement("target_station_code")]
        public string TargetStationCode { get; set; }

        /// <summary>
        /// 该方向的终点站名称。
        /// </summary>
        [XmlElement("target_station_name")]
        public string TargetStationName { get; set; }
    }
}
