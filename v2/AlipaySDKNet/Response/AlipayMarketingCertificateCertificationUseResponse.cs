using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCertificateCertificationUseResponse.
    /// </summary>
    public class AlipayMarketingCertificateCertificationUseResponse : AopResponse
    {
        /// <summary>
        /// 凭证核销结果
        /// </summary>
        [XmlArray("certificate_use_result_list")]
        [XmlArrayItem("certificate_use_result")]
        public List<CertificateUseResult> CertificateUseResultList { get; set; }
    }
}
