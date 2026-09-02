using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzSdkEventProblemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class YpzSdkEventProblemDTO : AopObject
    {
        /// <summary>
        /// 预约编号
        /// </summary>
        [XmlElement("appointment_no")]
        public string AppointmentNo { get; set; }

        /// <summary>
        /// 预约日期时间
        /// </summary>
        [XmlElement("appointment_time")]
        public string AppointmentTime { get; set; }

        /// <summary>
        /// 院区代码
        /// </summary>
        [XmlElement("campus_code")]
        public string CampusCode { get; set; }

        /// <summary>
        /// 院区名称
        /// </summary>
        [XmlElement("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// 正确示例
        /// </summary>
        [XmlElement("correct_example")]
        public string CorrectExample { get; set; }

        /// <summary>
        /// 事件编码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

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
        /// 事件更新时间
        /// </summary>
        [XmlElement("event_update_time")]
        public string EventUpdateTime { get; set; }

        /// <summary>
        /// 事件落库创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 医疗机构名称
        /// </summary>
        [XmlElement("medical_institution_name")]
        public string MedicalInstitutionName { get; set; }

        /// <summary>
        /// 问题描述
        /// </summary>
        [XmlElement("problem_description")]
        public string ProblemDescription { get; set; }

        /// <summary>
        /// 问题字段
        /// </summary>
        [XmlElement("problem_field")]
        public string ProblemField { get; set; }

        /// <summary>
        /// 挂号流水号
        /// </summary>
        [XmlElement("registration_no")]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// 挂号时间
        /// </summary>
        [XmlElement("registration_time")]
        public string RegistrationTime { get; set; }

        /// <summary>
        /// 医疗机构统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
