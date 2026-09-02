using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzSdkTimeLagDTOOne Data Structure.
    /// </summary>
    [Serializable]
    public class YpzSdkTimeLagDTOOne : AopObject
    {
        /// <summary>
        /// 事件标识
        /// </summary>
        [XmlElement("event_identifier")]
        public string EventIdentifier { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [XmlElement("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// 事件发生时间
        /// </summary>
        [XmlElement("event_occur_time")]
        public string EventOccurTime { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 推送落库时间
        /// </summary>
        [XmlElement("origin_gmt_create")]
        public string OriginGmtCreate { get; set; }

        /// <summary>
        /// 挂号流水号
        /// </summary>
        [XmlElement("registration_no")]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// 提醒内容
        /// </summary>
        [XmlElement("remind_content")]
        public string RemindContent { get; set; }

        /// <summary>
        /// 时间差，单位是秒
        /// </summary>
        [XmlElement("time_difference")]
        public string TimeDifference { get; set; }
    }
}
