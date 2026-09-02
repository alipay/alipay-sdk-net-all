using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryDoctorUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInquiryDoctorUploadModel : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 数据版本号（毫秒级时间戳）
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 三方科室编码
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 医生问诊类别（图文问诊，电话问诊）
        /// </summary>
        [XmlElement("doctor_category")]
        public string DoctorCategory { get; set; }

        /// <summary>
        /// 医生执业资格证编码
        /// </summary>
        [XmlElement("doctor_credential_id")]
        public string DoctorCredentialId { get; set; }

        /// <summary>
        /// 医生介绍说明
        /// </summary>
        [XmlElement("doctor_desc")]
        public string DoctorDesc { get; set; }

        /// <summary>
        /// 三方医生编码
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医生擅长领域
        /// </summary>
        [XmlElement("doctor_proficiency")]
        public string DoctorProficiency { get; set; }

        /// <summary>
        /// 医生状态(ONLINE/OFFLINE)
        /// </summary>
        [XmlElement("doctor_status")]
        public string DoctorStatus { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("doctor_title")]
        public string DoctorTitle { get; set; }

        /// <summary>
        /// 医生性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 三方医院编码
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 医生身份证号
        /// </summary>
        [XmlElement("id_card_number")]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 医生证件类型
        /// </summary>
        [XmlElement("id_card_type")]
        public string IdCardType { get; set; }

        /// <summary>
        /// 医生头像 URL
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 来源平台 code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
