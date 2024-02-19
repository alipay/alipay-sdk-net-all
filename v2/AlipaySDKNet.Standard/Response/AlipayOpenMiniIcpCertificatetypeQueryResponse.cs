using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIcpCertificatetypeQueryResponse.
    /// </summary>
    public class AlipayOpenMiniIcpCertificatetypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件类型列表
        /// </summary>
        [XmlArray("certificate_types")]
        [XmlArrayItem("icp_certificate_type_list")]
        public List<IcpCertificateTypeList> CertificateTypes { get; set; }
    }
}
