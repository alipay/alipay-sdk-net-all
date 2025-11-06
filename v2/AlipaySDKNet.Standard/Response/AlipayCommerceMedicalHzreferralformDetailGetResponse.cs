using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHzreferralformDetailGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalHzreferralformDetailGetResponse : AopResponse
    {
        /// <summary>
        /// 患者的年龄，单位“岁”
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 患者所在地区信息
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 患者身份信息
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 签约医生的手机号
        /// </summary>
        [XmlElement("doctor_phone_no")]
        public string DoctorPhoneNo { get; set; }

        /// <summary>
        /// 医生对于转诊处理的备注
        /// </summary>
        [XmlElement("doctor_remark")]
        public string DoctorRemark { get; set; }

        /// <summary>
        /// 患者期望的就诊时间
        /// </summary>
        [XmlElement("expected_date")]
        public string ExpectedDate { get; set; }

        /// <summary>
        /// 患者期望的就诊医院
        /// </summary>
        [XmlElement("expected_hospital")]
        public string ExpectedHospital { get; set; }

        /// <summary>
        /// 转诊单的创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 转诊单的更新时间
        /// </summary>
        [XmlElement("gmt_modify")]
        public string GmtModify { get; set; }

        /// <summary>
        /// 患者拍摄的图片，帮助分析病情
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("string")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 患者过去患病的历史，帮助分析病情
        /// </summary>
        [XmlElement("pass_history")]
        public string PassHistory { get; set; }

        /// <summary>
        /// 患者的手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 转诊单单号，为转诊单表的主键，自动生成，提供给外部使用
        /// </summary>
        [XmlElement("referral_form_id")]
        public string ReferralFormId { get; set; }

        /// <summary>
        /// 患者对于就诊的备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 患者的自测量表，用于分析病情
        /// </summary>
        [XmlElement("scales")]
        public string Scales { get; set; }

        /// <summary>
        /// 患者性别信息
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 转诊单的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 患者对于病情的描述
        /// </summary>
        [XmlElement("user_description")]
        public string UserDescription { get; set; }

        /// <summary>
        /// 患者的姓名信息
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 医生选择的就诊科室
        /// </summary>
        [XmlElement("visit_department")]
        public string VisitDepartment { get; set; }

        /// <summary>
        /// 医生选择的就诊医生
        /// </summary>
        [XmlElement("visit_doctor")]
        public string VisitDoctor { get; set; }

        /// <summary>
        /// 医生选择的就诊医院
        /// </summary>
        [XmlElement("visit_hospital")]
        public string VisitHospital { get; set; }

        /// <summary>
        /// 医生选择的就诊时间
        /// </summary>
        [XmlElement("visit_time")]
        public string VisitTime { get; set; }
    }
}
