using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialCertificateSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialCertificateSyncResponse : AopResponse
    {
        /// <summary>
        /// 凭证详情
        /// </summary>
        [XmlElement("certificate_detail")]
        public MemberCardCertificateDetail CertificateDetail { get; set; }

        /// <summary>
        /// 兑换凭证是否同步成功
        /// </summary>
        [XmlElement("sync_result")]
        public bool SyncResult { get; set; }
    }
}
