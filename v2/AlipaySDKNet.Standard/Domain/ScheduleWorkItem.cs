using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleWorkItem Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleWorkItem : AopObject
    {
        /// <summary>
        /// 该班次总里程
        /// </summary>
        [XmlElement("all_miles")]
        public long AllMiles { get; set; }

        /// <summary>
        /// 该班次总车次数
        /// </summary>
        [XmlElement("all_trip_cnt")]
        public long AllTripCnt { get; set; }

        /// <summary>
        /// 班次序号
        /// </summary>
        [XmlElement("chain_num")]
        public long ChainNum { get; set; }

        /// <summary>
        /// 该班次非营运里程
        /// </summary>
        [XmlElement("invalid_miles")]
        public long InvalidMiles { get; set; }

        /// <summary>
        /// 该班次非营运车次数
        /// </summary>
        [XmlElement("invalid_trip_cnt")]
        public long InvalidTripCnt { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 优化目标，0：班次最少；1：工作时长最短；2：等待时间最少；3：工作时长最均匀
        /// </summary>
        [XmlElement("opt_type")]
        public long OptType { get; set; }

        /// <summary>
        /// 班制编号（0：通班；1：双班，2：三班）
        /// </summary>
        [XmlElement("shift_id")]
        public string ShiftId { get; set; }

        /// <summary>
        /// 车次链信息（json格式）
        /// </summary>
        [XmlElement("trip_chain")]
        public string TripChain { get; set; }

        /// <summary>
        /// 该班次营运里程
        /// </summary>
        [XmlElement("valid_miles")]
        public long ValidMiles { get; set; }

        /// <summary>
        /// 该班次营运车次数
        /// </summary>
        [XmlElement("valid_trip_cnt")]
        public long ValidTripCnt { get; set; }

        /// <summary>
        /// 等待时长 02:10:00
        /// </summary>
        [XmlElement("wait_time")]
        public string WaitTime { get; set; }

        /// <summary>
        /// 工作结束时间，如20:30:00
        /// </summary>
        [XmlElement("work_endtime")]
        public string WorkEndtime { get; set; }

        /// <summary>
        /// 班型编号（0：全天班；1：上午班，2：下午班，3：夜班）
        /// </summary>
        [XmlElement("work_id")]
        public string WorkId { get; set; }

        /// <summary>
        /// 工作开始时间，如10:00:00
        /// </summary>
        [XmlElement("work_starttime")]
        public string WorkStarttime { get; set; }

        /// <summary>
        /// 工作时长，如15:10:00
        /// </summary>
        [XmlElement("work_time")]
        public string WorkTime { get; set; }
    }
}
