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
        /// 充电桩预约模式的循环方式。当充电桩处于预约模式时，该参数必传。
        /// </summary>
        [XmlElement("cycle_mode")]
        public string CycleMode { get; set; }

        /// <summary>
        /// 充电桩预约模式的结束充电时间。当充电桩处于预约模式时，该参数必传。时间的格式为HH:mm，【-】表示充电桩充满为止。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 充电桩的充电启动模式
        /// </summary>
        [XmlArray("mode")]
        [XmlArrayItem("string")]
        public List<string> Mode { get; set; }

        /// <summary>
        /// 充电桩是否启用预约的标识， 开启预约：1 未开启预约：0
        /// </summary>
        [XmlElement("reservation_flag")]
        public string ReservationFlag { get; set; }

        /// <summary>
        /// 充电桩预约模式的启动充电时间。当充电桩处于预约模式时，该参数必传。时间的格式为HH:mm，【-】表示充电桩立即启动充电。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 充电桩使用的充电策略
        /// </summary>
        [XmlElement("strategy")]
        public string Strategy { get; set; }
    }
}
