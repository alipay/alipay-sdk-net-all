using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentPatientQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedagentPatientQueryResponse : AopResponse
    {
        /// <summary>
        /// 就诊人信息
        /// </summary>
        [XmlElement("data")]
        public PatientVO Data { get; set; }
    }
}
