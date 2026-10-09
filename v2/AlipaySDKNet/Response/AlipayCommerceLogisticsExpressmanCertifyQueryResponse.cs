using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsExpressmanCertifyQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsExpressmanCertifyQueryResponse : AopResponse
    {
        /// <summary>
        /// true 开通快递员之家 false 未开通快递员之家
        /// </summary>
        [XmlElement("certify")]
        public bool Certify { get; set; }

        /// <summary>
        /// 未认证前端跳转链接
        /// </summary>
        [XmlElement("certify_url")]
        public string CertifyUrl { get; set; }
    }
}
