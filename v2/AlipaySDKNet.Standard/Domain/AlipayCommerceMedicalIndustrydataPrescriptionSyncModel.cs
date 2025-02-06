using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataPrescriptionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataPrescriptionSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝问诊单id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 审方药师姓名
        /// </summary>
        [XmlElement("audit_pharmacist_name")]
        public string AuditPharmacistName { get; set; }

        /// <summary>
        /// 诊断结果
        /// </summary>
        [XmlElement("clinic_desc")]
        public string ClinicDesc { get; set; }

        /// <summary>
        /// 开方医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 处方药品
        /// </summary>
        [XmlArray("drug_list")]
        [XmlArrayItem("platform_prescription_drug_info")]
        public List<PlatformPrescriptionDrugInfo> DrugList { get; set; }

        /// <summary>
        /// 分组号
        /// </summary>
        [XmlElement("group_no")]
        public string GroupNo { get; set; }

        /// <summary>
        /// 开具处方的互联网医院全称
        /// </summary>
        [XmlElement("medical_institution_name")]
        public string MedicalInstitutionName { get; set; }

        /// <summary>
        /// 开方外部医生ID
        /// </summary>
        [XmlElement("merchant_doctor_id")]
        public string MerchantDoctorId { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部审方药师id
        /// </summary>
        [XmlElement("out_audit_pharmacist_id")]
        public string OutAuditPharmacistId { get; set; }

        /// <summary>
        /// 外部问诊单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部处方id
        /// </summary>
        [XmlElement("out_prescription_id")]
        public string OutPrescriptionId { get; set; }

        /// <summary>
        /// 外部处方跳转链接
        /// </summary>
        [XmlElement("out_prescription_url")]
        public string OutPrescriptionUrl { get; set; }

        /// <summary>
        /// 患者年龄
        /// </summary>
        [XmlElement("patient_age")]
        public string PatientAge { get; set; }

        /// <summary>
        /// 患者身份证号
        /// </summary>
        [XmlElement("patient_idcard")]
        public string PatientIdcard { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 患者手机号
        /// </summary>
        [XmlElement("patient_phone")]
        public string PatientPhone { get; set; }

        /// <summary>
        /// 患者性别 枚举值： 男：MALE  女：FEMALE
        /// </summary>
        [XmlElement("patient_sex")]
        public string PatientSex { get; set; }

        /// <summary>
        /// 外部平台编号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 处方状态
        /// </summary>
        [XmlElement("prescription_status")]
        public string PrescriptionStatus { get; set; }

        /// <summary>
        /// 开方时间
        /// </summary>
        [XmlElement("prescription_time")]
        public string PrescriptionTime { get; set; }

        /// <summary>
        /// 处方类型： 中药 CHINESE_MEDICINE、西药 WESTERN_MEDICINE
        /// </summary>
        [XmlElement("prescription_type")]
        public string PrescriptionType { get; set; }

        /// <summary>
        /// 中药处方症型
        /// </summary>
        [XmlElement("syndrome_type")]
        public string SyndromeType { get; set; }
    }
}
