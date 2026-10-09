using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryEarthquakeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryEarthquakeSyncModel : AopObject
    {
        /// <summary>
        /// 六位adcode
        /// </summary>
        [XmlElement("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// 震中深度(千米)
        /// </summary>
        [XmlElement("epi_depth")]
        public string EpiDepth { get; set; }

        /// <summary>
        /// 震中烈度,单位度
        /// </summary>
        [XmlElement("epi_intensity")]
        public string EpiIntensity { get; set; }

        /// <summary>
        /// 震中纬度
        /// </summary>
        [XmlElement("epi_lat")]
        public string EpiLat { get; set; }

        /// <summary>
        /// 震中经度
        /// </summary>
        [XmlElement("epi_lon")]
        public string EpiLon { get; set; }

        /// <summary>
        /// alert:预警消息 exercise:演习 test:测试
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 震中地名
        /// </summary>
        [XmlElement("loc_name")]
        public string LocName { get; set; }

        /// <summary>
        /// 地震等级
        /// </summary>
        [XmlElement("magnitude")]
        public string Magnitude { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("mqtt_header")]
        [XmlArrayItem("m_q_t_t_header_param")]
        public List<MQTTHeaderParam> MqttHeader { get; set; }

        /// <summary>
        /// ALARM 预警消息 QUICK_REPORT 速报消息
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 地震发生时间
        /// </summary>
        [XmlElement("ori_time")]
        public string OriTime { get; set; }

        /// <summary>
        /// 来源平台
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 地震事件唯一id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// red:红色预警 orange:橙色预警 yellow:黄色预警 blue:蓝色预警
        /// </summary>
        [XmlElement("warning_level")]
        public string WarningLevel { get; set; }
    }
}
