using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Diagnosis Data Structure.
    /// </summary>
    [Serializable]
    public class Diagnosis : AopObject
    {
        /// <summary>
        /// 诊断疾病列表
        /// </summary>
        [XmlArray("diseases")]
        [XmlArrayItem("diagnosis_disease")]
        public List<DiagnosisDisease> Diseases { get; set; }
    }
}
