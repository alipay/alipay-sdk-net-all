using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceResult Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceResult : AopObject
    {
        /// <summary>
        /// 实际就医科室
        /// </summary>
        [XmlElement("actual_department")]
        public string ActualDepartment { get; set; }

        /// <summary>
        /// 实际就医医院
        /// </summary>
        [XmlElement("actual_hospital")]
        public string ActualHospital { get; set; }

        /// <summary>
        /// 就医建议
        /// </summary>
        [XmlElement("medical_advice")]
        public string MedicalAdvice { get; set; }

        /// <summary>
        /// 服务小结图片URL
        /// </summary>
        [XmlArray("service_summary_photo_url_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceSummaryPhotoUrlList { get; set; }

        /// <summary>
        /// 特殊需求记录
        /// </summary>
        [XmlElement("special_requirements_record")]
        public string SpecialRequirementsRecord { get; set; }

        /// <summary>
        /// 满意度调查附件URL
        /// </summary>
        [XmlArray("survey_attachment_url_list")]
        [XmlArrayItem("string")]
        public List<string> SurveyAttachmentUrlList { get; set; }
    }
}
