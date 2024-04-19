using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCertificateCertificationRefundResponse.
    /// </summary>
    public class AlipayMarketingCertificateCertificationRefundResponse : AopResponse
    {
        /// <summary>
        /// 撤销核销结果列表
        /// </summary>
        [XmlArray("certificate_reverse_result_list")]
        [XmlArrayItem("certificate_reverse_result")]
        public List<CertificateReverseResult> CertificateReverseResultList { get; set; }
    }
}
