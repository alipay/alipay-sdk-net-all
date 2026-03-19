using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceAuthtokenGenerateResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceAuthtokenGenerateResponse : AopResponse
    {
        /// <summary>
        /// 加密出参
        /// </summary>
        [XmlElement("encrypt_response")]
        public EncryptRequest EncryptResponse { get; set; }
    }
}
