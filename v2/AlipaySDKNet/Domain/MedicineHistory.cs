using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicineHistory Data Structure.
    /// </summary>
    [Serializable]
    public class MedicineHistory : AopObject
    {
        /// <summary>
        /// 用药结束时间
        /// </summary>
        [XmlElement("medication_end_date")]
        public string MedicationEndDate { get; set; }

        /// <summary>
        /// 用药开始时间
        /// </summary>
        [XmlElement("medication_start_date")]
        public string MedicationStartDate { get; set; }

        /// <summary>
        /// 用药频率
        /// </summary>
        [XmlElement("medicine_frequency")]
        public MedicineFrequency MedicineFrequency { get; set; }

        /// <summary>
        /// 药物名称
        /// </summary>
        [XmlElement("medicine_name")]
        public string MedicineName { get; set; }
    }
}
