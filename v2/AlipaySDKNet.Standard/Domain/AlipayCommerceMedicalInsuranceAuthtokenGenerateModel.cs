using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceAuthtokenGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceAuthtokenGenerateModel : AopObject
    {
        /// <summary>
        /// 加密入参
        /// </summary>
        [XmlElement("encrypt_request")]
        public EncryptRequest EncryptRequest { get; set; }
    }
}
