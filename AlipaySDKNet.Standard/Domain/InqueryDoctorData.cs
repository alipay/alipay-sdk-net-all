using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InqueryDoctorData Data Structure.
    /// </summary>
    [Serializable]
    public class InqueryDoctorData : AopObject
    {
        /// <summary>
        /// 医生头像
        /// </summary>
        [XmlElement("avator")]
        public string Avator { get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 执业医院科室（多个科室时用英文逗号分隔）
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 医生个人简介
        /// </summary>
        [XmlElement("doctor_desc")]
        public string DoctorDesc { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医生性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 执业医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 身份证号（医生执医许可证编号和身份证号至少填一项）
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 执医年限
        /// </summary>
        [XmlElement("practice_year")]
        public string PracticeYear { get; set; }

        /// <summary>
        /// 医生执医许可证编号（医生执医许可证编号和身份证号至少填一项）
        /// </summary>
        [XmlElement("practicing_doctor_certificate_no")]
        public string PracticingDoctorCertificateNo { get; set; }

        /// <summary>
        /// 医生擅长描述
        /// </summary>
        [XmlElement("skilled_desc")]
        public string SkilledDesc { get; set; }

        /// <summary>
        /// 医生擅长疾病（多个擅长疾病时用英文逗号分隔）
        /// </summary>
        [XmlElement("skilled_disease")]
        public string SkilledDisease { get; set; }

        /// <summary>
        /// 医生专业标签（多个标签时用英文逗号分隔）
        /// </summary>
        [XmlElement("special_tags")]
        public string SpecialTags { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
