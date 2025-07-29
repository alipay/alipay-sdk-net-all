using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentAgentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentAgentQueryModel : AopObject
    {
        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor")]
        public string Doctor { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }
    }
}
