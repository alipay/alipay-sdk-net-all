using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankCertificateQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankCertificateQueryResponse : AopResponse
    {
        /// <summary>
        /// 获得证书信息
        /// </summary>
        [XmlArray("certificates")]
        [XmlArrayItem("credit_bank_certificate_experience")]
        public List<CreditBankCertificateExperience> Certificates { get; set; }
    }
}
