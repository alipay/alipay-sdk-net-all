using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryEarthquakeCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryEarthquakeCancelModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("mqtt_header")]
        [XmlArrayItem("m_q_t_t_header_param")]
        public List<MQTTHeaderParam> MqttHeader { get; set; }

        /// <summary>
        /// XX地震台
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 地震唯一id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
