using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DetectResult Data Structure.
    /// </summary>
    [Serializable]
    public class DetectResult : AopObject
    {
        /// <summary>
        /// 检测结果：有风险\无风险
        /// </summary>
        [XmlElement("detect_result")]
        public string DetectResult_ { get; set; }

        /// <summary>
        /// 检测状态：检测中\检测完成
        /// </summary>
        [XmlElement("detect_status")]
        public string DetectStatus { get; set; }

        /// <summary>
        /// 3. 消防通道占用识别: FIRE_LANE_OCCUPANCY_DETECTION
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }
    }
}
