using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InquiryEventInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InquiryEventInfo : AopObject
    {
        /// <summary>
        /// 问诊小结链接URL
        /// </summary>
        [XmlElement("consult_summary_url")]
        public string ConsultSummaryUrl { get; set; }

        /// <summary>
        /// 问诊时间
        /// </summary>
        [XmlElement("consult_time")]
        public string ConsultTime { get; set; }

        /// <summary>
        /// 接诊医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 处方链接URL
        /// </summary>
        [XmlElement("prescription_url")]
        public string PrescriptionUrl { get; set; }

        /// <summary>
        /// 预约跳转链接
        /// </summary>
        [XmlElement("reserve_jump_url")]
        public string ReserveJumpUrl { get; set; }

        /// <summary>
        /// 预约医生姓名
        /// </summary>
        [XmlElement("reserved_doctor_name")]
        public string ReservedDoctorName { get; set; }

        /// <summary>
        /// 预约时间
        /// </summary>
        [XmlElement("reserved_time")]
        public string ReservedTime { get; set; }
    }
}
