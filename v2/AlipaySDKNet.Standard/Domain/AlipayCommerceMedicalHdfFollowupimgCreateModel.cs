using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfFollowupimgCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfFollowupimgCreateModel : AopObject
    {
        /// <summary>
        /// 医生科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生头像链接
        /// </summary>
        [XmlElement("doctor_image")]
        public string DoctorImage { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("doctor_title")]
        public string DoctorTitle { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 二维码类型
        /// </summary>
        [XmlElement("qr_type")]
        public long QrType { get; set; }

        /// <summary>
        /// 二维码跳转链接
        /// </summary>
        [XmlElement("qr_url")]
        public string QrUrl { get; set; }
    }
}
