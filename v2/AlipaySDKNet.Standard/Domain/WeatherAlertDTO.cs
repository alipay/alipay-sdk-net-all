using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WeatherAlertDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WeatherAlertDTO : AopObject
    {
        /// <summary>
        /// 平台极端天气预警 code，与外部数据源 eventType.code 一对一映射，用于标识预警事件类型。
        /// </summary>
        [XmlElement("alert_code")]
        public string AlertCode { get; set; }

        /// <summary>
        /// 预警唯一 ID，用于唯一标识一条极端天气预警信息。
        /// </summary>
        [XmlElement("alert_id")]
        public string AlertId { get; set; }

        /// <summary>
        /// 预警名称，用于描述极端天气预警的名称。
        /// </summary>
        [XmlElement("alert_name")]
        public string AlertName { get; set; }

        /// <summary>
        /// 发生确定性，表示预警事件发生的确定程度。
        /// </summary>
        [XmlElement("certainty")]
        public string Certainty { get; set; }

        /// <summary>
        /// 预警触发标准，描述该极端天气预警被触发或发布所依据的条件、阈值或规则。
        /// </summary>
        [XmlElement("criteria")]
        public string Criteria { get; set; }

        /// <summary>
        /// 预警详情，用于描述极端天气预警的具体内容、影响范围、可能后果及相关提示信息。
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 预警生效时间。
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 预警信息的失效时间，表示该预警在此时间后不再生效。
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 预警标题，用于概括展示该极端天气预警的主要内容。
        /// </summary>
        [XmlElement("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// 事件预计开始时间，表示预警事件预计开始发生的时间。
        /// </summary>
        [XmlElement("onset_time")]
        public string OnsetTime { get; set; }
    }
}
