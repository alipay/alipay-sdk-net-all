using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialCertificateCancelResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialCertificateCancelResponse : AopResponse
    {
        /// <summary>
        /// 是否取消成功
        /// </summary>
        [XmlElement("cancel_result")]
        public bool CancelResult { get; set; }

        /// <summary>
        /// 凭证详情
        /// </summary>
        [XmlElement("certificate_detail")]
        public MemberCardCertificateDetail CertificateDetail { get; set; }
    }
}
