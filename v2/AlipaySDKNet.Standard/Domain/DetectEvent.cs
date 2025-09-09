using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DetectEvent Data Structure.
    /// </summary>
    [Serializable]
    public class DetectEvent : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("event_attrs")]
        [XmlArrayItem("event_attr_d_t_o")]
        public List<EventAttrDTO> EventAttrs { get; set; }

        /// <summary>
        /// 事件编码： 1. 消控室离岗识别: FMC_ABSENCE_DETECTION 2. 消控室睡岗识别: FMC_SLEEP_DETECTION 3. 消防通道占用识别: FIRE_LANE_OCCUPANCY_DETECTION
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }
    }
}
