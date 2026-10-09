using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquiryinfochangeUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataInquiryinfochangeUploadModel : AopObject
    {
        /// <summary>
        /// 支付宝医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 外部自己医生的唯一标识
        /// </summary>
        [XmlElement("ext_doctor_id")]
        public string ExtDoctorId { get; set; }

        /// <summary>
        /// 支付宝问诊单ID
        /// </summary>
        [XmlElement("inquiry_id")]
        public string InquiryId { get; set; }

        /// <summary>
        /// 平台编码号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 转诊原因:用于记录转诊原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
