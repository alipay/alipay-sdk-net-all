using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFHDFTreatmentProcess Data Structure.
    /// </summary>
    [Serializable]
    public class HDFHDFTreatmentProcess : AopObject
    {
        /// <summary>
        /// 诊疗经过
        /// </summary>
        [XmlElement("treatment_process_desc")]
        public string TreatmentProcessDesc { get; set; }
    }
}
