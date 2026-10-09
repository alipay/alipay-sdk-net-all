using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelCertificateIdentifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelCertificateIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 出生证明信息
        /// </summary>
        [XmlElement("birth_certificate")]
        public BirthCertificateDTO BirthCertificate { get; set; }

        /// <summary>
        /// 户口本信息
        /// </summary>
        [XmlElement("household_registration")]
        public HouseholdRegistrationDTO HouseholdRegistration { get; set; }
    }
}
