using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolCertNumQueryResponse.
    /// </summary>
    public class AlipayMarketingToolCertNumQueryResponse : AopResponse
    {
        /// <summary>
        /// 凭证可用点数列表。
        /// </summary>
        [XmlArray("cert_available_num")]
        [XmlArrayItem("cert_available_num_v_o")]
        public List<CertAvailableNumVO> CertAvailableNum { get; set; }
    }
}
