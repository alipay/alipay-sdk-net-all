using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentMaterialInfo : AopObject
    {
        /// <summary>
        /// 检查预约单
        /// </summary>
        [XmlElement("examination_appointment_url")]
        public string ExaminationAppointmentUrl { get; set; }

        /// <summary>
        /// 检查报告
        /// </summary>
        [XmlElement("examination_report_url")]
        public string ExaminationReportUrl { get; set; }

        /// <summary>
        /// 住院通知单
        /// </summary>
        [XmlElement("hospitalization_notice_url")]
        public string HospitalizationNoticeUrl { get; set; }

        /// <summary>
        /// 住院病例/小结
        /// </summary>
        [XmlElement("hospitalization_record_url")]
        public string HospitalizationRecordUrl { get; set; }

        /// <summary>
        /// 门诊病例
        /// </summary>
        [XmlElement("outpatient_record_url")]
        public string OutpatientRecordUrl { get; set; }

        /// <summary>
        /// 病理报告
        /// </summary>
        [XmlElement("pathology_report_url")]
        public string PathologyReportUrl { get; set; }

        /// <summary>
        /// 就诊卡号或就诊二维码
        /// </summary>
        [XmlElement("patient_card_url")]
        public string PatientCardUrl { get; set; }

        /// <summary>
        /// 电子/门诊挂号单
        /// </summary>
        [XmlElement("registration_slip_url")]
        public string RegistrationSlipUrl { get; set; }

        /// <summary>
        /// 手术通知单
        /// </summary>
        [XmlElement("surgery_notice_url")]
        public string SurgeryNoticeUrl { get; set; }
    }
}
