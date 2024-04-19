using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialCertificateQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialCertificateQueryResponse : AopResponse
    {
        /// <summary>
        /// 凭证详情列表
        /// </summary>
        [XmlArray("certificate_details")]
        [XmlArrayItem("member_card_certificate_detail")]
        public List<MemberCardCertificateDetail> CertificateDetails { get; set; }

        /// <summary>
        /// 凭证条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
