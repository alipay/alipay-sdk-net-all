using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFMedicineCondition Data Structure.
    /// </summary>
    [Serializable]
    public class HDFMedicineCondition : AopObject
    {
        /// <summary>
        /// 药品描述
        /// </summary>
        [XmlElement("medicine_desc")]
        public string MedicineDesc { get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [XmlElement("medicine_name")]
        public string MedicineName { get; set; }

        /// <summary>
        /// 图片地址列表
        /// </summary>
        [XmlArray("patient_attachment_ids")]
        [XmlArrayItem("string")]
        public List<string> PatientAttachmentIds { get; set; }
    }
}
