using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PassengerFlowPredictObject Data Structure.
    /// </summary>
    [Serializable]
    public class PassengerFlowPredictObject : AopObject
    {
        /// <summary>
        /// 进站客流预测数量
        /// </summary>
        [XmlElement("enter_passenger_flow_predict_count")]
        public long EnterPassengerFlowPredictCount { get; set; }

        /// <summary>
        /// 出站客流预测数量
        /// </summary>
        [XmlElement("exit_passenger_flow_predict_count")]
        public long ExitPassengerFlowPredictCount { get; set; }

        /// <summary>
        /// 站点序号
        /// </summary>
        [XmlElement("station_index")]
        public long StationIndex { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }
    }
}
