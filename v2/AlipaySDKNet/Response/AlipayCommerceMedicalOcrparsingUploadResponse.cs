using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOcrparsingUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalOcrparsingUploadResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("attachment_list")]
        [XmlArrayItem("ocr_attachment_res")]
        public List<OcrAttachmentRes> AttachmentList { get; set; }

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
