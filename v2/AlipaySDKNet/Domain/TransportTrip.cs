using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransportTrip Data Structure.
    /// </summary>
    [Serializable]
    public class TransportTrip : AopObject
    {
        /// <summary>
        /// 运营方向，与线路表方向相同
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 行程到达时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 行程出发时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
