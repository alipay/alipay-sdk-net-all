using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputScheduleTime Data Structure.
    /// </summary>
    [Serializable]
    public class InputScheduleTime : AopObject
    {
        /// <summary>
        /// 车容量
        /// </summary>
        [XmlElement("capacity")]
        public long Capacity { get; set; }

        /// <summary>
        /// 方向，参考方向枚举
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 预设车次数
        /// </summary>
        [XmlElement("exp_trip_cnt")]
        public long ExpTripCnt { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }
    }
}
