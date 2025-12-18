using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFMedicalRecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HDFMedicalRecordInfo : AopObject
    {
        /// <summary>
        /// 问诊小结
        /// </summary>
        [XmlElement("medical_summary")]
        public HDFMedicalSummary MedicalSummary { get; set; }

        /// <summary>
        /// 病例订单ID
        /// </summary>
        [XmlElement("paper_order_id")]
        public string PaperOrderId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("patient_attachment_list")]
        [XmlArrayItem("h_d_f_patient_attachment")]
        public List<HDFPatientAttachment> PatientAttachmentList { get; set; }

        /// <summary>
        /// 服务结束时间
        /// </summary>
        [XmlElement("service_end_time")]
        public string ServiceEndTime { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        [XmlElement("service_start_time")]
        public string ServiceStartTime { get; set; }
    }
}
