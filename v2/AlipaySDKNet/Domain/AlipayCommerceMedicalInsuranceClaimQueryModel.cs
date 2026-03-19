using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceClaimQueryModel : AopObject
    {
        /// <summary>
        /// 加密入参
        /// </summary>
        [XmlElement("encrypt_request")]
        public EncryptRequest EncryptRequest { get; set; }
    }
}
