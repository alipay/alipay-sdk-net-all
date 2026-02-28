using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOcrparsingUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOcrparsingUploadModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("attachment_list")]
        [XmlArrayItem("ocr_attachment")]
        public List<OcrAttachment> AttachmentList { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 患者id
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }
    }
}
