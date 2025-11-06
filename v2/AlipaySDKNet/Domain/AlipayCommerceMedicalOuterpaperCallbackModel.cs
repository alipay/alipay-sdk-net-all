using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOuterpaperCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOuterpaperCallbackModel : AopObject
    {
        /// <summary>
        /// 医生信息
        /// </summary>
        [XmlElement("doctor_info")]
        public HDFDoctorInfo DoctorInfo { get; set; }

        /// <summary>
        /// 存所有数据json，后续转病程
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 履约订单Id
        /// </summary>
        [XmlElement("fulfillment_order_id")]
        public string FulfillmentOrderId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("medical_content_list")]
        [XmlArrayItem("h_d_f_medical_content")]
        public List<HDFMedicalContent> MedicalContentList { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("partner_order_id")]
        public string PartnerOrderId { get; set; }

        /// <summary>
        /// 患者信息
        /// </summary>
        [XmlElement("patient_info")]
        public HDFPatientInfo PatientInfo { get; set; }

        /// <summary>
        /// 处方
        /// </summary>
        [XmlElement("prescription_info")]
        public HDFPrescription PrescriptionInfo { get; set; }
    }
}
