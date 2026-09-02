using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimrefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceClaimrefundQueryModel : AopObject
    {
        /// <summary>
        /// 请求体
        /// </summary>
        [XmlElement("encrypt_request")]
        public EncryptRequest EncryptRequest { get; set; }
    }
}
