using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InpatientNursingPatientInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InpatientNursingPatientInfo : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 非本人时
        /// </summary>
        [XmlElement("applicant_phone")]
        public string ApplicantPhone { get; set; }

        /// <summary>
        /// 所患疾病描述
        /// </summary>
        [XmlElement("disease_description")]
        public string DiseaseDescription { get; set; }

        /// <summary>
        /// 所患疾病照片URL
        /// </summary>
        [XmlArray("disease_photo_url_list")]
        [XmlArrayItem("string")]
        public List<string> DiseasePhotoUrlList { get; set; }

        /// <summary>
        /// 0-男，1-女
        /// </summary>
        [XmlElement("gender")]
        public long Gender { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("id_card_type")]
        public string IdCardType { get; set; }

        /// <summary>
        /// 检查报告/门诊病例URL
        /// </summary>
        [XmlArray("medical_document_url_list")]
        [XmlArrayItem("string")]
        public List<string> MedicalDocumentUrlList { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 为谁申请
        /// </summary>
        [XmlElement("patient_relation")]
        public string PatientRelation { get; set; }

        /// <summary>
        /// 脱敏显示
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 对护工的特殊需求
        /// </summary>
        [XmlElement("special_requirements")]
        public string SpecialRequirements { get; set; }
    }
}
