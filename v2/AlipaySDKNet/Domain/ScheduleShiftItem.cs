using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleShiftItem Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleShiftItem : AopObject
    {
        /// <summary>
        /// 班次序号（可关联排班表得到具体工作计划，0表示休息）
        /// </summary>
        [XmlElement("chain_num")]
        public long ChainNum { get; set; }

        /// <summary>
        /// 轮班周期内的第几天
        /// </summary>
        [XmlElement("day_num")]
        public long DayNum { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 车辆编号id
        /// </summary>
        [XmlElement("vehicle_id")]
        public string VehicleId { get; set; }

        /// <summary>
        /// 虚拟员工编号
        /// </summary>
        [XmlElement("vir_employ_id")]
        public string VirEmployId { get; set; }
    }
}
