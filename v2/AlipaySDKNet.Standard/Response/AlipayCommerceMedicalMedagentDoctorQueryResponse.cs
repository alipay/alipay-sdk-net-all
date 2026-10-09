using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentDoctorQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedagentDoctorQueryResponse : AopResponse
    {
        /// <summary>
        /// 医生信息
        /// </summary>
        [XmlElement("data")]
        public GetDoctorResult Data { get; set; }
    }
}
