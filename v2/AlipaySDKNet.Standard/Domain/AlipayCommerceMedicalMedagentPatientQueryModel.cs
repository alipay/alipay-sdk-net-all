using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentPatientQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentPatientQueryModel : AopObject
    {
        /// <summary>
        /// 扁鹊诊后系统内部uid
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 蚂蚁侧医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 就诊人出生日期
        /// </summary>
        [XmlElement("patient_birth")]
        public string PatientBirth { get; set; }

        /// <summary>
        /// 就诊人证件号
        /// </summary>
        [XmlElement("patient_cert_no")]
        public string PatientCertNo { get; set; }

        /// <summary>
        /// 就诊人证件类型
        /// </summary>
        [XmlElement("patient_cert_type")]
        public string PatientCertType { get; set; }

        /// <summary>
        /// 就诊人性别
        /// </summary>
        [XmlElement("patient_gender")]
        public string PatientGender { get; set; }

        /// <summary>
        /// 就诊人姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 就诊人角色
        /// </summary>
        [XmlElement("patient_role")]
        public string PatientRole { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
