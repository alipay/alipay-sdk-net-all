using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrivateChargingSetting Data Structure.
    /// </summary>
    [Serializable]
    public class PrivateChargingSetting : AopObject
    {
        /// <summary>
        /// 循环模式
        /// </summary>
        [XmlElement("cycle_mode")]
        public string CycleMode { get; set; }

        /// <summary>
        /// 预约启动时间 HH:mm   表示 具体时间 -            表示  充满截止
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 启动模式
        /// </summary>
        [XmlArray("mode")]
        [XmlArrayItem("string")]
        public List<string> Mode { get; set; }

        /// <summary>
        /// 预约标志: 1 表示开启预约 0 表示不开启预约
        /// </summary>
        [XmlElement("reservation_flag")]
        public string ReservationFlag { get; set; }

        /// <summary>
        /// 预约启动时间 HH:mm   表示 具体时间 -           表示  立即启动
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 充电策略
        /// </summary>
        [XmlElement("strategy")]
        public string Strategy { get; set; }
    }
}
