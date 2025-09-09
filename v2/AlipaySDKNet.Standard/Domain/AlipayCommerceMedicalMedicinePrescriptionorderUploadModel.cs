using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicinePrescriptionorderUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicinePrescriptionorderUploadModel : AopObject
    {
        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("depart_name")]
        public string DepartName { get; set; }

        /// <summary>
        /// 诊断列表，至少有一个主诊断，默认第一个为主诊断
        /// </summary>
        [XmlArray("disease_list")]
        [XmlArrayItem("disease_info")]
        public List<DiseaseInfo> DiseaseList { get; set; }

        /// <summary>
        /// 开方医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 药品列表
        /// </summary>
        [XmlArray("drug_info_list")]
        [XmlArrayItem("drug_info")]
        public List<DrugInfo> DrugInfoList { get; set; }

        /// <summary>
        /// 处方过期时间点，未来的时间点
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 外部医生ID
        /// </summary>
        [XmlElement("ext_doctor_id")]
        public string ExtDoctorId { get; set; }

        /// <summary>
        /// 外部处方编码
        /// </summary>
        [XmlElement("ext_prescription_code")]
        public string ExtPrescriptionCode { get; set; }

        /// <summary>
        /// 支付宝问诊ID
        /// </summary>
        [XmlElement("inquiry_id")]
        public string InquiryId { get; set; }

        /// <summary>
        /// 病例图片url列表（6张以内）
        /// </summary>
        [XmlArray("medical_picture_list")]
        [XmlArrayItem("string")]
        public List<string> MedicalPictureList { get; set; }

        /// <summary>
        /// 处方备注
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 就诊人信息
        /// </summary>
        [XmlElement("patient_info")]
        public PatientInfo PatientInfo { get; set; }

        /// <summary>
        /// 药师姓名
        /// </summary>
        [XmlElement("pharmacist_name")]
        public string PharmacistName { get; set; }

        /// <summary>
        /// 支付宝为每个对接方分配的平台号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 方笺pdf链接
        /// </summary>
        [XmlElement("prescription_pdf")]
        public string PrescriptionPdf { get; set; }

        /// <summary>
        /// 处方笺png链接
        /// </summary>
        [XmlElement("prescription_png")]
        public string PrescriptionPng { get; set; }

        /// <summary>
        /// 处方状态
        /// </summary>
        [XmlElement("prescription_status")]
        public string PrescriptionStatus { get; set; }

        /// <summary>
        /// 开方时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("prescription_time")]
        public string PrescriptionTime { get; set; }

        /// <summary>
        /// 处方类型，XY-西药；ZY-中药
        /// </summary>
        [XmlElement("prescription_type")]
        public string PrescriptionType { get; set; }
    }
}
