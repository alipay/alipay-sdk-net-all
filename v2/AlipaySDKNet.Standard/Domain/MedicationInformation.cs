using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicationInformation Data Structure.
    /// </summary>
    [Serializable]
    public class MedicationInformation : AopObject
    {
        /// <summary>
        /// 药品用量  eg：20.00（g）
        /// </summary>
        [XmlElement("dosage")]
        public string Dosage { get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [XmlElement("medical_name")]
        public string MedicalName { get; set; }
    }
}
