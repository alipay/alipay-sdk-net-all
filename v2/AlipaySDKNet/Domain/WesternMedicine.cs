using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WesternMedicine Data Structure.
    /// </summary>
    [Serializable]
    public class WesternMedicine : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("medication_information_list")]
        [XmlArrayItem("western_medication_information")]
        public List<WesternMedicationInformation> MedicationInformationList { get; set; }
    }
}
