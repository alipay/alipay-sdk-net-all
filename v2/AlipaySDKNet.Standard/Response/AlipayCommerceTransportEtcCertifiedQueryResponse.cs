using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcCertifiedQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcCertifiedQueryResponse : AopResponse
    {
        /// <summary>
        /// 认证信息结果
        /// </summary>
        [XmlElement("etc_certified_result")]
        public EtcAuthResult EtcCertifiedResult { get; set; }
    }
}
