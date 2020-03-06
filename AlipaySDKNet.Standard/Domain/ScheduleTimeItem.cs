using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleTimeItem Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleTimeItem : AopObject
    {
        /// <summary>
        /// 起点站发车时刻列表，如07:00:00,07:30:00,…,21:30:00,22:00:00
        /// </summary>
        [XmlElement("departure_time_list")]
        public string DepartureTimeList { get; set; }

        /// <summary>
        /// 线路方向，0：上行；1：下行
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 车辆上座率分布（Json格式，包含均值、方差、分位点等信息），如{‘min’:0.13, ‘max’:1.0, ‘mean’:0.35, ‘median’:0.40, ’pert_90’:0.78}
        /// </summary>
        [XmlElement("occu_rate_sts")]
        public string OccuRateSts { get; set; }

        /// <summary>
        /// 车次总数
        /// </summary>
        [XmlElement("trip_cnt")]
        public string TripCnt { get; set; }

        /// <summary>
        /// 乘客等待车次数分布（日均，Json格式），如{‘1’:9999, ‘2’:10, ‘3’:2}
        /// </summary>
        [XmlElement("wait_bus_sts")]
        public string WaitBusSts { get; set; }

        /// <summary>
        /// 乘客等车时间分布（日均，Json格式，包含均值、方差、分位点等信息），如{‘min’:0, ‘max’:10, ‘mean’:5, ‘median’:5, ’pert_90’:9}
        /// </summary>
        [XmlElement("wait_time_sts")]
        public string WaitTimeSts { get; set; }
    }
}
