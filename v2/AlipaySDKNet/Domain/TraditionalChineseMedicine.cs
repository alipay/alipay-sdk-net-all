using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TraditionalChineseMedicine Data Structure.
    /// </summary>
    [Serializable]
    public class TraditionalChineseMedicine : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("medication_information_list")]
        [XmlArrayItem("medication_information")]
        public List<MedicationInformation> MedicationInformationList { get; set; }

        /// <summary>
        /// 药品用法  eg：5剂 每日一剂 水煎 400ml
        /// </summary>
        [XmlElement("usage")]
        public string Usage { get; set; }
    }
}
