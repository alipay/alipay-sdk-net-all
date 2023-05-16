using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCertificateCertificationBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCertificateCertificationBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 凭证信息列表
        /// </summary>
        [XmlArray("certificate_info_list")]
        [XmlArrayItem("certificate_query_info")]
        public List<CertificateQueryInfo> CertificateInfoList { get; set; }
    }
}
