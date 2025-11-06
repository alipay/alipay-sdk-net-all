using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthHistory Data Structure.
    /// </summary>
    [Serializable]
    public class HealthHistory : AopObject
    {
        /// <summary>
        /// 饮酒史
        /// </summary>
        [XmlElement("alcohol_history")]
        public AlcoholHistory AlcoholHistory { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("allergy_history_list")]
        [XmlArrayItem("allergy_history")]
        public List<AllergyHistory> AllergyHistoryList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("disease_history_list")]
        [XmlArrayItem("disease_history")]
        public List<DiseaseHistory> DiseaseHistoryList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("family_history_list")]
        [XmlArrayItem("family_history")]
        public List<FamilyHistory> FamilyHistoryList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("medicine_history_list")]
        [XmlArrayItem("medicine_history")]
        public List<MedicineHistory> MedicineHistoryList { get; set; }

        /// <summary>
        /// 孕产史
        /// </summary>
        [XmlElement("pregnancy_history")]
        public PregnancyHistory PregnancyHistory { get; set; }

        /// <summary>
        /// 吸烟史
        /// </summary>
        [XmlElement("smoking_history")]
        public SmokingHistory SmokingHistory { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("surgical_history_list")]
        [XmlArrayItem("surgical_history")]
        public List<SurgicalHistory> SurgicalHistoryList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("vaccination_history_list")]
        [XmlArrayItem("vaccination_history")]
        public List<VaccinationHistory> VaccinationHistoryList { get; set; }
    }
}
