using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HmAppointInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HmAppointInfo : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("appoint_age")]
        public string AppointAge { get; set; }

        /// <summary>
        /// 出生年月日（yyyy-MM-dd）
        /// </summary>
        [XmlElement("appoint_birthday")]
        public string AppointBirthday { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("appoint_certificate_no")]
        public string AppointCertificateNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("appoint_certificate_type")]
        public string AppointCertificateType { get; set; }

        /// <summary>
        /// 所在城市
        /// </summary>
        [XmlElement("appoint_city")]
        public string AppointCity { get; set; }

        /// <summary>
        /// 需求或病情描述
        /// </summary>
        [XmlElement("appoint_description")]
        public string AppointDescription { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("appoint_gender")]
        public string AppointGender { get; set; }

        /// <summary>
        /// 就诊医院名称
        /// </summary>
        [XmlElement("appoint_hospital")]
        public string AppointHospital { get; set; }

        /// <summary>
        /// 就诊医院科室
        /// </summary>
        [XmlElement("appoint_hospital_department")]
        public string AppointHospitalDepartment { get; set; }

        /// <summary>
        /// 预约姓名
        /// </summary>
        [XmlElement("appoint_name")]
        public string AppointName { get; set; }

        /// <summary>
        /// 预约手机号
        /// </summary>
        [XmlElement("appoint_number")]
        public string AppointNumber { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("appoint_service_type")]
        public string AppointServiceType { get; set; }

        /// <summary>
        /// 预约就诊时间（yyyy-MM-dd HH:mm）
        /// </summary>
        [XmlElement("appoint_time")]
        public string AppointTime { get; set; }
    }
}
