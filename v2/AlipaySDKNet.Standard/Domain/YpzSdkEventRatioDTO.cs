using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzSdkEventRatioDTO Data Structure.
    /// </summary>
    [Serializable]
    public class YpzSdkEventRatioDTO : AopObject
    {
        /// <summary>
        /// 事件代码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 事件唯一Id去重后事件量
        /// </summary>
        [XmlElement("event_id_event_count")]
        public string EventIdEventCount { get; set; }

        /// <summary>
        /// 事件唯一Id去重后事件占比
        /// </summary>
        [XmlElement("event_id_event_rate")]
        public string EventIdEventRate { get; set; }

        /// <summary>
        /// 事件唯一Id去重后事件占比结果
        /// </summary>
        [XmlElement("event_id_event_rate_result")]
        public string EventIdEventRateResult { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [XmlElement("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// 事件发生日期
        /// </summary>
        [XmlElement("event_occur_date")]
        public string EventOccurDate { get; set; }

        /// <summary>
        /// 医疗机构名称
        /// </summary>
        [XmlElement("medical_institution_name")]
        public string MedicalInstitutionName { get; set; }

        /// <summary>
        /// 挂号数据量，已经按流水号去重统计
        /// </summary>
        [XmlElement("registration_count")]
        public string RegistrationCount { get; set; }

        /// <summary>
        /// 事件数量，已经按流水号去重统计
        /// </summary>
        [XmlElement("serial_no_event_count")]
        public string SerialNoEventCount { get; set; }

        /// <summary>
        /// 流水号去重后占挂号数据量的比重
        /// </summary>
        [XmlElement("serial_no_event_rate")]
        public string SerialNoEventRate { get; set; }

        /// <summary>
        /// 事件占比结果
        /// </summary>
        [XmlElement("serial_no_event_rate_result")]
        public string SerialNoEventRateResult { get; set; }

        /// <summary>
        /// 机构统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
