using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimrefundQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceClaimrefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 响应体
        /// </summary>
        [XmlElement("encrypt_response")]
        public EncryptRequest EncryptResponse { get; set; }
    }
}
